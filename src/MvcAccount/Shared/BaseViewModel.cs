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
using System.Web.Mvc;
using System.Web;

namespace MvcAccount.Shared {
   
   /// <summary>
   /// Holds common view data.
   /// </summary>
   public abstract class BaseViewModel {

      readonly Lazy<string> _ViewCssClass;
      readonly Lazy<UrlHelper> _Url;

      /// <summary>
      /// The view's title, used on h1 and title elements.
      /// </summary>
      public string Title { get; set; }

      /// <summary>
      /// A space-separated list of CSS classes to be used in the view.
      /// </summary>
      public string ViewCssClass {
         get { return _ViewCssClass.Value; }
      }

      /// <summary>
      /// A <see cref="UrlHelper"/> for creating URLs.
      /// </summary>
      protected UrlHelper Url {
         get { return _Url.Value; }
      }

      /// <summary>
      /// Initializes a new instance of the <see cref="BaseViewModel"/> class.
      /// </summary>
      protected BaseViewModel () {
         
         _ViewCssClass = new Lazy<string>(() => "MvcAccount " + GetType().FullName.Replace(".", "-"));
         _Url = new Lazy<UrlHelper>(() => new UrlHelper(HttpContext.Current.Request.RequestContext));
	   }
   }
}
