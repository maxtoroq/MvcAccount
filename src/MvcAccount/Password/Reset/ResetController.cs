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

namespace MvcAccount.Password.Reset {
   
   /// <summary>
   /// Exposes password reset functionality.
   /// </summary>
   public class ResetController : BaseController {

      AccountRepository repo;
      PasswordService passServ;

      PasswordResetter resetter;

      /// <summary>
      /// Initializes a new instance of the <see cref="ResetController"/> class.
      /// </summary>
      public ResetController() { }

      /// <summary>
      /// Initializes a new instance of the <see cref="ResetController"/> class, 
      /// with the provided <paramref name="repo"/> and <paramref name="passwordService"/>.
      /// </summary>
      /// <param name="repo">The account repository.</param>
      /// <param name="passwordService">The password service.</param>
      public ResetController(AccountRepository repo, PasswordService passwordService) 
         : this() {
         
         this.repo = repo;
         this.passServ = passwordService;
      }

      /// <summary>
      /// Initializes data that might not be available when the constructor is called.
      /// </summary>
      /// <param name="requestContext">The HTTP context and route data.</param>
      protected override void Initialize(RequestContext requestContext) {
         
         base.Initialize(requestContext);

         this.resetter = new PasswordResetter(this.Configuration, this, this.repo, this.passServ);
      }

      /// <summary>
      /// The reset password page.
      /// </summary>
      /// <returns>The action result.</returns>
      [HttpGetHead]
      [DefaultAction]
      public ActionResult Reset() {

         this.ViewData.Model = new ResetViewModel(new ResetInput());

         return View();
      }

      /// <summary>
      /// Attempts to reset the password.
      /// </summary>
      /// <param name="input">The input model.</param>
      /// <returns>The action result.</returns>
      [HttpPost]
      [ValidateAntiForgeryToken]
      public ActionResult Reset(ResetInput input) {

         this.ViewData.Model = new ResetViewModel(input);

         if (!this.ModelState.IsValid) {
            return View().WithStatus(HttpStatusCode.BadRequest);
         }

         var result = this.resetter.Reset(input);

         if (result.IsError) {
            return View().WithErrors(result);
         }

         this.TempData["PostReset"] = result;

         return HttpSeeOther(this.Url.Action(VerificationSent));
      }
      
      /// <summary>
      /// A page that informs the user that the reset password verification e-mail was sent.
      /// </summary>
      /// <returns>The action result.</returns>
      [HttpGetHead]
      public ActionResult VerificationSent() {

         OperationResult result = this.TempData["PostReset"] as OperationResult;
         ResetResult resource;

         if (result == null
            || (resource = result.Value as ResetResult) == null) {
            
            throw new HttpException((int)HttpStatusCode.NotFound, "");
         }

         this.ViewData.Model = new VerificationSentViewModel(resource);

         return View();
      }

      /// <summary>
      /// The reset password callback page.
      /// </summary>
      /// <param name="id">The verification ticket.</param>
      /// <returns>The action result.</returns>
      [HttpGet]
      public ActionResult Finish(string id) {

         var result = this.resetter.Finish(id);

         if (result.IsError) {
            throw new HttpException((int)result.StatusCode, result.Value.ToStringInvariant());
         }

         this.ViewData.Model = new FinishViewModel(result.ValueAsSuccess);

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
      public ActionResult Finish(string id, FinishInput input) {

         this.ViewData.Model = new FinishViewModel(input);

         if (!this.ModelState.IsValid) {
            return View().WithStatus(HttpStatusCode.BadRequest);
         }

         var result = this.resetter.Finish(id, input);

         if (result.IsError) {

            if (result.StatusCode == HttpStatusCode.BadRequest) {
               return View().WithErrors(result);
            }

            throw new HttpException((int)result.StatusCode, result.Value.ToStringInvariant());
         }

         return HttpSeeOther(this.Url.Action(Done));
      }

      /// <summary>
      /// A page that informs the user that his password has been reset.
      /// </summary>
      /// <returns>The action result.</returns>
      [HttpGetHead]
      public ActionResult Done() {

         this.ViewData.Model = new DoneViewModel();

         return View();
      }
   }
}