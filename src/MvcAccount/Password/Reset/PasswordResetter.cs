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
using System.Web;
using ResultEnvelope;

namespace MvcAccount.Password.Reset {
   
   class PasswordResetter {

      readonly AccountConfiguration config;
      readonly IAccountContext context;
      readonly AccountRepositoryWrapper repo;
      readonly PasswordService passServ;

      public PasswordResetter(AccountConfiguration config, IAccountContext context)
         : this(config, context, null, null) { }

      public PasswordResetter(AccountConfiguration config, IAccountContext context, AccountRepository repo, PasswordService passwordService) {
         
         if (config == null) throw new ArgumentNullException("config");
         if (context == null) throw new ArgumentNullException("context");

         this.config = config;
         this.context = context;
         this.repo = new AccountRepositoryWrapper(config.RequireDependency(repo));
         this.passServ = config.RequireDependency(passwordService);
      }

      public Result<ResetResult> Reset(ResetInput input) {

         if (input == null) throw new ArgumentNullException("input");

         var errors = new ErrorBuilder();

         if (errors.NotValid(input)) {
            return errors;
         }

         UserWrapper user = this.repo.FindUserByEmail(input.Email);

         MailMessage message;
         string destinationEmail;

         bool canResetPassword = user != null
            && !user.Disabled;

         if (canResetPassword) {

            user.PasswordResetTicketExpiration = this.config.GetNow()
               .Add(this.config.PasswordResetTicketExpiration);

            this.repo.UpdateUser(user);

            string verificationTicket = new VerificationData(user.Id, null).GetVerificationTicket();
            string verificationUrl = this.context.AbsoluteUrl(this.context.Url.Action("Finish", new { id = verificationTicket }));

            var mailModel = new VerificationMessageViewModel {
               SiteName = this.context.SiteName,
               Url = verificationUrl
            };

            if (!AccountHelpers.EmailEquals(user.Email, user.Username)) {
               mailModel.Username = user.Username;
            }

            destinationEmail = user.Email;

            message = new MailMessage {
               To = { destinationEmail },
               Subject = AccountResources.Model_PasswordResetVerificationMessageSubject,
               Body = this.context.RenderEmailView(Views.Password.Reset._VerificationMessage, mailModel)
            };

         } else {

            destinationEmail = input.Email;

            var mailModel = new ErrorMessageViewModel {
               SiteName = this.context.SiteName,
               ErrorReason = (user == null) ?
                  ErrorReason.AccountNotFound
                  : ErrorReason.AccountDisabled
            };

            message = new MailMessage {
               To = { destinationEmail },
               Subject = AccountResources.Model_PasswordResetVerificationMessageSubject,
               Body = this.context.RenderEmailView(Views.Password.Reset._ErrorMessage, mailModel)
            };
         }

         this.context.SendEmail(message);

         return new Result<ResetResult>(HttpStatusCode.Accepted, new ResetResult(destinationEmail));
      }

      public Result<FinishInput> Finish(string cipher) {

         var result = CanFinish(cipher);

         if (result.IsError) {
            return new Result<FinishInput>(result.StatusCode, result.Value);
         }

         return new FinishInput();
      }

      public Result Finish(string cipher, FinishInput input) {

         if (input == null) throw new ArgumentNullException("input");

         var canFinishResult = CanFinish(cipher);

         if (canFinishResult.IsError) {
            return canFinishResult;
         }

         UserWrapper user = canFinishResult.ValueAsSuccess;

         var errors = new ErrorBuilder();

         if (errors.NotValid(input)
            || !this.passServ.TrySetPassword(user, () => input.NewPassword, errors)) {
            
            return errors;
         }

         user.PasswordResetTicketExpiration = null;

         this.repo.UpdateUser(user);

         return HttpStatusCode.OK;
      }

      public Result<UserWrapper> CanFinish(string cipher) {

         var verifData = VerificationData.Parse(cipher);

         if (verifData == null) {
            return HttpStatusCode.NotFound;
         }

         UserWrapper user = this.repo.FindUserById(verifData.UserId);

         if (user == null
            || user.PasswordResetTicketExpiration == null
            || user.PasswordResetTicketExpiration.Value < this.config.GetNow()) {
            
            return HttpStatusCode.Gone;
         }

         return user;
      }
   }
}