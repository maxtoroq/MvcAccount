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
using System.Web.Routing;
using System.Web;

namespace MvcAccount.Shared {
   
   /// <summary>
   /// Provides helper methods for HTML views.
   /// </summary>
   static class HtmlUtility {

      /// <summary>
      /// Returns an anchor element (a element) created using the provided link model. 
      /// </summary>
      /// <param name="linkModel">The link model.</param>
      /// <returns>An anchor element (a element).</returns>
      public static MvcHtmlString Link(LinkModel linkModel) {
         return Link(linkModel, (RouteValueDictionary)null);
      }

      /// <summary>
      /// Returns an anchor element (a element) created using the provided link model. 
      /// </summary>
      /// <param name="linkModel">The link model.</param>
      /// <param name="htmlAttributes">An object that contains the HTML attributes to set for the element.</param>
      /// <returns>An anchor element (a element).</returns>
      public static MvcHtmlString Link(LinkModel linkModel, object htmlAttributes) {

         RouteValueDictionary attributes = (htmlAttributes != null) ?
            new RouteValueDictionary(htmlAttributes)
            : null;

         return Link(linkModel, attributes);
      }

      /// <summary>
      /// Returns an anchor element (a element) created using the provided link model. 
      /// </summary>
      /// <param name="linkModel">The link model.</param>
      /// <param name="htmlAttributes">An object that contains the HTML attributes to set for the element.</param>
      /// <returns>An anchor element (a element).</returns>
      public static MvcHtmlString Link(LinkModel linkModel, RouteValueDictionary htmlAttributes) {

         if (linkModel == null) throw new ArgumentNullException("linkModel");

         TagBuilder builder = new TagBuilder("a") {
            InnerHtml = !String.IsNullOrEmpty(linkModel.Text) ?
               HttpUtility.HtmlEncode(linkModel.Text)
               : ""
         };

         builder.MergeAttributes(htmlAttributes);
         builder.MergeAttribute("href", linkModel.Url);

         return MvcHtmlString.Create(builder.ToString(TagRenderMode.Normal));
      }

      /// <summary>
      /// Creates a strongly typed HTML helper.
      /// </summary>
      /// <typeparam name="TModel">The type of the model.</typeparam>
      /// <param name="htmlHelper">The HTML helper of the view.</param>
      /// <returns>A new <see cref="HtmlHelper&lt;TModel>"/> object.</returns>
      public static HtmlHelper<TModel> HtmlHelperFor<TModel>(HtmlHelper htmlHelper) {
         return HtmlHelperFor(htmlHelper, default(TModel));
      }

      /// <summary>
      /// Creates a strongly typed HTML helper.
      /// </summary>
      /// <typeparam name="TModel">The type of the model.</typeparam>
      /// <param name="htmlHelper">The HTML helper of the view.</param>
      /// <param name="model">The model object.</param>
      /// <returns>A new <see cref="HtmlHelper&lt;TModel>"/> object.</returns>
      public static HtmlHelper<TModel> HtmlHelperFor<TModel>(HtmlHelper htmlHelper, TModel model) {
         return HtmlHelperFor(htmlHelper, model, null);
      }

      /// <summary>
      /// Creates a strongly typed HTML helper.
      /// </summary>
      /// <typeparam name="TModel">The type of the model.</typeparam>
      /// <param name="htmlHelper">The HTML helper of the view.</param>
      /// <param name="model">The model object.</param>
      /// <param name="htmlFieldPrefix">The HTML field prefix for the new HTML helper.</param>
      /// <returns>A new <see cref="HtmlHelper&lt;TModel>"/> object.</returns>
      public static HtmlHelper<TModel> HtmlHelperFor<TModel>(HtmlHelper htmlHelper, TModel model, string htmlFieldPrefix) {

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
