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
using System.Web;

namespace MvcAccount.Authentication {
   
   class Authenticator {

      readonly AccountConfiguration config;
      readonly AccountRepositoryWrapper repo;
      readonly PasswordService passServ;
      readonly FormsAuthenticationService formsAuthService;

      public Authenticator(AccountConfiguration config) 
         : this(config, null, null, null) { }

      public Authenticator(AccountConfiguration config, AccountRepository repo, PasswordService passwordService, FormsAuthenticationService formsAuthService) {

         if (config == null) throw new ArgumentNullException("config");

         this.config = config;
         this.repo = new AccountRepositoryWrapper(config.RequireDependency(repo));
         this.passServ = config.RequireDependency(passwordService);
         this.formsAuthService = config.RequireDependency(formsAuthService);
      }

      public OperationResult SignIn(SignInInput input) {

         var result = ValidateUser(input);

         if (result.IsError) {
            return result;
         }

         this.formsAuthService.SetAuthCookie(result.ValueAsSuccess, input.RememberMe);

         return HttpStatusCode.OK;
      }

      internal bool ValidateUser(string username, string password) {
         return !ValidateUser(new SignInInput { Username = username, Password = password }).IsError;
      }

      OperationResult<string> ValidateUser(SignInInput input) {

         if (input == null) throw new ArgumentNullException("input");

         var errors = new ErrorBuilder();

         if (errors.NotValid(input)) {
            return errors;
         }

         string userPassNotMatchMessage = AccountResources.Validation_UserPassNotMatch.FormatInvariant(AccountResources.Model_Username);

         UserWrapper user = this.repo.FindUserByName(input.Username);

         if (errors.Not(user != null, userPassNotMatchMessage)) {
            return errors;
         }

         DateTime now = this.config.GetNow();

         if (!user.Password.HasValue()) {
            return new OperationResult<string>(HttpStatusCode.Forbidden, AccountResources.Validation_MissingPasswordCannotAuthenticate);
         }

         int maxInvalidAttempts = this.config.MaxInvalidSignInAttempts;

         bool passwordCorrect = this.passServ.PasswordEquals(input.Password, user.Password);
         int failedAttempts = user.FailedSignInAttempts;

         if (passwordCorrect) {

            if (user.Disabled) {
               return new OperationResult<string>(HttpStatusCode.Forbidden, AccountResources.Validation_UserDisabled);
            }

         } else {

            if (user.Disabled) {
               return new OperationResult<string>(HttpStatusCode.BadRequest, userPassNotMatchMessage);
            }

            if (failedAttempts <= maxInvalidAttempts) {

               failedAttempts++;

               user.FailedSignInAttempts = failedAttempts;
               user.FailedSignInAttemptWindowStart = now;

               if (failedAttempts > maxInvalidAttempts
                  && this.config.DisableOnMaxInvalidSignInAttempts
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

            DateTime lockEnd = user.FailedSignInAttemptWindowStart.GetValueOrDefault().Add(this.config.SignInAttemptWindow);

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

         if (!passwordCorrect) {
            return new OperationResult<string>(HttpStatusCode.BadRequest, userPassNotMatchMessage);
         }

         return user.Username;
      }

      public void SignOut() {
         this.formsAuthService.SignOut();
      }
   }
}