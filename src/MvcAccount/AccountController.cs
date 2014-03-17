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
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.UI;
using MicroApis.OperationModel;
using MicroApis.OperationModel.Mvc;
using MvcAccount.ViewModels;

namespace MvcAccount {

   /// <summary>
   /// Exposes the functionality of MvcAccount in an ASP.NET MVC application.
   /// </summary>
   [OutputCache(Location = OutputCacheLocation.None)]
   public class AccountController : Controller {

      static readonly string ApplicationPath = VirtualPathUtility.AppendTrailingSlash(HostingEnvironment.ApplicationVirtualPath);

      readonly AccountService service;

      /// <summary>
      /// Initializes a new instance of the <see cref="AccountController"/> class.
      /// </summary>
      public AccountController() 
         : this(new AccountService()) { }

      /// <summary>
      /// Initializes a new instance of the <see cref="AccountController"/> class
      /// using the provided repository and password service.
      /// </summary>
      /// <param name="repository">The account repository.</param>
      /// <param name="passwordService">The passsword service.</param>
      public AccountController(AccountRepository repository, PasswordService passwordService)
         : this(new AccountService(repository, passwordService)) { }

      /// <summary>
      /// Initializes a new instance of the <see cref="AccountController"/> class
      /// using the provided repository, password service and forms authentication service.
      /// </summary>
      /// <param name="repository">The account repository.</param>
      /// <param name="passwordService">The passsword service.</param>
      /// <param name="formsAuthService">The forms authentication service.</param>
      public AccountController(AccountRepository repository, PasswordService passwordService, FormsAuthenticationService formsAuthService) 
         : this(new AccountService(repository, passwordService, formsAuthService)) { }

      private AccountController(AccountService service) {
         this.service = service;
      }

      /// <summary>
      /// The index page.
      /// </summary>
      /// <returns>The action result.</returns>
      [HttpGetHead]
      [Authorize]
      public ActionResult Index() {

         this.ViewData.Model = new IndexViewModel();

         return View();
      }

      /// <summary>
      /// E-mail verification callback.
      /// </summary>
      /// <param name="id">The verification ticket.</param>
      /// <returns>The action result.</returns>
      [HttpGet]
      public ActionResult VE(string id) {

         var result = this.service.EmailVerificationCallback(id);

         if (result.IsError)
            throw new HttpException((int)result.StatusCode, result.Value.ToStringInvariant());

         return View();
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

         var result = this.service.SignIn(input);

         if (result.IsError)
            return View().WithErrors(result);

         string location = GetValidReturnUrl(returnUrl);

         return EmptyRedirect(HttpStatusCode.SeeOther, location);
      }

      /// <summary>
      /// Removes the forms-authentication ticket from the browser.
      /// </summary>
      /// <param name="returnUrl">A URL to redirect to.</param>
      /// <returns>The action result.</returns>
      [HttpGet]
      public ActionResult SignOut(string returnUrl) {

         this.service.SignOut();

         string location = GetValidReturnUrl(returnUrl);

         return EmptyRedirect(HttpStatusCode.Found, location);
      }

      /// <summary>
      /// The change password page.
      /// </summary>
      /// <returns>The action result.</returns>
      [HttpGetHead]
      [Authorize]
      public ActionResult ChangePassword() {

         this.ViewData.Model = new ChangePasswordViewModel(new ChangePasswordInput());

         return View();
      }

      /// <summary>
      /// Attempts to change the password.
      /// </summary>
      /// <param name="input">The input model.</param>
      /// <returns>The action result.</returns>
      [HttpPost]
      [Authorize]
      public ActionResult ChangePassword(ChangePasswordInput input) {

         if (input == null)
            return ChangePassword();

         this.ViewData.Model = new ChangePasswordViewModel(input);

         if (!this.ModelState.IsValid)
            return View().WithStatus(HttpStatusCode.BadRequest);

         var result = this.service.ChangePassword(input);

         if (result.IsError)
            return View().WithErrors(result);

         return EmptyRedirect(HttpStatusCode.SeeOther, this.Url.Action("PasswordSaved"));
      }

      /// <summary>
      /// A page that informs the user that his new password was saved.
      /// </summary>
      /// <returns>The action result.</returns>
      [HttpGetHead]
      [Authorize]
      public ActionResult PasswordSaved() {

         this.ViewData.Model = new PasswordSavedViewModel();

         return View();
      }

      /// <summary>
      /// The reset password page.
      /// </summary>
      /// <returns>The action result.</returns>
      [HttpGetHead]
      public ActionResult ResetPassword() {

         this.ViewData.Model = new ResetPasswordViewModel(new ResetPasswordInput());

         return View();
      }

      /// <summary>
      /// Attempts to reset the password.
      /// </summary>
      /// <param name="input">The input model.</param>
      /// <returns>The action result.</returns>
      [HttpPost]
      [ValidateAntiForgeryToken]
      public ActionResult ResetPassword(ResetPasswordInput input) {

         if (input == null)
            return ResetPassword();

         this.ViewData.Model = new ResetPasswordViewModel(input);

         if (!this.ModelState.IsValid)
            return View().WithStatus(HttpStatusCode.BadRequest);

         var result = this.service.ResetPassword(input, this);

         if (result.IsError)
            return View().WithErrors(result);

         this.TempData["PostResetPassword"] = result;

         return EmptyRedirect(HttpStatusCode.SeeOther, this.Url.Action("PasswordResetVerificationSent"));
      }

      /// <summary>
      /// A page that informs the user that the reset password verification e-mail was sent.
      /// </summary>
      /// <returns>The action result.</returns>
      [HttpGetHead]
      public ActionResult PasswordResetVerificationSent() {

         OperationResult result = this.TempData["PostResetPassword"] as OperationResult;
         ResetPasswordResult resource;

         if (result == null
            || (resource = result.Value as ResetPasswordResult) == null)
            throw new HttpException((int)HttpStatusCode.NotFound, "");

         this.ViewData.Model = new PasswordResetVerificationSentViewModel(resource);

         return View();
      }

      /// <summary>
      /// The reset password callback page.
      /// </summary>
      /// <param name="id">The verification ticket.</param>
      /// <returns>The action result.</returns>
      [HttpGet]
      public ActionResult RP(string id) {

         var result = this.service.FinishResetPassword(id);

         if (result.IsError)
            throw new HttpException((int)result.StatusCode, result.Value.ToStringInvariant());

         this.ViewData.Model = new RPViewModel(result.ValueAsSuccess);

         return View();
      }

      /// <summary>
      /// Attempts to reset the password.
      /// </summary>
      /// <param name="id">The verification ticket.</param>
      /// <param name="input">The input model.</param>
      /// <returns>The action result.</returns>
      [HttpPost]
      [ValidateAntiForgeryToken]
      public ActionResult RP(string id, FinishResetPasswordInput input) {

         if (input == null)
            return RP(id);

         this.ViewData.Model = new RPViewModel(input);

         if (!this.ModelState.IsValid)
            return View().WithStatus(HttpStatusCode.BadRequest);

         var result = this.service.FinishResetPassword(id, input);

         if (result.IsError) {
            if (result.StatusCode == HttpStatusCode.BadRequest)
               return View().WithErrors(result);

            throw new HttpException((int)result.StatusCode, result.Value.ToStringInvariant());
         }

         return EmptyRedirect(HttpStatusCode.SeeOther, this.Url.Action("PasswordReset"));
      }

      /// <summary>
      /// A page that informs the user that his password has been reset.
      /// </summary>
      /// <returns>The action result.</returns>
      [HttpGetHead]
      public ActionResult PasswordReset() {

         this.ViewData.Model = new PasswordResetViewModel();

         return View();
      }

      /// <summary>
      /// The change email page.
      /// </summary>
      /// <returns>The action result.</returns>
      [HttpGetHead]
      [Authorize]
      public ActionResult ChangeEmail() {

         this.ViewData.Model = new ChangeEmailViewModel(this.service.ChangeEmail());

         return View();
      }

      /// <summary>
      /// Attempts to change the email.
      /// </summary>
      /// <param name="input">The input model.</param>
      /// <returns>The action result.</returns>
      [HttpPost]
      [Authorize]
      public ActionResult ChangeEmail(ChangeEmailInput input) {

         if (input == null)
            return ChangeEmail();

         this.ViewData.Model = new ChangeEmailViewModel(input);

         if (!this.ModelState.IsValid)
            return View().WithStatus(HttpStatusCode.BadRequest);

         var result = this.service.ChangeEmail(input, this);

         if (result.IsError)
            return View().WithErrors(result);

         if (result.StatusCode == HttpStatusCode.Accepted) {

            this.TempData["PostChangeEmail"] = result;

            return EmptyRedirect(HttpStatusCode.SeeOther, this.Url.Action("EmailChangeVerificationSent"));
         }
         
         return EmptyRedirect(HttpStatusCode.SeeOther, this.Url.Action("EmailSaved"));
      }

      /// <summary>
      /// A page that informs the user that his new email was saved.
      /// </summary>
      /// <returns>The action result.</returns>
      [HttpGetHead]
      [Authorize]
      public ActionResult EmailSaved() {

         this.ViewData.Model = new EmailSavedViewModel();

         return View();
      }

      /// <summary>
      /// A page that informs the user that the email change verification e-mail was sent.
      /// </summary>
      /// <returns>The action result.</returns>
      [HttpGetHead]
      [Authorize]
      public ActionResult EmailChangeVerificationSent() {

         OperationResult result = this.TempData["PostChangeEmail"] as OperationResult;
         ChangeEmailResult resource;

         if (result == null
            || (resource = result.Value as ChangeEmailResult) == null)
            throw new HttpException((int)HttpStatusCode.NotFound, "");

         this.ViewData.Model = new EmailChangeVerificationSentViewModel(resource);

         return View();
      }

      /// <summary>
      /// The email change verification callback.
      /// </summary>
      /// <param name="id">The verification email.</param>
      /// <returns>The action result.</returns>
      [HttpGet]
      public ActionResult VNE(string id) {

         var result = this.service.EmailChangeVerificationCallback(id);

         if (result.IsError)
            throw new HttpException((int)result.StatusCode, result.Value.ToStringInvariant());

         this.ViewData.Model = new EmailSavedViewModel();

         return View(Views.Account.EmailSaved);
      }

      ActionResult EmptyRedirect(HttpStatusCode statusCode, string location) {

         this.Response.StatusCode = (int)statusCode;
         this.Response.RedirectLocation = location;

         return new EmptyResult();
      }

      string GetValidReturnUrl(string returnUrl) {

         string location = (returnUrl.HasValue() && this.Url.IsLocalUrl(returnUrl)) ?
            returnUrl : ApplicationPath;

         return location;
      }
   }
}
