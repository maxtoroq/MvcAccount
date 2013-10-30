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
using System.Diagnostics;
using System.Web.Mvc;

namespace MvcAccount.Shared {
   
   [ModelBinder(typeof(FormButtonBinder))]
   [DebuggerDisplay("{Successful}")]
   public struct FormButton {

      public readonly bool Successful;

      internal FormButton(bool successful) {
         this.Successful = successful;
      }

      public static implicit operator Boolean(FormButton value) {
         return value.Successful;
      }
   }

   class FormButtonBinder : IModelBinder {

      public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext) {
         return new FormButton(controllerContext.HttpContext.Request.Form[bindingContext.ModelName] != null);
      }
   }
}