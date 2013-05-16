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
   
   /// <summary>
   /// Represents a class that performs operations on passwords, such as validation, encryption, comparison, etc.
   /// </summary>
   public abstract class PasswordService {

      /// <summary>
      /// Converts the <paramref name="clearTextPassword"/> to one that is suitable for storage.
      /// </summary>
      /// <param name="clearTextPassword">The password in clear text.</param>
      /// <returns>The password suitable for storage.</returns>
      public abstract string ProcessPasswordForStorage(string clearTextPassword);

      /// <summary>
      /// Compares a password provided by a user to one that is stored.
      /// </summary>
      /// <param name="clearTextPassword">The password in clear text provided by a user.</param>
      /// <param name="storedPassword">The stored password.</param>
      /// <returns>true if the passwords are equal; otherwise false.</returns>
      public abstract bool PasswordEquals(string clearTextPassword, string storedPassword);

      /// <summary>
      /// Validates a new password provided by a user. This method can be used to check if
      /// the new password has the length required by the encryption method. Returns null
      /// by default, which means all passwords are valid.
      /// </summary>
      /// <param name="clearTextPassword">The new password in clear text.</param>
      /// <returns>An error message if the password is not valid; otherwise null.</returns>
      /// <remarks>
      /// To customize password length requirements use <see cref="AccountConfiguration.MinPasswordLength"/>
      /// and <see cref="AccountConfiguration.MaxPasswordLength"/> instead.
      /// Override this method if you need to check for additional strength requirements, and make sure
      /// to call the base class method first.
      /// </remarks>
      public virtual string ValidatePassword(string clearTextPassword) {
         return null;
      }
   }
}
