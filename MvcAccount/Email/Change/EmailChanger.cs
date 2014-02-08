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
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Principal;
using System.Web;

namespace MvcAccount.Email.Change {
   
   class EmailChanger {

      readonly AccountConfiguration config;
      readonly IAccountContext context;
      readonly AccountRepositoryWrapper repo;
      readonly PasswordService passServ;
      readonly FormsAuthenticationService formsAuthService;

      public EmailChanger(AccountConfiguration config, IAccountContext context)
         : this(config, context, null, null, null) { }

      public EmailChanger(AccountConfiguration config, IAccountContext context, AccountRepository repo, PasswordService passwordService, FormsAuthenticationService formsAuthService) {
         
         if (config == null) throw new ArgumentNullException("config");
         if (context == null) throw new ArgumentNullException("context");

         this.config = config;
         this.context = context;
         this.repo = new AccountRepositoryWrapper(config.RequireDependency(repo));
         this.passServ = config.RequireDependency(passwordService);
         this.formsAuthService = config.RequireDependency(formsAuthService);
      }

      public ChangeInput Change() {

         UserWrapper user = this.repo.FindUserByName(this.context.CurrentUserName);

         var input = new ChangeInput {
            NewEmail = user.Email
         };

         return input;
      }

      public OperationResult Change(ChangeInput input) {

         if (input == null) throw new ArgumentNullException("input");

         var errors = new ErrorBuilder();

         if (errors.NotValid(input)) {
            return errors;
         }

         UserWrapper user = this.repo.FindUserByName(this.context.CurrentUserName);

         string currentEmail = user.Email;
         string newEmail = input.NewEmail;

         if (errors.Not(currentEmail.HasValue(), AccountResources.Validation_MissingEmail)) {
            return errors;
         }

         if (errors.Not(this.passServ.PasswordEquals(input.CurrentPassword, user.Password), AccountResources.Validation_CurrentPasswordIncorrect, () => input.CurrentPassword)
            | errors.Not(!AccountHelpers.EmailEquals(currentEmail, newEmail), AccountResources.Validation_NewEmailSameAsCurrent, () => input.NewEmail)) {
            return errors;
         }

         if (errors.Not(this.repo.FindUserByEmail(newEmail) == null, AccountResources.Validation_EmailAlreadyExists, () => input.NewEmail)) {
            return errors;
         }

         if (!this.config.EnableEmailVerification) {

            user.Email = newEmail;

            this.repo.UpdateUser(user);

            return HttpStatusCode.OK;
         }

         user.EmailChangeTicketExpiration = this.config.GetNow()
            .Add(this.config.EmailChangeTicketExpiration);

         this.repo.UpdateUser(user);

         var notifyModel = new NotificationMessageViewModel {
            SiteName = this.context.SiteName,
            NewEmail = newEmail,
            OldEmail = currentEmail,
            HelpResource = this.config.HelpResource
         };

         if (!AccountHelpers.EmailEquals(currentEmail, user.Username)) {
            notifyModel.Username = user.Username;
         }

         var notifyMessage = new MailMessage {
            To = { user.Email },
            Subject = AccountResources.Model_EmailChangeNotificationMessageSubject,
            Body = this.context.RenderEmailView(Views.Email.Change._NotificationMessage, notifyModel)
         };

         string verificationTicket = new VerificationData(user.Id, newEmail).GetVerificationTicket();
         string verificationUrl = this.context.AbsoluteUrl(this.context.Url.Action("Verify", new { id = verificationTicket }));

         var verifyModel = new VerificationMessageViewModel {
            SiteName = notifyModel.SiteName,
            Url = verificationUrl
         };

         var verifyMessage = new MailMessage {
            To = { newEmail },
            Subject = AccountResources.Model_EmailChangeVerificationMessageSubject,
            Body = this.context.RenderEmailView(Views.Email.Change._VerificationMessage, verifyModel)
         };

         this.context.SendEmail(notifyMessage);
         this.context.SendEmail(verifyMessage);

         return new OperationResult(HttpStatusCode.Accepted, new ChangeResult(newEmail));
      }

      public OperationResult Verify(string cipher) {

         var verifData = VerificationData.Parse(cipher);

         if (verifData == null) {
            return HttpStatusCode.NotFound;
         }

         UserWrapper user = this.repo.FindUserById(verifData.UserId);

         if (user == null
            || user.EmailChangeTicketExpiration == null
            || user.EmailChangeTicketExpiration.Value < this.config.GetNow()) {
            
            return HttpStatusCode.Gone;
         }

         string newEmail = verifData.UserData;

         user.Email = newEmail;
         user.EmailVerified = true;
         user.EmailChangeTicketExpiration = null;

         this.repo.UpdateUser(user);

         IIdentity identity = this.context.User.Identity;

         if (identity.IsAuthenticated
            && !AccountHelpers.UserEquals(user, identity)) {

            this.formsAuthService.SignOut();
         }

         return HttpStatusCode.OK;
      }
   }
}