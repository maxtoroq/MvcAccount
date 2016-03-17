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
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.Routing;

namespace MvcAccount.Shared {
   
   /// <summary>
   /// Base class for all MvcAccount's controllers.
   /// </summary>
   public abstract class BaseController : Controller, IAccountContext {

      static readonly string ApplicationPath = VirtualPathUtility.AppendTrailingSlash(HostingEnvironment.ApplicationVirtualPath);

      AccountConfiguration _Configuration;

      /// <summary>
      /// The <see cref="AccountConfiguration"/> instance for the current request.
      /// </summary>
      protected AccountConfiguration Configuration {
         get { return _Configuration; }
      }

      [Obsolete("Don't read the request directly, use model binding instead.")]
      internal new HttpRequestBase Request {
         get { return base.Request; }
      }

      [Obsolete("Don't write to the response directly, use action results instead.")]
      internal new HttpResponseBase Response {
         get { return base.Response; }
      }

      string IAccountContext.CurrentUserName {
         get { return User.Identity.Name; }
      }

      string IAccountContext.SiteName {
         get {
            return this.Configuration.SiteName 
               ?? this.HttpContext.Request.Url.Host;
         }
      }

      /// <summary>
      /// Initializes data that might not be available when the constructor is called.
      /// </summary>
      /// <param name="requestContext">The HTTP context and route data.</param>
      protected override void Initialize(RequestContext requestContext) {
         
         base.Initialize(requestContext);

         _Configuration = AccountConfiguration.Current(requestContext);
      }

      internal string GetValidReturnUrl(string returnUrl) {

         string location = (returnUrl.HasValue() && this.Url.IsLocalUrl(returnUrl)) ?
            returnUrl : ApplicationPath;

         return location;
      }

      string IAccountContext.AbsoluteUrl(string relativeUrl) {
#pragma warning disable 618
         return new Uri(this.Request.Url, relativeUrl).AbsoluteUri;
#pragma warning restore 618
      }
   }
}