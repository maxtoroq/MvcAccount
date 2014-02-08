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
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq.Expressions;
using System.Net;
using System.Net.Mail;
using System.Security.Principal;
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
      protected internal AccountConfiguration Configuration {
         get { return _Configuration; }
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

      internal ActionResult HttpSeeOther(string location) {

         this.Response.StatusCode = 303;
         this.Response.RedirectLocation = location;

         return new EmptyResult();
      }

      internal string GetValidReturnUrl(string returnUrl) {

         string location = (returnUrl.HasValue() && this.Url.IsLocalUrl(returnUrl)) ?
            returnUrl : ApplicationPath;

         return location;
      }

      string IAccountContext.AbsoluteUrl(string relativeUrl) {
         return new Uri(this.Request.Url, relativeUrl).AbsoluteUri;
      }

      string IAccountContext.RenderEmailView(string viewName, object model) {

         ViewEngineResult viewResult = ViewEngines.Engines.FindLocalizedPartialView(this.ControllerContext, viewName);

         if (viewResult.View == null) {
            throw new InvalidOperationException();
         }

         using (var output = new StringWriter()) {

            var viewContext = new ViewContext(
               this.ControllerContext,
               viewResult.View,
               new ViewDataDictionary(model),
               new TempDataDictionary(),
               output
            );

            viewResult.View.Render(viewContext, output);

            return output.ToString();
         }
      }

      void IAccountContext.SendEmail(MailMessage message) {
         new SmtpClient().Send(message);
      }
   }
}