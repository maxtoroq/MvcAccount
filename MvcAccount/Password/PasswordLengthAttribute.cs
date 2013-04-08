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
using System.Web.Mvc;

namespace MvcAccount.Password {

   /// <summary>
   /// Validates the length of new passwords. Settings are taken from <see cref="AccountConfiguration.MinPasswordLength"/>
   /// and <see cref="AccountConfiguration.MaxPasswordLength"/>.
   /// </summary>
   /// <seealso cref="AccountConfiguration.MinPasswordLength"/>
   /// <seealso cref="AccountConfiguration.MaxPasswordLength"/>
   public class PasswordLengthAttribute : StringLengthAttribute, IClientValidatable {

      /// <summary>
      /// Initializes a new instance of the <see cref="PasswordLengthAttribute"/> class.
      /// </summary>
      public PasswordLengthAttribute()
         : this(AccountConfiguration.Current()) { }

      private PasswordLengthAttribute(AccountConfiguration config) 
         : base(config.MaxPasswordLength) {

         this.MinimumLength = config.MinPasswordLength;
         this.ErrorMessageResourceType = typeof(AccountResources);
         this.ErrorMessageResourceName = AccountResources.Keys.Validation_StringLengthWithMin;
      }

      /// <summary>
      /// Returns client validation rules.
      /// </summary>
      /// <param name="metadata">The model metadata.</param>
      /// <param name="context">The controller context.</param>
      /// <returns>The client validation rules for this validator.</returns>
      public IEnumerable<ModelClientValidationRule> GetClientValidationRules(ModelMetadata metadata, ControllerContext context) {

         return new[] { 
             new ModelClientValidationStringLengthRule(FormatErrorMessage(metadata.GetDisplayName()), this.MinimumLength, this.MaximumLength) 
         };
      }
   }
}
