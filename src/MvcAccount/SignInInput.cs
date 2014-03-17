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
using System.ComponentModel.DataAnnotations;

namespace MvcAccount {
   
   /// <summary>
   /// Holds data required by the <see cref="AccountController.SignIn(SignInInput, string)"/> action.
   /// </summary>
   public class SignInInput {

      /// <summary>
      /// The username.
      /// </summary>
      [Required(ErrorMessageResourceName = AccountResources.Keys.Validation_Required, ErrorMessageResourceType = typeof(AccountResources))]
      [Display(Order = 1, Name = AccountResources.Keys.Model_Username, ResourceType = typeof(AccountResources))]
      public string Username { get; set; }

      /// <summary>
      /// The password.
      /// </summary>
      [Required(ErrorMessageResourceName = AccountResources.Keys.Validation_Required, ErrorMessageResourceType = typeof(AccountResources))]
      [DataType(DataType.Password)]
      [Display(Order = 2, Name = AccountResources.Keys.Model_Password, ResourceType = typeof(AccountResources))]
      public string Password { get; set; }

      /// <summary>
      /// True to create a persistent authentication cookie; otherwise false.
      /// </summary>
      [Display(Order = 3, Name = AccountResources.Keys.Model_RememberMe, ResourceType = typeof(AccountResources))]
      public bool RememberMe { get; set; }
   }
}
