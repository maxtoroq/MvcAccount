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
using System.Globalization;
using System.Linq;
using System.Web;

namespace MvcAccount.Web {
   
   public static partial class AccountResources {

      static string GetResource(string resourceKey) {

         CultureInfo culture = CultureInfo.CurrentUICulture;

         return GetUserResourceString(resourceKey, culture)
            ?? Resources.AccountResources.ResourceManager.GetString(resourceKey, culture);
      }

      static string GetUserResourceString(string resourceKey, CultureInfo culture) {

         string classKey = AccountConfiguration.Current().ResourceClassKey;

         if (!classKey.HasValue())
            return null;

         return HttpContext.GetGlobalResourceObject(classKey, resourceKey, culture) as string;
      }
   }
}