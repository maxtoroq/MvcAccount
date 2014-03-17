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
   /// Represents a class responsible for querying and persisting account information.
   /// </summary>
   public abstract class AccountRepository {

      /// <summary>
      /// Gets the user that matches the provided unique identifier.
      /// Note to Implementers: <paramref name="id"/> can be provided as a <see cref="String"/>,
      /// make sure to convert the value if needed. e.g. <c>int intId = Convert.ToInt32(id);</c>
      /// </summary>
      /// <param name="id">The user unique identifier.</param>
      /// <returns>The user object whose unique identifier matches <paramref name="id"/>, or null if not found.</returns>
      public abstract object FindUserById(object id);

      /// <summary>
      /// Gets the user that matches the provided <paramref name="username"/>.
      /// </summary>
      /// <param name="username">The username.</param>
      /// <returns>The user object whose username matches <paramref name="username"/>, or null if not found.</returns>
      public abstract object FindUserByName(string username);

      /// <summary>
      /// Gets the user whose email matches the provided <paramref name="email"/>.
      /// </summary>
      /// <param name="email">The user's email.</param>
      /// <returns>The user object whose email matches the provided <paramref name="email"/>, or null if not found.</returns>
      public abstract object FindUserByEmail(string email);

      /// <summary>
      /// Persists the changes of <paramref name="user"/>.
      /// </summary>
      /// <param name="user">The user whose changes are to be persisted.</param>
      public abstract void UpdateUser(object user);
   }
}
