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
using System.Security.Principal;
using System.Web.Mvc;
using System.Web.Routing;
using MicroApis.ErrorModel;
using MicroApis.OperationModel;
using MicroApis.OperationModel.Web.Mvc;
using MvcAccount.Common;
using MvcCodeRouting.Web.Mvc;

namespace MvcAccount.Password.Change {

   [Authorize]
   public class ChangeController : BaseController {

      AccountRepositoryWrapper repo;
      PasswordService passServ;

      public ChangeController() { }

      public ChangeController(AccountRepository repo, PasswordService passwordService) 
         : this() {
         
         this.repo = new AccountRepositoryWrapper(repo);
         this.passServ = passwordService;
      }

      protected override void Initialize(RequestContext requestContext) {
         
         base.Initialize(requestContext);

         this.repo = this.Configuration.RequireDependency(this.repo);
         this.passServ = this.Configuration.RequireDependency(this.passServ);
      }

      /// <summary>
      /// The change password page.
      /// </summary>
      /// <returns>The action result.</returns>
      [HttpGetHead]
      [DefaultAction]
      public ActionResult Change() {

         this.ViewData.Model = new ChangeViewModel(new ChangeInput());

         return View();
      }

      /// <summary>
      /// Attempts to change the password.
      /// </summary>
      /// <param name="input">The input model.</param>
      /// <returns>The action result.</returns>
      [HttpPost]
      public ActionResult Change(ChangeInput input) {

         if (input == null)
            return Change();

         this.ViewData.Model = new ChangeViewModel(input);

         if (!this.ModelState.IsValid)
            return View().WithStatus(HttpStatusCode.BadRequest);

         var result = ChangeImpl(input);

         if (result.IsError)
            return View().WithErrors(result);

         return EmptyRedirect(HttpStatusCode.SeeOther, this.Url.Action(Saved));
      }

      /// <summary>
      /// A page that informs the user that his new password was saved.
      /// </summary>
      /// <returns>The action result.</returns>
      [HttpGetHead]
      public ActionResult Saved() {

         this.ViewData.Model = new SavedViewModel();

         return View();
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

         if (errors.Not(user != null, AccountResources.Validation_UserNotExist.FormatInvariant(identity.Name))
            || errors.Not(this.passServ.PasswordEquals(input.CurrentPassword, user.Password), AccountResources.Validation_CurrentPasswordIncorrect, () => input.CurrentPassword)
            || !TrySetPassword(user, () => input.NewPassword, this.passServ, errors))
            return errors;

         this.repo.UpdateUser(user);

         return HttpStatusCode.OK;
      }
   }
}