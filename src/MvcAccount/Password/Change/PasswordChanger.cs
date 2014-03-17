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

namespace MvcAccount.Password.Change {
   
   class PasswordChanger {

      readonly IAccountContext context;
      readonly AccountRepositoryWrapper repo;
      readonly PasswordService passServ;

      public PasswordChanger(AccountConfiguration config, IAccountContext context) 
         : this(config, context, null, null) { }

      public PasswordChanger(AccountConfiguration config, IAccountContext context, AccountRepository repo, PasswordService passServ) {

         if (config == null) throw new ArgumentNullException("config");
         if (context == null) throw new ArgumentNullException("context");

         this.context = context;
         this.repo = new AccountRepositoryWrapper(config.RequireDependency(repo));
         this.passServ = config.RequireDependency(passServ);
      }

      public OperationResult Change(ChangeInput input) {

         if (input == null) throw new ArgumentNullException("input");

         var errors = new ErrorBuilder();

         if (errors.NotValid(input)) {
            return errors;
         }

         string username = this.context.CurrentUserName;
         UserWrapper user = this.repo.FindUserByName(username);

         if (errors.Not(user != null, AccountResources.Validation_UserNotExist.FormatInvariant(username))
            || errors.Not(this.passServ.PasswordEquals(input.CurrentPassword, user.Password), AccountResources.Validation_CurrentPasswordIncorrect, () => input.CurrentPassword)
            || !this.passServ.TrySetPassword(user, () => input.NewPassword, errors)) {
            
            return errors;
         }

         this.repo.UpdateUser(user);

         return HttpStatusCode.OK;
      }
   }
}