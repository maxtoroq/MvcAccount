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

namespace MvcAccount.Shared {
   
   /// <summary>
   /// Holds common data for views that have a form.
   /// </summary>
   /// <typeparam name="TInputModel">The form's input type.</typeparam>
   public abstract class FormViewModel<TInputModel> : BaseViewModel {

      /// <summary>
      /// The form's input model.
      /// </summary>
      public TInputModel InputModel { get; private set; }

      /// <summary>
      /// Text for the submit button.
      /// </summary>
      public string SubmitText { get; set; }

      /// <summary>
      /// Text for the cancel button.
      /// </summary>
      public string CancelText { get; set; }

      /// <summary>
      /// Initializes a new instance of the FormViewModel&lt;TInputModel> class
      /// using the provided input model.
      /// </summary>
      /// <param name="inputModel">The form's input model.</param>
      protected FormViewModel(TInputModel inputModel) {
         
         this.InputModel = inputModel;
         this.CancelText = AccountResources.Views_Cancel;
      }

      /// <summary>
      /// Returns a <see cref="HtmlHelper&lt;TInputModel>"/> to be used to render form controls for the <see cref="InputModel"/>.
      /// </summary>
      /// <param name="htmlHelper">The <see cref="HtmlHelper"/> of the current view.</param>
      /// <returns>An <see cref="HtmlHelper&lt;TInputModel>"/> instance.</returns>
      public HtmlHelper<TInputModel> HtmlHelperForInput(HtmlHelper htmlHelper) {
         return HtmlHelperFor<TInputModel>(htmlHelper, this.InputModel);
      }

      static HtmlHelper<TModel> HtmlHelperFor<TModel>(HtmlHelper htmlHelper, TModel model) {
         return HtmlHelperFor(htmlHelper, model, null);
      }

      static HtmlHelper<TModel> HtmlHelperFor<TModel>(HtmlHelper htmlHelper, TModel model, string htmlFieldPrefix) {

         IViewDataContainer viewDataContainer = CreateViewDataContainer(htmlHelper.ViewData, model);

         TemplateInfo templateInfo = viewDataContainer.ViewData.TemplateInfo;

         if (!String.IsNullOrEmpty(htmlFieldPrefix))
            templateInfo.HtmlFieldPrefix = templateInfo.GetFullHtmlFieldName(htmlFieldPrefix);

         ViewContext viewContext = htmlHelper.ViewContext;
         ViewContext newViewContext = new ViewContext(viewContext.Controller.ControllerContext, viewContext.View, viewDataContainer.ViewData, viewContext.TempData, viewContext.Writer);

         return new HtmlHelper<TModel>(newViewContext, viewDataContainer, htmlHelper.RouteCollection);
      }

      static IViewDataContainer CreateViewDataContainer(ViewDataDictionary viewData, object model) {

         var newViewData = new ViewDataDictionary(viewData) {
            Model = model
         };

         newViewData.TemplateInfo = new TemplateInfo {
            HtmlFieldPrefix = newViewData.TemplateInfo.HtmlFieldPrefix
         };

         return new ViewDataContainer {
            ViewData = newViewData
         };
      }

      class ViewDataContainer : IViewDataContainer {

         public ViewDataDictionary ViewData { get; set; }
      }
   }
}
