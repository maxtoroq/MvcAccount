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

namespace MvcAccount {
   
   /// <summary>
   /// Holds link data.
   /// </summary>
   /// <seealso cref="MvcAccount.Html.HtmlUtility"/>
   public class LinkModel {

      /// <summary>
      /// The link's URL.
      /// </summary>
      public string Url { get; private set; }

      /// <summary>
      /// The link's text.
      /// </summary>
      public string Text { get; private set; }

      /// <summary>
      /// Initializes a new instance of the <see cref="LinkModel"/> class
      /// using the provided URL and text.
      /// </summary>
      /// <param name="url">The link's URL.</param>
      /// <param name="text">The link's text.</param>
      public LinkModel(string url, string text) {
         this.Url = url;
         this.Text = text;
      }
   }
}
