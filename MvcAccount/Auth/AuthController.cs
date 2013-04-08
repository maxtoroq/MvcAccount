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
using System.Net;
using System.Web.Mvc;
using MicroApis.ErrorModel;
using MicroApis.OperationModel;
using MicroApis.OperationModel.Web.Mvc;
using MvcAccount.Password;

namespace MvcAccount.Auth {
   
   /// <summary>
   /// Authentication controller.
   /// </summary>
   public class AuthController : BaseController {

      AccountRepositoryWrapper repo;
      PasswordService passServ;
      FormsAuthenticationService formsAuthService;

      public AuthController() { }

      public AuthController(AccountRepository repo, PasswordService passwordService) 
         : this() {

         this.repo = new AccountRepositoryWrapper(repo);
         this.passServ = passwordService;
      }

      public AuthController(AccountRepository repo, PasswordService passwordService, FormsAuthenticationService formsAuthService) 
         : this(repo, passwordService) {
         
         this.formsAuthService = formsAuthService;
      }

      public override void Initialize(AccountConfiguration configuration) {
         
         base.Initialize(configuration);

         this.repo = configuration.RequireDependency(this.repo);
         this.passServ = configuration.RequireDependency(this.passServ);
         this.formsAuthService = configuration.RequireDependency(this.formsAuthService);
      }

      /// <summary>
      /// The sign in page.
      /// </summary>
      /// <returns>The action result.</returns>
      [HttpGetHead]
      public ActionResult SignIn() {

         this.ViewData.Model = new SignInViewModel(new SignInInput());

         return View();
      }

      /// <summary>
      /// Attempts to sign in.
      /// </summary>
      /// <param name="input">The input model.</param>
      /// <param name="returnUrl">A URL to redirect to if the operation succeeds.</param>
      /// <returns>The action result.</returns>
      [HttpPost]
      [ValidateAntiForgeryToken]
      public ActionResult SignIn(SignInInput input, string returnUrl) {

         if (input == null)
            return SignIn();

         this.ViewData.Model = new SignInViewModel(input);

         if (!this.ModelState.IsValid)
            return View().WithStatus(HttpStatusCode.BadRequest);

         var result = SignInImpl(input);

         if (result.IsError)
            return View().WithErrors(result);

         string location = GetValidReturnUrl(returnUrl);

         return EmptyRedirect(HttpStatusCode.SeeOther, location);
      }

      OperationResult SignInImpl(SignInInput input) {

         var result = ValidateUser(input);

         if (result.IsError)
            return result;

         this.formsAuthService.SetAuthCookie(result.ValueAsSuccess, input.RememberMe);

         return HttpStatusCode.OK;
      }

      internal bool ValidateUser(string username, string password) {
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

         DateTime now = this.Configuration.GetNow();

         if (!user.Password.HasValue())
            return new OperationResult<string>(HttpStatusCode.Forbidden, AccountResources.Validation_MissingPasswordCannotAuthenticate);

         int maxInvalidAttempts = this.Configuration.MaxInvalidSignInAttempts;

         bool passwordCorrect = this.passServ.PasswordEquals(input.Password, user.Password);
         int failedAttempts = user.FailedSignInAttempts;

         if (passwordCorrect) {

            if (user.Disabled)
               return new OperationResult<string>(HttpStatusCode.Forbidden, AccountResources.Validation_UserDisabled);

         } else {

            if (user.Disabled)
               return new OperationResult<string>(HttpStatusCode.BadRequest, userPassNotMatchMessage);

            if (failedAttempts <= maxInvalidAttempts) {

               failedAttempts++;

               user.FailedSignInAttempts = failedAttempts;
               user.FailedSignInAttemptWindowStart = now;

               if (failedAttempts > maxInvalidAttempts
                  && this.Configuration.DisableOnMaxInvalidSignInAttempts
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

            DateTime lockEnd = user.FailedSignInAttemptWindowStart.GetValueOrDefault().Add(this.Configuration.SignInAttemptWindow);

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

      /// <summary>
      /// Removes the forms-authentication ticket from the browser.
      /// </summary>
      /// <param name="returnUrl">A URL to redirect to.</param>
      /// <returns>The action result.</returns>
      [HttpGet]
      public ActionResult SignOut(string returnUrl) {

         this.formsAuthService.SignOut();

         string location = GetValidReturnUrl(returnUrl);

         return EmptyRedirect(HttpStatusCode.Found, location);
      }
   }
}