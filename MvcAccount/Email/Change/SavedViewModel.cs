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
using MvcAccount.Common;

namespace MvcAccount.Email.Change {
   
   /// <summary>
   /// Holds data for the EmailSaved view.
   /// </summary>
   public class SavedViewModel : BaseViewModel {

      /// <summary>
      /// A message for the user.
      /// </summary>
      public string Message { get; set; }

      /// <summary>
      /// The link for the next URL the user should navigate to.
      /// </summary>
      public LinkModel NextLink { get; set; }

      /// <summary>
      /// Initializes a new instance of the <see cref="SavedViewModel"/> class.
      /// </summary>
      public SavedViewModel() {
         
         this.Title = AccountResources.Views_EmailSaved_Title;
         this.Message = AccountResources.Views_EmailSaved_Message;
         this.NextLink = new LinkModel(this.Url.Action("", "~Account"), AccountResources.Views_GoTo.FormatInvariant(AccountResources.Links_Index));
      }
   }
}
