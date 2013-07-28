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
using System.Diagnostics;
using System.Linq.Expressions;
using System.Net;

namespace MvcAccount {

   /// <summary>
   /// Represents the outcome of an operation, which includes the result value,
   /// status code and optionally other metadata.
   /// </summary>
   [DebuggerDisplay("{StatusCode}")]
   class OperationResult {

      readonly HttpStatusCode _StatusCode;
      readonly object _Value;

      /// <summary>
      /// The HTTP status code of the result.
      /// </summary>
      public HttpStatusCode StatusCode { get { return _StatusCode; } }

      /// <summary>
      /// The result value of the operation.
      /// </summary>
      public object Value { get { return _Value; } }

      /// <summary>
      /// A URL for the Location HTTP header.
      /// </summary>
      public string Location { get; set; }

      /// <summary>
      /// A URL for the Content-Location HTTP header.
      /// </summary>
      public string ContentLocation { get; set; }

      /// <summary>
      /// true if the outcome of the operation was not successful; otherwise false.
      /// This is determined by the <see cref="StatusCode"/> property.
      /// </summary>
      public bool IsError {
         get { return (int)StatusCode >= 400; }
      }

      /// <summary>
      /// true if the <see cref="StatusCode"/> is a redirect status (300-399 range).
      /// </summary>
      public bool IsRedirect {
         get { return (int)StatusCode >= 300 && !IsError; }
      }

      /// <summary>
      /// Creates a new <see cref="OperationResult"/> object using the provided status code.
      /// </summary>
      /// <param name="statusCode">The status code of the result.</param>
      /// <returns>
      /// A new <see cref="OperationResult"/> object whose <see cref="StatusCode"/> property
      /// is initialized with the <paramref name="statusCode"/> parameter.
      /// </returns>
      public static implicit operator OperationResult(HttpStatusCode statusCode) {
         return new OperationResult(statusCode);
      }

      /// <summary>
      /// Creates a new <see cref="OperationResult"/> object using the <see cref="HttpStatusCode.BadRequest"/>
      /// status code and the provided value.
      /// </summary>
      /// <param name="value">The result value of the operation.</param>
      /// <returns>
      /// A new <see cref="OperationResult"/> object whose <see cref="StatusCode"/> property
      /// is set to <see cref="HttpStatusCode.BadRequest"/>, and whose <see cref="Value"/> property
      /// is initialized with the <paramref name="value"/> parameter.
      /// </returns>
      public static implicit operator OperationResult(ErrorInfo value) {
         return new OperationResult(HttpStatusCode.BadRequest, value);
      }

      /// <summary>
      /// Creates a new <see cref="OperationResult"/> object using the <see cref="HttpStatusCode.BadRequest"/>
      /// status code and the provided value.
      /// </summary>
      /// <param name="value">The result value of the operation.</param>
      /// <returns>
      /// A new <see cref="OperationResult"/> object whose <see cref="StatusCode"/> property
      /// is set to <see cref="HttpStatusCode.BadRequest"/>, and whose <see cref="Value"/> property
      /// is initialized with the <paramref name="value"/> parameter.
      /// </returns>
      public static implicit operator OperationResult(ErrorBuilder value) {
         return new OperationResult(HttpStatusCode.BadRequest, (value != null) ? value.ToError() : null);
      }

      /// <summary>
      /// Initializes a new instance of the <see cref="OperationResult"/> class, using the provided status code.
      /// </summary>
      /// <param name="statusCode">The status code of the result.</param>
      public OperationResult(HttpStatusCode statusCode) {
         this._StatusCode = statusCode;
      }

      /// <summary>
      /// Initializes a new instance of the <see cref="OperationResult"/> class, using the provided status code
      /// and value.
      /// </summary>
      /// <param name="statusCode">The status code of the result.</param>
      /// <param name="value">The result value.</param>
      public OperationResult(HttpStatusCode statusCode, object value)
         : this(statusCode) {

         this._Value = value;
      }
   }

   /// <summary>
   /// An <see cref="OperationResult"/> with a fixed successful result type.
   /// </summary>
   /// <typeparam name="TSuccess">The result type when the operation outcome is successful.</typeparam>
   class OperationResult<TSuccess> : OperationResult {

      /// <summary>
      /// The result value when the operation outcome is successful.
      /// </summary>
      public TSuccess ValueAsSuccess {
         get { return (TSuccess)Value; }
      }

      /// <summary>
      /// Creates a new <see cref="OperationResult&lt;TSuccess>"/> object using the provided status code.
      /// </summary>
      /// <param name="statusCode">The status code of the result.</param>
      /// <returns>
      /// A new <see cref="OperationResult&lt;TSuccess>"/> object whose <see cref="OperationResult.StatusCode"/> property
      /// is initialized with the <paramref name="statusCode"/> parameter.
      /// </returns>
      public static implicit operator OperationResult<TSuccess>(HttpStatusCode statusCode) {
         return new OperationResult<TSuccess>(statusCode);
      }

      /// <summary>
      /// Creates a new <see cref="OperationResult&lt;TSuccess>"/> object using the <see cref="HttpStatusCode.OK"/>
      /// status code and the provided value.
      /// </summary>
      /// <param name="value">The result value of the operation.</param>
      /// <returns>
      /// A new <see cref="OperationResult&lt;TSuccess>"/> object whose <see cref="OperationResult.StatusCode"/> property
      /// is set to <see cref="HttpStatusCode.OK"/>, and whose <see cref="OperationResult.Value"/> property
      /// is initialized with the <paramref name="value"/> parameter.
      /// </returns>
      public static implicit operator OperationResult<TSuccess>(TSuccess value) {
         return new OperationResult<TSuccess>(HttpStatusCode.OK, value);
      }

      /// <summary>
      /// Creates a new <see cref="OperationResult&lt;TSuccess>"/> object using the <see cref="HttpStatusCode.BadRequest"/>
      /// status code and the provided value.
      /// </summary>
      /// <param name="value">The result value of the operation.</param>
      /// <returns>
      /// A new <see cref="OperationResult&lt;TSuccess>"/> object whose <see cref="OperationResult.StatusCode"/> property
      /// is set to <see cref="HttpStatusCode.BadRequest"/>, and whose <see cref="OperationResult.Value"/> property
      /// is initialized with the <paramref name="value"/> parameter.
      /// </returns>
      public static implicit operator OperationResult<TSuccess>(ErrorInfo value) {
         return new OperationResult<TSuccess>(HttpStatusCode.BadRequest, value);
      }

      /// <summary>
      /// Creates a new <see cref="OperationResult&lt;TSuccess>"/> object using the <see cref="HttpStatusCode.BadRequest"/>
      /// status code and the provided value.
      /// </summary>
      /// <param name="value">The result value of the operation.</param>
      /// <returns>
      /// A new <see cref="OperationResult&lt;TSuccess>"/> object whose <see cref="OperationResult.StatusCode"/> property
      /// is set to <see cref="HttpStatusCode.BadRequest"/>, and whose <see cref="OperationResult.Value"/> property
      /// is initialized with the <paramref name="value"/> parameter.
      /// </returns>
      public static implicit operator OperationResult<TSuccess>(ErrorBuilder value) {
         return new OperationResult<TSuccess>(HttpStatusCode.BadRequest, (value != null) ? value.ToError() : null);
      }

      /// <summary>
      /// Initializes a new instance of the <see cref="OperationResult&lt;TSuccess>"/> class, using the
      /// provided status code.
      /// </summary>
      /// <param name="statusCode">The status code of the result.</param>
      public OperationResult(HttpStatusCode statusCode)
         : base(statusCode) { }

      /// <summary>
      /// Initializes a new instance of the <see cref="OperationResult&lt;TSuccess>"/> class, using the
      /// provided status code and value.
      /// </summary>
      /// <param name="statusCode">The status code of the result.</param>
      /// <param name="value">The result value.</param>
      public OperationResult(HttpStatusCode statusCode, object value)
         : base(statusCode, value) { }
   }

   /// <summary>
   /// An <see cref="OperationResult&lt;TSuccess>"/> with a fixed error result type.
   /// </summary>
   /// <typeparam name="TSuccess">The result type when the operation outcome is successful.</typeparam>
   /// <typeparam name="TError">The result type when the operation outcome is not successful.</typeparam>
   class OperationResult<TSuccess, TError> : OperationResult<TSuccess> {

      /// <summary>
      /// The result value when the operation outcome is not successful.
      /// </summary>
      public TError ValueAsError {
         get { return (TError)Value; }
      }

      /// <summary>
      /// Creates a new <see cref="OperationResult&lt;TSuccess, TError>"/> object using the provided status code.
      /// </summary>
      /// <param name="statusCode">The status code of the result.</param>
      /// <returns>
      /// A new <see cref="OperationResult&lt;TSuccess, TError>"/> object whose <see cref="OperationResult.StatusCode"/> property
      /// is initialized with the <paramref name="statusCode"/> parameter.
      /// </returns>
      public static implicit operator OperationResult<TSuccess, TError>(HttpStatusCode statusCode) {
         return new OperationResult<TSuccess, TError>(statusCode);
      }

      /// <summary>
      /// Creates a new <see cref="OperationResult&lt;TSuccess, TError>"/> object using the <see cref="HttpStatusCode.OK"/>
      /// status code and the provided value.
      /// </summary>
      /// <param name="value">The result value of the operation.</param>
      /// <returns>
      /// A new <see cref="OperationResult&lt;TSuccess, TError>"/> object whose <see cref="OperationResult.StatusCode"/> property
      /// is set to <see cref="HttpStatusCode.OK"/>, and whose <see cref="OperationResult.Value"/> property
      /// is initialized with the <paramref name="value"/> parameter.
      /// </returns>
      public static implicit operator OperationResult<TSuccess, TError>(TSuccess value) {
         return new OperationResult<TSuccess, TError>(HttpStatusCode.OK, value);
      }

      /// <summary>
      /// Creates a new <see cref="OperationResult&lt;TSuccess, TError>"/> object using the <see cref="HttpStatusCode.BadRequest"/>
      /// status code and the provided value.
      /// </summary>
      /// <param name="value">The result value of the operation.</param>
      /// <returns>
      /// A new <see cref="OperationResult&lt;TSuccess, TError>"/> object whose <see cref="OperationResult.StatusCode"/> property
      /// is set to <see cref="HttpStatusCode.BadRequest"/>, and whose <see cref="OperationResult.Value"/> property
      /// is initialized with the <paramref name="value"/> parameter.
      /// </returns>
      public static implicit operator OperationResult<TSuccess, TError>(TError value) {
         return new OperationResult<TSuccess, TError>(HttpStatusCode.BadRequest, value);
      }

      /// <summary>
      /// Initializes a new instance of the <see cref="OperationResult&lt;TSuccess, TError>"/> class, using the
      /// provided status code.
      /// </summary>
      /// <param name="statusCode">The status code of the result.</param>
      public OperationResult(HttpStatusCode statusCode)
         : base(statusCode) { }

      /// <summary>
      /// Initializes a new instance of the <see cref="OperationResult&lt;TSuccess, TError>"/> class, using the
      /// provided status code and value.
      /// </summary>
      /// <param name="statusCode">The status code of the result.</param>
      /// <param name="value">The result value.</param>
      public OperationResult(HttpStatusCode statusCode, object value)
         : base(statusCode, value) { }
   }

   partial class ErrorBuilder {

      /// <summary>
      /// Adds <see cref="OperationResult.Value"/> from <paramref name="otherResult"/> if
      /// <see cref="OperationResult.IsError"/> on <paramref name="otherResult"/> is true.
      /// </summary>
      /// <param name="otherResult">An operation result.</param>
      /// <returns>The negated value of <see cref="OperationResult.IsError"/> on <paramref name="otherResult"/>.</returns>
      public bool Assert(OperationResult otherResult) {

         if (otherResult == null) throw new ArgumentNullException("otherResult");

         string message = (otherResult.Value != null) ?
            otherResult.Value.ToString() : null;

         return Assert(!otherResult.IsError, message);
      }

      /// <summary>
      /// Adds <see cref="OperationResult.Value"/> from <paramref name="otherResult"/> if
      /// <see cref="OperationResult.IsError"/> on <paramref name="otherResult"/> is true.
      /// </summary>
      /// <typeparam name="TMember">The type of the tested object.</typeparam>
      /// <param name="otherResult">An operation result.</param>
      /// <param name="valueSelector">A lambda expression that returns the tested object.</param>
      /// <returns>The negated value of <see cref="OperationResult.IsError"/> on <paramref name="otherResult"/>.</returns>
      public bool Assert<TMember>(OperationResult otherResult, Expression<Func<TMember>> valueSelector) {

         if (otherResult == null) throw new ArgumentNullException("otherResult");

         string message = (otherResult.Value != null) ?
            otherResult.Value.ToString() : null;

         return Assert<TMember>(!otherResult.IsError, message, valueSelector);
      }

      /// <summary>
      /// Adds <see cref="OperationResult.Value"/> from <paramref name="otherResult"/> if
      /// <see cref="OperationResult.IsError"/> on <paramref name="otherResult"/> is true.
      /// </summary>
      /// <param name="otherResult">An operation result.</param>
      /// <returns>The value of <see cref="OperationResult.IsError"/> on <paramref name="otherResult"/>.</returns>
      public bool Not(OperationResult otherResult) {
         return !Assert(otherResult);
      }

      /// <summary>
      /// Adds <see cref="OperationResult.Value"/> from <paramref name="otherResult"/> if
      /// <see cref="OperationResult.IsError"/> on <paramref name="otherResult"/> is true.
      /// </summary>
      /// <typeparam name="TMember">The type of the tested object.</typeparam>
      /// <param name="otherResult">An operation result.</param>
      /// <param name="valueSelector">A lambda expression that returns the tested object.</param>
      /// <returns>The value of <see cref="OperationResult.IsError"/> on <paramref name="otherResult"/>.</returns>
      public bool Not<TMember>(OperationResult otherResult, Expression<Func<TMember>> valueSelector) {
         return !Assert<TMember>(otherResult, valueSelector);
      }
   }
}

namespace MvcAccount.Web {
   using System.Web;
   using System.Web.Mvc;

   static partial class OperationModelMvcExtensions {

      /// <summary>
      /// Adds the errors from the <paramref name="operationResult"/> parameter to <paramref name="modelState"/>.
      /// </summary>
      /// <param name="modelState">The <see cref="ModelStateDictionary"/> instance.</param>
      /// <param name="operationResult">The <see cref="OperationResult"/> that contains error information.</param>
      public static void AddModelErrors(this ModelStateDictionary modelState, OperationResult operationResult) {

         if (modelState == null) throw new ArgumentNullException("modelState");
         if (operationResult == null) throw new ArgumentNullException("operationResult");

         if (!operationResult.IsError)
            return;

         object value = operationResult.Value;

         if (value != null) {

            ErrorInfo error = value as ErrorInfo;

            if (error != null)
               AddModelErrors(modelState, error);
            else
               modelState.AddModelError("", value.ToString());
         }
      }

      /// <summary>
      /// Adds errors from <paramref name="operationResult"/> to <see cref="ViewDataDictionary.ModelState"/> in
      /// <paramref name="viewResult"/> and sets status and header information to the current HTTP response.
      /// </summary>
      /// <param name="viewResult">The <see cref="ViewResultBase"/> instance.</param>
      /// <param name="operationResult">The <see cref="OperationResult"/> instance.</param>
      /// <returns>
      /// A new <see cref="ActionResult"/> object that wraps <paramref name="viewResult"/> and adds status and header
      /// information to the current HTTP response, when executed.
      /// </returns>
      /// <example>
      /// This extension method is usually used like this:
      /// <code>
      /// if (result.IsError)
      ///     return View().WithErrors(result);
      /// </code>
      /// </example>
      public static ActionResult WithErrors(this ViewResultBase viewResult, OperationResult operationResult) {

         if (viewResult == null) throw new ArgumentNullException("viewResult");

         AddModelErrors(viewResult.ViewData.ModelState, operationResult);

         return new OperationActionResult(viewResult, operationResult);
      }

      /// <summary>
      /// Sets status information to the current HTTP response.
      /// </summary>
      /// <param name="actionResult">The <see cref="ActionResult"/> instance.</param>
      /// <param name="statusCode">The status code.</param>
      /// <returns>
      /// A new <see cref="ActionResult"/> object that wraps <paramref name="actionResult"/> and adds status
      /// information to the current HTTP response, when executed.
      /// </returns>
      public static ActionResult WithStatus(this ActionResult actionResult, HttpStatusCode statusCode) {
         return new OperationActionResult(actionResult, statusCode);
      }

      /// <summary>
      /// Sets status and header information to the current HTTP response.
      /// </summary>
      /// <param name="actionResult">The <see cref="ActionResult"/> instance.</param>
      /// <param name="operationResult">The <see cref="OperationResult"/> instance.</param>
      /// <returns>
      /// A new <see cref="ActionResult"/> object that wraps <paramref name="actionResult"/> and adds status and header
      /// information to the current HTTP response, when executed.
      /// </returns>
      public static ActionResult WithStatus(this ActionResult actionResult, OperationResult operationResult) {
         return new OperationActionResult(actionResult, operationResult);
      }
   }

   class OperationActionResult : ActionResult {

      readonly ActionResult originalResult;
      readonly OperationResult operationResult;
      readonly HttpStatusCode statusCode;

      public OperationActionResult(ActionResult originalResult, OperationResult operationResult)
         : this(originalResult) {

         this.operationResult = operationResult;
      }

      public OperationActionResult(ActionResult originalResult, HttpStatusCode statusCode)
         : this(originalResult) {

         this.statusCode = statusCode;
      }

      private OperationActionResult(ActionResult originalResult) {

         if (originalResult == null) throw new ArgumentNullException("originalResult");

         this.originalResult = originalResult;
      }

      public override void ExecuteResult(ControllerContext context) {

         HttpResponseBase response = context.HttpContext.Response;

         int httpStatusCode = (this.operationResult != null) ?
            (int)this.operationResult.StatusCode
            : (int)this.statusCode;

         response.StatusCode = httpStatusCode;

         if (httpStatusCode >= 400)
            response.TrySkipIisCustomErrors = true;

         if (this.operationResult != null) 
            SetHeaders(response, this.operationResult);

         this.originalResult.ExecuteResult(context);
      }

      static void SetHeaders(HttpResponseBase response, OperationResult result) {

         if (!String.IsNullOrEmpty(result.Location))
            response.RedirectLocation = result.Location;

         if (!String.IsNullOrEmpty(result.ContentLocation))
            response.AddHeader("Content-Location", result.ContentLocation);
      }
   }
}
