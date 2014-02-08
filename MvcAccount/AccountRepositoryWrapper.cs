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
using System.Text;

namespace MvcAccount {
   
   class AccountRepositoryWrapper {

      readonly AccountRepository repo;

      public AccountRepositoryWrapper(AccountRepository repo) {
         this.repo = repo;
      }

      public UserWrapper FindUserById(object id) {

         object user = this.repo.FindUserById(id);

         if (user == null) {
            return null;
         }

         return new UserWrapper(user);
      }

      public UserWrapper FindUserByName(string username) {

         var user = this.repo.FindUserByName(username);

         if (user == null) {
            return null;
         }

         return new UserWrapper(user);
      }

      public UserWrapper FindUserByEmail(string email) {

         var user = this.repo.FindUserByEmail(email);

         if (user == null) {
            return null;
         }

         return new UserWrapper(user);
      }

      public void UpdateUser(UserWrapper user) {
         this.repo.UpdateUser(user.WrappedUser);
      }
   }

   class UserWrapper {

      public readonly dynamic WrappedUser;

      public object Id {
         get { return WrappedUser.Id; }
         set { WrappedUser.Id = value; }
      }

      public string Username {
         get { return (string)WrappedUser.Username; }
         set { WrappedUser.Username = value; }
      }

      public string Password {
         get { return (string)WrappedUser.Password; }
         set { WrappedUser.Password = value; }
      }

      public string Email {
         get { return (string)WrappedUser.Email; }
         set { WrappedUser.Email = value; }
      }

      public DateTime? LastSignIn {
         get { return (DateTime?)WrappedUser.LastSignIn; }
         set { WrappedUser.LastSignIn = value; }
      }

      public bool EmailVerified {
         get { return (bool)WrappedUser.EmailVerified; }
         set { WrappedUser.EmailVerified = value; }
      }

      public bool Disabled {
         get { return (bool)WrappedUser.Disabled; }
         set { WrappedUser.Disabled = value; }
      }

      public int FailedSignInAttempts {
         get { return (int)WrappedUser.FailedSignInAttempts; }
         set { WrappedUser.FailedSignInAttempts = value; }
      }

      public DateTime? FailedSignInAttemptWindowStart {
         get { return (DateTime?)WrappedUser.FailedSignInAttemptWindowStart; }
         set { WrappedUser.FailedSignInAttemptWindowStart = value; }
      }

      public DateTime? EmailVerificationTicketExpiration {
         get { return (DateTime?)WrappedUser.EmailVerificationTicketExpiration; }
         set { WrappedUser.EmailVerificationTicketExpiration = value; }
      }

      public DateTime? PasswordResetTicketExpiration {
         get { return (DateTime?)WrappedUser.PasswordResetTicketExpiration; }
         set { WrappedUser.PasswordResetTicketExpiration = value; }
      }

      public DateTime? EmailChangeTicketExpiration {
         get { return (DateTime?)WrappedUser.EmailChangeTicketExpiration; }
         set { WrappedUser.EmailChangeTicketExpiration = value; }
      }

      public UserWrapper(object user) {
         this.WrappedUser = user;
      }
   }
}
