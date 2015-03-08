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
using System.Web.Routing;
using MvcAccount.Shared;
using MvcCodeRouting.Web.Mvc;
using ResultEnvelope.Web.Mvc;

namespace MvcAccount.Authentication {
   
   /// <summary>
   /// Exposes authentication functionality.
   /// </summary>
   public class AuthenticationController : BaseController {

      AccountRepository repo;
      PasswordService passServ;
      FormsAuthenticationService formsAuthService;

      Authenticator auth;

      /// <summary>
      /// Initializes a new instance of the <see cref="AuthenticationController"/> class.
      /// </summary>
      public AuthenticationController() { }

      /// <summary>
      /// Initializes a new instance of the <see cref="AuthenticationController"/> class, 
      /// with the provided <paramref name="repo"/> and <paramref name="passwordService"/>.
      /// </summary>
      /// <param name="repo">The account repository.</param>
      /// <param name="passwordService">The password service.</param>
      public AuthenticationController(AccountRepository repo, PasswordService passwordService) 
         : this() {

         this.repo = repo;
         this.passServ = passwordService;
      }

      /// <summary>
      /// Initializes a new instance of the <see cref="AuthenticationController"/> class, 
      /// with the provided <paramref name="repo"/>, <paramref name="passwordService"/> and <paramref name="formsAuthService"/>.
      /// </summary>
      /// <param name="repo">The account repository.</param>
      /// <param name="passwordService">The password service.</param>
      /// <param name="formsAuthService">The forms authentication service.</param>
      public AuthenticationController(AccountRepository repo, PasswordService passwordService, FormsAuthenticationService formsAuthService) 
         : this(repo, passwordService) {
         
         this.formsAuthService = formsAuthService;
      }

      /// <summary>
      /// Initializes data that might not be available when the constructor is called.
      /// </summary>
      /// <param name="requestContext">The HTTP context and route data.</param>
      protected override void Initialize(RequestContext requestContext) {
         
         base.Initialize(requestContext);

         this.auth = new Authenticator(this.Configuration, this.repo, this.passServ, this.formsAuthService);
      }

      /// <summary>
      /// The sign in page.
      /// </summary>
      /// <returns>The action result.</returns>
      [CustomRoute("~/{action}")]
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
      [CustomRoute("~/{action}")]
      [HttpPost]
      [ValidateAntiForgeryToken]
      public ActionResult SignIn(SignInInput input, string returnUrl) {

         this.ViewData.Model = new SignInViewModel(input);

         if (!this.ModelState.IsValid) {
            return View().WithStatus(HttpStatusCode.BadRequest);
         }

         var result = this.auth.SignIn(input);

         if (result.IsError) {
            return View().WithErrors(result);
         }

         string location = GetValidReturnUrl(returnUrl);

         return Redirect(location);
      }
      
      /// <summary>
      /// Removes the forms-authentication ticket from the browser.
      /// </summary>
      /// <param name="returnUrl">A URL to redirect to.</param>
      /// <returns>The action result.</returns>
      [CustomRoute("~/{action}")]
      [HttpGet]
      public ActionResult SignOut(string returnUrl) {

         this.auth.SignOut();

         string location = GetValidReturnUrl(returnUrl);

         return Redirect(location);
      }
   }
}