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
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using MicroApis.ErrorModel;
using MicroApis.OperationModel;
using MicroApis.OperationModel.Web.Mvc;
using MvcCodeRouting.Web.Mvc;

namespace MvcAccount.Web.Password.Reset {
   
   public class ResetController : BaseController {

      AccountRepositoryWrapper repo;
      PasswordService passServ;

      public ResetController() { }

      public ResetController(AccountRepository repo, PasswordService passwordService) 
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

         if (!this.ModelState.IsValid)
            return View().WithStatus(HttpStatusCode.BadRequest);

         var result = ResetImpl(input);

         if (result.IsError)
            return View().WithErrors(result);

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
            || (resource = result.Value as ResetResult) == null)
            throw new HttpException((int)HttpStatusCode.NotFound, "");

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

         var result = FinishImpl(id);

         if (result.IsError)
            throw new HttpException((int)result.StatusCode, result.Value.ToStringInvariant());

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

         if (!this.ModelState.IsValid)
            return View().WithStatus(HttpStatusCode.BadRequest);

         var result = FinishImpl(id, input);

         if (result.IsError) {
            if (result.StatusCode == HttpStatusCode.BadRequest)
               return View().WithErrors(result);

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

      OperationResult<ResetResult> ResetImpl(ResetInput input) {

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

            user.PasswordResetTicketExpiration = this.Configuration.GetNow()
               .Add(this.Configuration.PasswordResetTicketExpiration);

            this.repo.UpdateUser(user);

            string verificationTicket = new VerificationData(user.Id, null).GetVerificationTicket();
            string verificationUrl = AbsoluteUrl(this.Url.Action(Finish, verificationTicket));

            var mailModel = new VerificationMessageViewModel {
               SiteName = GetSiteName(),
               Url = verificationUrl
            };

            if (!EmailEquals(user.Email, user.Username))
               mailModel.Username = user.Username;

            destinationEmail = user.Email;

            message = new MailMessage {
               To = { destinationEmail },
               Subject = AccountResources.Model_PasswordResetVerificationMessageSubject,
               Body = RenderEmailView(Views.Password.Reset._VerificationMessage, mailModel)
            };

         } else {

            destinationEmail = input.Email;

            var mailModel = new ErrorMessageViewModel {
               SiteName = GetSiteName(),
               ErrorReason = (user == null) ?
                  ErrorReason.AccountNotFound
                  : ErrorReason.AccountDisabled
            };

            message = new MailMessage {
               To = { destinationEmail },
               Subject = AccountResources.Model_PasswordResetVerificationMessageSubject,
               Body = RenderEmailView(Views.Password.Reset._ErrorMessage, mailModel)
            };
         }

         SendEmail(message);

         return new OperationResult<ResetResult>(HttpStatusCode.Accepted, new ResetResult(destinationEmail));
      }

      OperationResult<FinishInput> FinishImpl(string cipher) {

         var result = CanFinish(cipher);

         if (result.IsError)
            return new OperationResult<FinishInput>(result.StatusCode, result.Value);

         return new FinishInput();
      }

      OperationResult FinishImpl(string cipher, FinishInput input) {

         if (input == null) throw new ArgumentNullException("input");

         var canFinishResult = CanFinish(cipher);

         if (canFinishResult.IsError)
            return canFinishResult;

         UserWrapper user = canFinishResult.ValueAsSuccess;

         var errors = new ErrorBuilder();

         if (errors.NotValid(input)
            || !TrySetPassword(user, () => input.NewPassword, this.passServ, errors))
            return errors;

         user.PasswordResetTicketExpiration = null;

         this.repo.UpdateUser(user);

         return HttpStatusCode.OK;
      }

      OperationResult<UserWrapper> CanFinish(string cipher) {

         var verifData = VerificationData.Parse(cipher);

         if (verifData == null)
            return HttpStatusCode.NotFound;

         UserWrapper user = this.repo.FindUserById(verifData.UserId);

         if (user == null
            || user.PasswordResetTicketExpiration == null
            || user.PasswordResetTicketExpiration.Value < this.Configuration.GetNow())
            return HttpStatusCode.Gone;

         return user;
      }
   }
}