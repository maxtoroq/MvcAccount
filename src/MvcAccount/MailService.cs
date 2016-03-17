// Copyright 2016 Max Toro Q.
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
using System.IO;
using System.Net.Mail;
using System.Web.Mvc;

namespace MvcAccount {

   /// <summary>
   /// Sends SMTP notification messages.
   /// </summary>
   public class MailService {

      /// <summary>
      /// Sends SMTP notification <paramref name="messages"/>
      /// </summary>
      /// <param name="messages">The messages to send.</param>
      public virtual void Send(params MailMessage[] messages) {

         if (messages == null
            || messages.Length == 0) {

            return;
         }

         using (var smtp = new SmtpClient()) {

            foreach (MailMessage item in messages) {
               smtp.Send(item);
            }
         }
      }

      /// <summary>
      /// Renders a partial view that represents a mail template.
      /// </summary>
      /// <param name="controllerContext">The current controller context.</param>
      /// <param name="viewName">The name of the view to render.</param>
      /// <param name="model">An object to use as model for the view.</param>
      /// <returns>The view as a string.</returns>
      public virtual string RenderMailView(ControllerContext controllerContext, string viewName, object model) {

         ViewEngineResult viewResult = ViewEngines.Engines.FindLocalizedPartialView(controllerContext, viewName);

         if (viewResult.View == null) {
            throw new InvalidOperationException();
         }

         using (var output = new StringWriter()) {

            var viewContext = new ViewContext(
               controllerContext,
               viewResult.View,
               new ViewDataDictionary(model),
               new TempDataDictionary(),
               output
            );

            viewResult.View.Render(viewContext, output);

            return output.ToString();
         }
      }
   }
}