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
using System.Net.Mail;
using System.Security.Principal;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using MicroApis.ErrorModel;
using MicroApis.OperationModel;
using MicroApis.OperationModel.Web.Mvc;
using MvcAccount.Auth;
using MvcAccount.Common;
using MvcAccount.Password;
using MvcCodeRouting.Web.Mvc;

namespace MvcAccount.Email.Change {
   
   public class ChangeController : BaseController {

      AccountRepositoryWrapper repo;
      PasswordService passServ;
      FormsAuthenticationService formsAuthService;

      public ChangeController() { }

      public ChangeController(AccountRepository repo, PasswordService passwordService) 
         : this() { 
      
         this.repo = new AccountRepositoryWrapper(repo);
         this.passServ = passwordService;
      }

      public ChangeController(AccountRepository repo, PasswordService passwordService, FormsAuthenticationService formsAuthService) 
         : this(repo, passwordService) {

         this.formsAuthService = formsAuthService;
      }

      protected override void Initialize(RequestContext requestContext) {
         
         base.Initialize(requestContext);

         this.repo = this.Configuration.RequireDependency(this.repo);
         this.passServ = this.Configuration.RequireDependency(this.passServ);
         this.formsAuthService = this.Configuration.RequireDependency(this.formsAuthService);
      }

      /// <summary>
      /// The change email page.
      /// </summary>
      /// <returns>The action result.</returns>
      [HttpGetHead]
      [Authorize]
      [DefaultAction]
      public ActionResult Change() {

         this.ViewData.Model = new ChangeViewModel(ChangeImpl());

         return View();
      }

      /// <summary>
      /// Attempts to change the email.
      /// </summary>
      /// <param name="input">The input model.</param>
      /// <returns>The action result.</returns>
      [HttpPost]
      [Authorize]
      public ActionResult Change(ChangeInput input) {

         if (input == null)
            return Change();

         this.ViewData.Model = new ChangeViewModel(input);

         if (!this.ModelState.IsValid)
            return View().WithStatus(HttpStatusCode.BadRequest);

         var result = ChangeImpl(input);

         if (result.IsError)
            return View().WithErrors(result);

         if (result.StatusCode == HttpStatusCode.Accepted) {

            this.TempData["PostChange"] = result;

            return EmptyRedirect(HttpStatusCode.SeeOther, this.Url.Action(VerificationSent));
         }

         return EmptyRedirect(HttpStatusCode.SeeOther, this.Url.Action(Saved));
      }
      
      /// <summary>
      /// A page that informs the user that his new email was saved.
      /// </summary>
      /// <returns>The action result.</returns>
      [HttpGetHead]
      [Authorize]
      public ActionResult Saved() {

         this.ViewData.Model = new SavedViewModel();

         return View();
      }

      /// <summary>
      /// A page that informs the user that the email change verification e-mail was sent.
      /// </summary>
      /// <returns>The action result.</returns>
      [HttpGetHead]
      [Authorize]
      public ActionResult VerificationSent() {

         OperationResult result = this.TempData["PostChange"] as OperationResult;
         ChangeResult resource;

         if (result == null
            || (resource = result.Value as ChangeResult) == null)
            throw new HttpException((int)HttpStatusCode.NotFound, "");

         this.ViewData.Model = new VerificationSentViewModel(resource);

         return View();
      }

      /// <summary>
      /// The email change verification callback.
      /// </summary>
      /// <param name="id">The verification email.</param>
      /// <returns>The action result.</returns>
      [HttpGet]
      public ActionResult Verify(string id) {

         var result = VerifyImpl(id);

         if (result.IsError)
            throw new HttpException((int)result.StatusCode, result.Value.ToStringInvariant());

         this.ViewData.Model = new SavedViewModel();

         return View(Views.Email.Change.Saved);
      }

      ChangeInput ChangeImpl() {

         IIdentity identity = CurrentPrincipalIdentity();

         if (!identity.IsAuthenticated)
            throw new InvalidOperationException();

         UserWrapper user = this.repo.FindUserByName(identity.Name);

         var input = new ChangeInput {
            NewEmail = user.Email
         };

         return input;
      }

      OperationResult ChangeImpl(ChangeInput input) {

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

         if (!this.Configuration.EnableEmailVerification) {

            user.Email = newEmail;

            this.repo.UpdateUser(user);

            return HttpStatusCode.OK;
         }

         user.EmailChangeTicketExpiration = this.Configuration.GetNow().Add(this.Configuration.EmailChangeTicketExpiration);

         this.repo.UpdateUser(user);

         var notifyModel = new NotificationMessageViewModel {
            SiteName = GetSiteName(),
            NewEmail = newEmail,
            OldEmail = currentEmail,
            HelpResource = this.Configuration.HelpResource
         };

         if (!EmailEquals(currentEmail, user.Username))
            notifyModel.Username = user.Username;

         var notifyMessage = new MailMessage {
            To = { user.Email },
            Subject = AccountResources.Model_EmailChangeNotificationMessageSubject,
            Body = RenderEmailView(Views.Email.Change._NotificationMessage, notifyModel)
         };

         var verifyModel = new VerificationMessageViewModel {
            SiteName = notifyModel.SiteName,
            Url = new VerificationData(user.Id, newEmail)
               .GetVerificationUrl(id => this.Url.Action(Verify, id), this).AbsoluteUri
         };

         var verifyMessage = new MailMessage {
            To = { newEmail },
            Subject = AccountResources.Model_EmailChangeVerificationMessageSubject,
            Body = RenderEmailView(Views.Email.Change._VerificationMessage, verifyModel)
         };

         SendEmail(notifyMessage);
         SendEmail(verifyMessage);

         return new OperationResult(HttpStatusCode.Accepted, new ChangeResult(newEmail));
      }

      OperationResult VerifyImpl(string cipher) {

         var verifData = VerificationData.Parse(cipher);

         if (verifData == null)
            return HttpStatusCode.NotFound;

         UserWrapper user = this.repo.FindUserById(verifData.UserId);

         if (user == null
            || user.EmailChangeTicketExpiration == null
            || user.EmailChangeTicketExpiration.Value < this.Configuration.GetNow())
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
   }
}