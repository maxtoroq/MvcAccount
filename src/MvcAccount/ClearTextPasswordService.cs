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
   /// A <see cref="PasswordService"/> that does not encrypt passwords.
   /// </summary>
   public class ClearTextPasswordService : PasswordService {

      /// <summary>
      /// Returns <paramref name="clearTextPassword"/> unchanged.
      /// </summary>
      /// <param name="clearTextPassword">The password in clear text.</param>
      /// <returns><paramref name="clearTextPassword"/> unchanged.</returns>
      public override string ProcessPasswordForStorage(string clearTextPassword) {
         return clearTextPassword;
      }

      /// <summary>
      /// Compares a password provided by a user to one that is stored.
      /// </summary>
      /// <param name="clearTextPassword">The password in clear text provided by a user.</param>
      /// <param name="storedPassword">The stored password.</param>
      /// <returns>true if the passwords are equal; otherwise false.</returns>
      public override bool PasswordEquals(string clearTextPassword, string storedPassword) {
         return String.Equals(clearTextPassword, storedPassword, StringComparison.Ordinal);
      }
   }
}
