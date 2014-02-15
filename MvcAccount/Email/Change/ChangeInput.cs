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

namespace MvcAccount.Email.Change {
   
   /// <summary>
   /// Holds data required by the <see cref="ChangeController.Change(ChangeInput, FormButton)"/> action.
   /// </summary>
   public class ChangeInput {

      /// <summary>
      /// The new email.
      /// </summary>
      [Required(ErrorMessageResourceName = AccountResources.Keys.Validation_Required, ErrorMessageResourceType = typeof(AccountResources))]
      [EmailAddress]
      [StringLength(254, ErrorMessageResourceName = AccountResources.Keys.Validation_StringLength, ErrorMessageResourceType = typeof(AccountResources))]
      [Display(Order = 1, Name = AccountResources.Keys.Model_NewEmail, ResourceType = typeof(AccountResources))]
      public string NewEmail { get; set; }

      /// <summary>
      /// The user's current password.
      /// </summary>
      [Required(ErrorMessageResourceName = AccountResources.Keys.Validation_Required, ErrorMessageResourceType = typeof(AccountResources))]
      [DataType(DataType.Password)]
      [Display(Order = 2, Name = AccountResources.Keys.Model_CurrentPassword, ResourceType = typeof(AccountResources))]
      public string CurrentPassword { get; set; }
   }
}
