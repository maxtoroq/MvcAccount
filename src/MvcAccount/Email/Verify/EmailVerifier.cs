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
using ResultEnvelope;

namespace MvcAccount.Email.Verify {
   
   class EmailVerifier {

      readonly AccountConfiguration config;
      readonly AccountRepositoryWrapper repo;

      public EmailVerifier(AccountConfiguration config) 
         : this(config, null) { }

      public EmailVerifier(AccountConfiguration config, AccountRepository repo) {

         if (config == null) throw new ArgumentNullException("config");

         this.config = config;
         this.repo = new AccountRepositoryWrapper(config.RequireDependency(repo));
      }

      public Result Verify(string cipher) {

         var verifData = VerificationData.Parse(cipher);

         if (verifData == null) {
            return HttpStatusCode.NotFound;
         }

         UserWrapper user = this.repo.FindUserById(verifData.UserId);

         if (user == null
            || user.EmailVerified
            || user.EmailVerificationTicketExpiration == null
            || user.EmailVerificationTicketExpiration.Value < this.config.GetNow()) {
            
            return HttpStatusCode.Gone;
         }

         user.EmailVerified = true;
         user.EmailVerificationTicketExpiration = null;

         if (this.config.EmailVerificationEnablesUser) {
            user.Disabled = false;
         }

         this.repo.UpdateUser(user);

         return HttpStatusCode.OK;
      }
   }
}