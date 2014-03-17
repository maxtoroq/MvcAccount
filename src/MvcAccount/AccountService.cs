// Copyright 2012 Max Toro Q.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System;
using System.Globalization;
using System.IO;
using System.Linq.Expressions;
using System.Net;
using System.Net.Mail;
using System.Security.Principal;
using System.Web.Mvc;
using MicroApis.ErrorModel;
using MicroApis.OperationModel;
using MvcAccount.ViewModels;

namespace MvcAccount {
   
   class AccountService {

      readonly AccountConfiguration config = AccountConfiguration.Instance;
      readonly AccountRepositoryWrapper repo;
      readonly PasswordService passServ;
      readonly FormsAuthenticationService formsAuthService;

      public AccountService() {

         this.repo = new AccountRepositoryWrapper(this.config.RequireAccountRepository());
         this.passServ = this.config.RequirePasswordService();
         this.formsAuthService = this.config.FormsAuthenticationServiceResolver();
      }

      public AccountService(AccountRepository repository, PasswordService passwordService) 
         : this(repository, passwordService, null) { }

      public AccountService(AccountRepository repository, PasswordService passwordService, FormsAuthenticationService formsAuthService) {

         if (repository == null) throw new ArgumentNullException("repository");
         if (passwordService == null) throw new ArgumentNullException("passwordService");

         this.repo = new AccountRepositoryWrapper(repository);
         this.passServ = passwordService;
         this.formsAuthService = formsAuthService ?? this.config.FormsAuthenticationServiceResolver();
      }

      public OperationResult EmailVerificationCallback(string cipher) {

         var verifData = VerificationData.Parse(cipher);

         if (verifData == null)
            return HttpStatusCode.NotFound;

         UserWrapper user = this.repo.FindUserById(verifData.UserId);

         if (user == null
            || user.EmailVerified
            || user.EmailVerificationTicketExpiration == null
            || user.EmailVerificationTicketExpiration.Value < this.config.GetNow())
            return HttpStatusCode.Gone;

         user.EmailVerified = true;
         user.EmailVerificationTicketExpiration = null;

         if (this.config.EmailVerificationEnablesUser)
            user.Disabled = false;

         this.repo.UpdateUser(user);

         return HttpStatusCode.OK;
      }

      public OperationResult SignIn(SignInInput input) {

         var result = ValidateUser(input);

         if (result.IsError)
            return result;

         this.formsAuthService.SetAuthCookie(result.ValueAsSuccess, input.RememberMe);

         return HttpStatusCode.OK;
      }

      public bool ValidateUser(string username, string password) {
         return !ValidateUser(new SignInInput { Username = username, Password = password }).IsError;
      }

      OperationResult<string> ValidateUser(SignInInput input) {

         if (input == null) throw new ArgumentNullException("input");

         var errors = new ErrorBuilder();

         if (errors.NotValid(input))
            return errors;

         string userPassNotMatchMessage = AccountResources.Validation_UserPassNotMatch.FormatInvariant(AccountResources.Model_Username);

         UserWrapper user = this.repo.FindUserByName(input.Username);

         if (errors.Not(user != null, userPassNotMatchMessage))
            return errors;

         DateTime now = this.config.GetNow();

         if (!user.Password.HasValue())
            return new OperationResult<string>(HttpStatusCode.Forbidden, AccountResources.Validation_MissingPasswordCannotAuthenticate);

         int maxInvalidAttempts = this.config.MaxInvalidSignInAttempts;

         bool passwordCorrect = this.passServ.PasswordEquals(input.Password, user.Password);
         int failedAttempts = user.FailedSignInAttempts;

         if (passwordCorrect) {

            if (user.Disabled)
               return new OperationResult<string>(HttpStatusCode.Forbidden, AccountResources.Validation_UserDisabled);

         } else  {

            if (user.Disabled)
               return new OperationResult<string>(HttpStatusCode.BadRequest, userPassNotMatchMessage);

            if (failedAttempts <= maxInvalidAttempts) {

               failedAttempts++;

               user.FailedSignInAttempts = failedAttempts;
               user.FailedSignInAttemptWindowStart = now;

               if (failedAttempts > maxInvalidAttempts
                  && this.config.DisableOnMaxInvalidSignInAttempts
                  && !user.Disabled) {

                  user.Disabled = true;
               }

               this.repo.UpdateUser(user);

               if (failedAttempts <= maxInvalidAttempts
                  || user.Disabled) {
                  
                  return new OperationResult<string>(HttpStatusCode.BadRequest, userPassNotMatchMessage);
               }
            }
         }

         if (failedAttempts > maxInvalidAttempts) {

            DateTime lockEnd = user.FailedSignInAttemptWindowStart.GetValueOrDefault().Add(this.config.SignInAttemptWindow);

            TimeSpan timeLeft = (lockEnd > now) ?
               lockEnd.Subtract(now)
               : TimeSpan.MinValue;

            double totalMinutes = timeLeft.TotalMinutes;
            double minutes = Math.Ceiling(totalMinutes);

            if (minutes > 0) {
               return new OperationResult<string>(
                  HttpStatusCode.Forbidden,
                  AccountResources.Validation_MaxInvalidSignInAttempts.FormatInvariant(minutes)
               );
            }
         }

         if (passwordCorrect) {

            user.FailedSignInAttempts = 0;
            user.FailedSignInAttemptWindowStart = null;
            user.LastSignIn = now;

         } else {

            // Window passed but password is incorrect, restart failed attempts count

            user.FailedSignInAttempts = 1;
            user.FailedSignInAttemptWindowStart = now;
         }

         this.repo.UpdateUser(user);

         if (!passwordCorrect)
            return new OperationResult<string>(HttpStatusCode.BadRequest, userPassNotMatchMessage);

         return user.Username;
      }

      public OperationResult SignOut() {

         this.formsAuthService.SignOut();

         return HttpStatusCode.OK;
      }

      public OperationResult ChangePassword(ChangePasswordInput input) {

         if (input == null) throw new ArgumentNullException("input");

         IIdentity identity = CurrentPrincipalIdentity();

         if (!identity.IsAuthenticated)
            throw new InvalidOperationException();

         var errors = new ErrorBuilder();

         if (errors.NotValid(input))
            return errors;

         UserWrapper user = this.repo.FindUserByName(identity.Name);

         if (errors.Not(user != null, AccountResources.Validation_UserNotExist.FormatInvariant(identity.Name))
            || errors.Not(this.passServ.PasswordEquals(input.CurrentPassword, user.Password), AccountResources.Validation_CurrentPasswordIncorrect, () => input.CurrentPassword)
            || !TrySetPassword(user, () => input.NewPassword, errors))
            return errors;

         this.repo.UpdateUser(user);

         return HttpStatusCode.OK;
      }

      public OperationResult<ResetPasswordResult> ResetPassword(ResetPasswordInput input, Controller controller) {

         if (input == null) throw new ArgumentNullException("input");

         var errors = new ErrorBuilder();

         if (errors.NotValid(input))
            return errors;

         UserWrapper user = this.repo.FindUserByEmail(input.Email);

         MailMessage message;
         string destinationEmail;

         bool canResetPassword = user != null
            && !user.Disabled;

         if (canResetPassword) {

            user.PasswordResetTicketExpiration = this.config.GetNow()
               .Add(this.config.PasswordResetTicketExpiration);

            this.repo.UpdateUser(user);

            var mailModel = new ResetPasswordMessageViewModel {
               SiteName = GetSiteName(controller.ControllerContext),
               Url = new VerificationData(user.Id, null).GetVerificationUrl("RP", controller).AbsoluteUri
            };

            if (!EmailEquals(user.Email, user.Username))
               mailModel.Username = user.Username;

            destinationEmail = user.Email;

            message = new MailMessage {
               To = { destinationEmail },
               Subject = AccountResources.Model_ResetPasswordMessageSubject,
               Body = RenderEmailView(Views.Account.Notifications.ResetPasswordMessage, mailModel, controller.ControllerContext)
            };
         
         } else {
            
            destinationEmail = input.Email;

            var mailModel = new ResetPasswordErrorMessageViewModel {
               SiteName = GetSiteName(controller.ControllerContext),
               ErrorReason = (user == null) ?
                  ResetPasswordErrorReason.AccountNotFound
                  : ResetPasswordErrorReason.AccountDisabled
            };

            message = new MailMessage {
               To = { destinationEmail },
               Subject = AccountResources.Model_ResetPasswordMessageSubject,
               Body = RenderEmailView(Views.Account.Notifications.ResetPasswordErrorMessage, mailModel, controller.ControllerContext)
            };
         }

         SendEmail(message);

         return new OperationResult<ResetPasswordResult>(HttpStatusCode.Accepted, new ResetPasswordResult(destinationEmail));
      }

      public OperationResult<FinishResetPasswordInput> FinishResetPassword(string cipher) {
         
         var result = CanFinishResetPassword(cipher);

         if (result.IsError)
            return new OperationResult<FinishResetPasswordInput>(result.StatusCode, result.Value);

         return new FinishResetPasswordInput();
      }

      public OperationResult FinishResetPassword(string cipher, FinishResetPasswordInput input) {

         if (input == null) throw new ArgumentNullException("input");

         var canFinishResult = CanFinishResetPassword(cipher);

         if (canFinishResult.IsError)
            return canFinishResult;

         UserWrapper user = canFinishResult.ValueAsSuccess;

         var errors = new ErrorBuilder();

         if (errors.NotValid(input)
            || !TrySetPassword(user, () => input.NewPassword, errors))
            return errors;

         user.PasswordResetTicketExpiration = null;

         this.repo.UpdateUser(user);

         return HttpStatusCode.OK;
      }

      OperationResult<UserWrapper> CanFinishResetPassword(string cipher) {

         var verifData = VerificationData.Parse(cipher);

         if (verifData == null)
            return HttpStatusCode.NotFound;

         UserWrapper user = this.repo.FindUserById(verifData.UserId);

         if (user == null
            || user.PasswordResetTicketExpiration == null
            || user.PasswordResetTicketExpiration.Value < this.config.GetNow())
            return HttpStatusCode.Gone;

         return user;
      }

      public ChangeEmailInput ChangeEmail() {

         IIdentity identity = CurrentPrincipalIdentity();

         if (!identity.IsAuthenticated)
            throw new InvalidOperationException();

         UserWrapper user = this.repo.FindUserByName(identity.Name);

         var input = new ChangeEmailInput { 
            NewEmail = user.Email
         };

         return input;
      }

      public OperationResult ChangeEmail(ChangeEmailInput input, Controller controller) {

         if (input == null) throw new ArgumentNullException("input");

         IIdentity identity = CurrentPrincipalIdentity();

         if (!identity.IsAuthenticated)
            throw new InvalidOperationException();

         var errors = new ErrorBuilder();

         if (errors.NotValid(input))
            return errors;

         UserWrapper user = this.repo.FindUserByName(identity.Name);

         string currentEmail = user.Email;
         string newEmail = input.NewEmail;

         if (errors.Not(currentEmail.HasValue(), AccountResources.Validation_MissingEmail))
            return errors;

         if (errors.Not(this.passServ.PasswordEquals(input.CurrentPassword, user.Password), AccountResources.Validation_CurrentPasswordIncorrect, () => input.CurrentPassword)
            | errors.Not(!EmailEquals(currentEmail, newEmail), AccountResources.Validation_NewEmailSameAsCurrent, () => input.NewEmail))
            return errors;

         if (errors.Not(this.repo.FindUserByEmail(newEmail) == null, AccountResources.Validation_EmailAlreadyExists, () => input.NewEmail))
            return errors;

         if (this.config.EnableEmailVerification) {

            user.EmailChangeTicketExpiration = this.config.GetNow().Add(this.config.EmailChangeTicketExpiration);

            this.repo.UpdateUser(user);

            var notifyModel = new EmailChangeNotificationMessageViewModel {
               SiteName = GetSiteName(controller.ControllerContext),
               NewEmail = newEmail,
               OldEmail = currentEmail,
               HelpResource = this.config.HelpResource
            };

            if (!EmailEquals(currentEmail, user.Username))
               notifyModel.Username = user.Username;

            var notifyMessage = new MailMessage {
               To = { user.Email },
               Subject = AccountResources.Model_EmailChangeNotificationMessageSubject,
               Body = RenderEmailView(Views.Account.Notifications.EmailChangeNotificationMessage, notifyModel, controller.ControllerContext)
            };

            var verifyModel = new EmailChangeVerificationMessageViewModel {
               SiteName = notifyModel.SiteName,
               Url = new VerificationData(user.Id, newEmail).GetVerificationUrl("VNE", controller).AbsoluteUri
            };

            var verifyMessage = new MailMessage {
               To = { newEmail },
               Subject = AccountResources.Model_EmailChangeVerificationMessageSubject,
               Body = RenderEmailView(Views.Account.Notifications.EmailChangeVerificationMessage, verifyModel, controller.ControllerContext)
            };

            SendEmail(notifyMessage);
            SendEmail(verifyMessage);

            return new OperationResult(HttpStatusCode.Accepted, new ChangeEmailResult(newEmail));
         }

         user.Email = newEmail;

         this.repo.UpdateUser(user);

         return HttpStatusCode.OK;
      }
      
      public OperationResult EmailChangeVerificationCallback(string cipher) {

         var verifData = VerificationData.Parse(cipher);

         if (verifData == null)
            return HttpStatusCode.NotFound;

         UserWrapper user = this.repo.FindUserById(verifData.UserId);

         if (user == null
            || user.EmailChangeTicketExpiration == null
            || user.EmailChangeTicketExpiration.Value < this.config.GetNow())
            return HttpStatusCode.Gone;

         string newEmail = verifData.UserData;

         user.Email = newEmail;
         user.EmailVerified = true;
         user.EmailChangeTicketExpiration = null;

         this.repo.UpdateUser(user);

         IIdentity identity = CurrentPrincipalIdentity();

         if (identity.IsAuthenticated
            && !UserEquals(user, identity)) {

            this.formsAuthService.SignOut();
         }

         return HttpStatusCode.OK;
      }

      static IIdentity CurrentPrincipalIdentity() {
         return System.Threading.Thread.CurrentPrincipal.Identity;
      }

      bool TrySetPassword(UserWrapper user, Expression<Func<string>> valueSelector, ErrorBuilder errors) {

         string newPassword = valueSelector.Compile().Invoke();

         string passErr = this.passServ.ValidatePassword(newPassword);

         if (errors.Assert(passErr == null, passErr, valueSelector)) {

            string currentPassword = user.Password;

            user.Password = this.passServ.ProcessPasswordForStorage(newPassword);

            if (errors.ValidProperty(() => user.Password))
               return true;

            user.Password = currentPassword;
         }

         return false;
      }

      static bool EmailEquals(string left, string right) {
         return String.Equals(left, right, StringComparison.OrdinalIgnoreCase);
      }

      static bool UserEquals(UserWrapper user, IIdentity identity) {
         return String.Equals(user.Username, identity.Name, StringComparison.Ordinal);
      }

      string GetSiteName(ControllerContext context) {
         return this.config.SiteName ?? context.HttpContext.Request.Url.Host;
      }

      static string RenderEmailView(string viewName, object model, ControllerContext context) {

         CultureInfo invariantCulture = CultureInfo.InvariantCulture;
         CultureInfo currentCulture = CultureInfo.CurrentUICulture;

         string viewsFolder = "Notifications/";
         ViewEngineResult viewResult;

         do {
            viewResult = ViewEngines.Engines.FindPartialView(context, (viewsFolder + "{0}.{1}").FormatInvariant(viewName, currentCulture.Name));

            if (viewResult.View == null)
               currentCulture = currentCulture.Parent;

         } while (viewResult.View == null && currentCulture != invariantCulture);

         if (viewResult.View == null) 
            viewResult = ViewEngines.Engines.FindPartialView(context, viewsFolder + viewName);

         if (viewResult.View == null)
            throw new InvalidOperationException();

         using (var output = new StringWriter()) {

            var viewContext = new ViewContext(
               context,
               viewResult.View,
               new ViewDataDictionary(model),
               new TempDataDictionary(),
               output
            );

            viewResult.View.Render(viewContext, output);

            return output.ToString();
         }
      }

      static void SendEmail(MailMessage message) {
         new SmtpClient().Send(message);
      }
   }
}
