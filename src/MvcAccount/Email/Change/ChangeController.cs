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
using System.Web.Mvc;
using System.Web.Routing;
using MvcAccount.Shared;
using MvcCodeRouting.Web.Mvc;
using ResultEnvelope;
using ResultEnvelope.Web.Mvc;

namespace MvcAccount.Email.Change {
   
   /// <summary>
   /// Exposes e-mail change functionality.
   /// </summary>
   public class ChangeController : BaseController {

      AccountRepository repo;
      PasswordService passServ;
      FormsAuthenticationService formsAuthService;

      EmailChanger changer;

      /// <summary>
      /// Initializes a new instance of the <see cref="ChangeController"/> class.
      /// </summary>
      public ChangeController() { }

      /// <summary>
      /// Initializes a new instance of the <see cref="ChangeController"/> class,
      /// with the provided <paramref name="repo"/> and <paramref name="passwordService"/>.
      /// </summary>
      /// <param name="repo">The account repository.</param>
      /// <param name="passwordService">The password service.</param>
      public ChangeController(AccountRepository repo, PasswordService passwordService) 
         : this() { 
      
         this.repo = repo;
         this.passServ = passwordService;
      }

      /// <summary>
      /// Initializes a new instance of the <see cref="ChangeController"/> class, 
      /// with the provided <paramref name="repo"/>, <paramref name="passwordService"/> and <paramref name="formsAuthService"/>.
      /// </summary>
      /// <param name="repo">The account repository.</param>
      /// <param name="passwordService">The password service.</param>
      /// <param name="formsAuthService">The forms authentication service.</param>
      public ChangeController(AccountRepository repo, PasswordService passwordService, FormsAuthenticationService formsAuthService) 
         : this(repo, passwordService) {

         this.formsAuthService = formsAuthService;
      }

      /// <summary>
      /// Initializes data that might not be available when the constructor is called.
      /// </summary>
      /// <param name="requestContext">The HTTP context and route data.</param>
      protected override void Initialize(RequestContext requestContext) {
         
         base.Initialize(requestContext);

         this.changer = new EmailChanger(this.Configuration, this, this.repo, this.passServ, this.formsAuthService);
      }

      /// <summary>
      /// The change email page.
      /// </summary>
      /// <returns>The action result.</returns>
      [HttpGetHead]
      [Authorize]
      [DefaultAction]
      public ActionResult Change() {

         this.ViewData.Model = new ChangeViewModel(this.changer.Change());

         return View();
      }

      /// <summary>
      /// Attempts to change the email.
      /// </summary>
      /// <param name="input">The input model.</param>
      /// <param name="cancel">A value that indicates if the operation was cancelled by the user.</param>
      /// <returns>The action result.</returns>
      [HttpPost]
      [Authorize]
      public ActionResult Change(ChangeInput input, FormButton cancel) {

         if (cancel) {
            return Redirect(this.Url.Action("", "~Account"));
         }

         this.ViewData.Model = new ChangeViewModel(input);

         if (!this.ModelState.IsValid) {
            return View().WithStatus(HttpStatusCode.BadRequest);
         }

         var result = this.changer.Change(input);

         if (result.IsError) {
            return View().WithErrors(result);
         }

         if (result.StatusCode == HttpStatusCode.Accepted) {

            this.TempData["PostChange"] = result;

            return Redirect(this.Url.Action(VerificationSent));
         }

         return Redirect(this.Url.Action(Saved));
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

         Result result = this.TempData["PostChange"] as Result;
         ChangeResult resource;

         if (result == null
            || (resource = result.Value as ChangeResult) == null) {
            
            throw new HttpException((int)HttpStatusCode.NotFound, "");
         }

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

         var result = this.changer.Verify(id);

         if (result.IsError) {
            throw new HttpException((int)result.StatusCode, result.Value.ToStringInvariant());
         }

         this.ViewData.Model = new SavedViewModel();

         return View(Views.Email.Change.Saved);
      }
   }
}