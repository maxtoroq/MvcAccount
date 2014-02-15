// Copyright 2014 Max Toro Q.
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
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;

namespace MvcAccount {

   sealed class EmailAddressAttribute : DataTypeAttribute, IClientValidatable {

      static readonly Regex EmailRegex = new Regex(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");

      public EmailAddressAttribute() 
         : base(DataType.EmailAddress) {

         this.ErrorMessageResourceName = AccountResources.Keys.Validation_EmailPattern;
         this.ErrorMessageResourceType = typeof(AccountResources);
      }

      public override bool IsValid(object value) {

         string input = Convert.ToString(value, CultureInfo.CurrentCulture);

         if (String.IsNullOrEmpty(input)) {
            return true;
         }

         Match match = EmailRegex.Match(input);

         if (match.Success 
            && match.Index == 0) {

            return match.Length == input.Length;
         }
         
         return false;
      }

      public IEnumerable<ModelClientValidationRule> GetClientValidationRules(ModelMetadata metadata, ControllerContext context) {

         return new ModelClientValidationRule[] { 
            
            new ModelClientValidationRule {
               ValidationType = "email",
               ErrorMessage = FormatErrorMessage(metadata.GetDisplayName())
            }
         };
      }
   }
}