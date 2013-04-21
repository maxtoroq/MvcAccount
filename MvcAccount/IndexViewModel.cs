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
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using MvcAccount.Common;

namespace MvcAccount {
   
   /// <summary>
   /// Holds data for the Index view.
   /// </summary>
   public class IndexViewModel : BaseViewModel {

      /// <summary>
      /// A collection of links.
      /// </summary>
      public Collection<LinkModel> Links { get; private set; }

      /// <summary>
      /// Initializes a new instance of the <see cref="IndexViewModel"/> class.
      /// </summary>
      public IndexViewModel() {

         this.Title = AccountResources.Views_Account_Index_Title;
         this.Links = new Collection<LinkModel> { 
            new LinkModel(this.Url.Action("", "Password.Change"), AccountResources.Links_ChangePassword),
            new LinkModel(this.Url.Action("", "Email.Change"), AccountResources.Links_ChangeEmail),
            new LinkModel(this.Url.Action("SignOut", "Auth"), AccountResources.Links_SignOut)
         };
      }
   }
}
