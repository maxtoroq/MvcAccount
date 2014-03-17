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

namespace MvcAccount.ViewModels {
   
   /// <summary>
   /// Holds data for the RP view.
   /// </summary>
   public class RPViewModel : FormViewModel<FinishResetPasswordInput> {

      /// <summary>
      /// A message for the user.
      /// </summary>
      public string Message { get; set; }

      /// <summary>
      /// Initializes a new instance of the <see cref="RPViewModel"/> class
      /// using the provided input model.
      /// </summary>
      /// <param name="inputModel"></param>
      public RPViewModel(FinishResetPasswordInput inputModel) 
         : base(inputModel) {

         this.Title = AccountResources.Views_RP_Title;
         this.Message = AccountResources.Views_RP_Message;
      }
   }
}
