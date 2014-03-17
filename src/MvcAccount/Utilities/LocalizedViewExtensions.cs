// Copyright 2013 Max Toro Q.
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
using System.Web.Mvc;

namespace MvcAccount {
   
   static class LocalizedViewExtensions {

      public static ViewEngineResult FindLocalizedPartialView(this ViewEngineCollection viewEngines, ControllerContext controllerContext, string partialViewName) {
         return FindLocalizedPartialView(viewEngines, controllerContext, partialViewName, CultureInfo.CurrentUICulture);
      }

      public static ViewEngineResult FindLocalizedPartialView(this ViewEngineCollection viewEngines, ControllerContext controllerContext, string partialViewName, CultureInfo viewCulture) {

         CultureInfo invariantCulture = CultureInfo.InvariantCulture;
         CultureInfo currentCulture = viewCulture;
         ViewEngineResult viewResult;

         do {
            viewResult = viewEngines.FindPartialView(controllerContext, String.Concat(partialViewName, ".", currentCulture.Name));

            if (viewResult.View == null)
               currentCulture = currentCulture.Parent;

         } while (viewResult.View == null && currentCulture != invariantCulture);

         if (viewResult.View == null)
            viewResult = viewEngines.FindPartialView(controllerContext, partialViewName);

         return viewResult;
      }
   }
}