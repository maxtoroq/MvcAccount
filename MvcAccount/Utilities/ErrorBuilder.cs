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
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace MvcAccount {
   
   /// <summary>
   /// Represents a class used to build <see cref="ErrorInfo"/> instances.
   /// Includes methods for conditionally adding errors, and invoking Data Annotations attribute-based
   /// validation.
   /// </summary>
   partial class ErrorBuilder {

      readonly List<ErrorDetail> errors = new List<ErrorDetail>();

      /// <summary>
      /// Returns true if this instance has any errors; otherwise, false.
      /// </summary>
      public bool HasErrors {
         get { return errors.Count > 0; }
      }

      /// <summary>
      /// Gets or sets a value that indicates if you want to include the first expression (or segment)
      /// in a multi-part member expression (or object path, e.g. param.Property1.Property2),
      /// in the member name when the error is added, when using methods that take a value selector lambda expression 
      /// (e.g. <see cref="Add&lt;TMember>(String, Expression&lt;Func&lt;TMember>>)"/>). The default is false.
      /// </summary>
      public bool IncludeValueSelectorFirstKeySegment { get; set; }

      /// <summary>
      /// Adds <paramref name="message"/>.
      /// </summary>
      /// <param name="message">The error message.</param>
      /// <returns>A reference to this instance after the add operation has completed.</returns>
      public ErrorBuilder Add(string message) {
         return Add(message, null);
      }

      /// <summary>
      /// Adds <paramref name="message"/>.
      /// </summary>
      /// <param name="message">The error message.</param>
      /// <param name="value">The value of the tested object.</param>
      /// <returns>A reference to this instance after the add operation has completed.</returns>
      public ErrorBuilder Add(string message, object value) {
         return Add(message, value, null);
      }

      /// <summary>
      /// Adds <paramref name="message"/>.
      /// </summary>
      /// <param name="message">The error message.</param>
      /// <param name="value">The value of the tested object.</param>
      /// <param name="key">The key that identifies the tested object, e.g. a property name.</param>
      /// <returns>A reference to this instance after the add operation has completed.</returns>
      public ErrorBuilder Add(string message, object value, string key) {

         if (message == null) throw new ArgumentNullException("message");

         AddError(message, value, key, (key != null) ? new[] { key } : null);

         return this;
      }

      /// <summary>
      /// Adds <paramref name="message"/>.
      /// </summary>
      /// <typeparam name="TMember">The type of the tested object.</typeparam>
      /// <param name="message">The error message.</param>
      /// <param name="valueSelector">A lambda expression that returns the tested object.</param>
      /// <returns>A reference to this instance after the add operation has completed.</returns>
      [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Justification = "For use with lambda expressions.")]
      public ErrorBuilder Add<TMember>(string message, Expression<Func<TMember>> valueSelector) {

         if (message == null) throw new ArgumentNullException("message");
         if (valueSelector == null) throw new ArgumentNullException("valueSelector");

         string fullKey = NameOf(valueSelector, this.IncludeValueSelectorFirstKeySegment);
         string key = fullKey.Split('.').Last();
         object value = valueSelector.Compile().Invoke();

         MemberExpression memberExpr = valueSelector.Body as MemberExpression;

         if (memberExpr != null) 
            key = GetDisplayName(memberExpr.Member) ?? key;

         AddError(message, value, key, new[] { fullKey });

         return this;
      }

      static string GetDisplayName(MemberInfo member) {

         DisplayAttribute displayAttr =
            Attribute.GetCustomAttribute(member, typeof(DisplayAttribute)) as DisplayAttribute;

         if (displayAttr != null)
            return displayAttr.GetName();

         return null;
      }

      /// <summary>
      /// Adds the validation result.
      /// </summary>
      /// <param name="validationResult">The validation result to add.</param>
      /// <returns>A reference to this instance after the add operation has completed.</returns>
      public ErrorBuilder Add(ValidationResult validationResult) {

         if (validationResult == null) throw new ArgumentNullException("validationResult");

         AddError(validationResult.ErrorMessage, validationResult.MemberNames);

         return this;
      }

      /// <summary>
      /// Adds the validation results.
      /// </summary>
      /// <param name="validationResults">The validation results to add.</param>
      /// <returns>A reference to this instance after the add range operation has completed.</returns>
      public ErrorBuilder AddRange(IEnumerable<ValidationResult> validationResults) {

         if (validationResults == null) throw new ArgumentNullException("validationResults");

         foreach (var item in validationResults)
            Add(item);

         return this;
      }

      /// <summary>
      /// Adds the errors.
      /// </summary>
      /// <param name="errors">The errors to add.</param>
      /// <returns>A reference to this instance after the add range operation has completed.</returns>
      public ErrorBuilder AddRange(ErrorInfo errors) {

         for (int i = 0; i < errors.Errors.Count; i++) {
            
            ErrorDetail error = errors.Errors[i];

            AddError(error.ErrorMessage, error.MemberNames);
         }

         return this;
      }

      void AddError(string message, IEnumerable<string> memberNames) {
         this.errors.Add(new ErrorDetail(message, memberNames));
      }

      void AddError(string message, object value, string key, IEnumerable<string> memberNames) {
         AddError(String.Format(CultureInfo.InvariantCulture, message, value, key), memberNames);
      }

      /// <summary>
      /// Adds <paramref name="message"/> if <paramref name="condition"/> is false.
      /// </summary>
      /// <param name="condition">
      /// The conditional expression to evaluate. If the condition is true the <paramref name="message"/>
      /// is not added.
      /// </param>
      /// <param name="message">The error message.</param>
      /// <returns>The value of <paramref name="condition"/>.</returns>
      public bool Assert(bool condition, string message) {

         if (!condition)
            Add(message);

         return condition;
      }

      /// <summary>
      /// Adds <paramref name="message"/> if <paramref name="condition"/> is false.
      /// </summary>
      /// <param name="condition">
      /// The conditional expression to evaluate. If the condition is true the <paramref name="message"/>
      /// is not added.
      /// </param>
      /// <param name="message">The error message.</param>
      /// <param name="value">The value of the tested object.</param>
      /// <returns>The value of <paramref name="condition"/>.</returns>
      public bool Assert(bool condition, string message, object value) {

         if (!condition)
            Add(message, value);

         return condition;
      }

      /// <summary>
      /// Adds <paramref name="message"/> if <paramref name="condition"/> is false.
      /// </summary>
      /// <param name="condition">
      /// The conditional expression to evaluate. If the condition is true the <paramref name="message"/>
      /// is not added.
      /// </param>
      /// <param name="message">The error message.</param>
      /// <param name="value">The value of the tested object.</param>
      /// <param name="key">The key that identifies the tested object, e.g. a property name.</param>
      /// <returns>The value of <paramref name="condition"/>.</returns>
      public bool Assert(bool condition, string message, object value, string key) {

         if (!condition)
            Add(message, value, key);

         return condition;
      }

      /// <summary>
      /// Adds <paramref name="message"/> if <paramref name="condition"/> is false.
      /// </summary>
      /// <typeparam name="TMember">The type of the tested object.</typeparam>
      /// <param name="condition">
      /// The conditional expression to evaluate. If the condition is true the <paramref name="message"/>
      /// is not added.
      /// </param>
      /// <param name="message">The error message.</param>
      /// <param name="valueSelector">A lambda expression that returns the tested object.</param>
      /// <returns>The value of <paramref name="condition"/>.</returns>
      [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Justification = "For use with lambda expressions.")]
      public bool Assert<TMember>(bool condition, string message, Expression<Func<TMember>> valueSelector) {

         if (!condition)
            Add(message, valueSelector);

         return condition;
      }

      /// <summary>
      /// Adds <paramref name="message"/> if <paramref name="condition"/> is false.
      /// </summary>
      /// <param name="condition">
      /// The conditional expression to evaluate. If the condition is true the <paramref name="message"/>
      /// is not added.
      /// </param>
      /// <param name="message">The error message.</param>
      /// <returns>The negated value of <paramref name="condition"/>.</returns>
      public bool Not(bool condition, string message) {
         return !Assert(condition, message);
      }

      /// <summary>
      /// Adds <paramref name="message"/> if <paramref name="condition"/> is false.
      /// </summary>
      /// <param name="condition">
      /// The conditional expression to evaluate. If the condition is true the <paramref name="message"/>
      /// is not added.
      /// </param>
      /// <param name="message">The error message.</param>
      /// <param name="value">The value of the tested object.</param>
      /// <returns>The negated value of <paramref name="condition"/>.</returns>
      public bool Not(bool condition, string message, object value) {
         return !Assert(condition, message, value);
      }

      /// <summary>
      /// Adds <paramref name="message"/> if <paramref name="condition"/> is false.
      /// </summary>
      /// <param name="condition">
      /// The conditional expression to evaluate. If the condition is true the <paramref name="message"/>
      /// is not added.
      /// </param>
      /// <param name="message">The error message.</param>
      /// <param name="value">The value of the tested object.</param>
      /// <param name="key">The key that identifies the tested object, e.g. a property name.</param>
      /// <returns>The negated value of <paramref name="condition"/>.</returns>
      public bool Not(bool condition, string message, object value, string key) {
         return !Assert(condition, message, value, key);
      }

      /// <summary>
      /// Adds <paramref name="message"/> if <paramref name="condition"/> is false.
      /// </summary>
      /// <typeparam name="TMember">The type of the tested object.</typeparam>
      /// <param name="condition">
      /// The conditional expression to evaluate. If the condition is true the <paramref name="message"/>
      /// is not added.
      /// </param>
      /// <param name="message">The error message.</param>
      /// <param name="valueSelector">A lambda expression that returns the tested object.</param>
      /// <returns>The negated value of <paramref name="condition"/>.</returns>
      [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Justification = "For use with lambda expressions.")]
      public bool Not<TMember>(bool condition, string message, Expression<Func<TMember>> valueSelector) {
         return !Assert<TMember>(condition, message, valueSelector);
      }

      /// <summary>
      /// Invokes Data Annotations validation and adds the validation results.
      /// </summary>
      /// <param name="value">The obejct to validate.</param>
      /// <returns>true if the object is valid; otherwise false.</returns>
      public bool Valid(object value) {

         var validation = new List<ValidationResult>();

         bool valid = Validator.TryValidateObject(value, new ValidationContext(value, null, null), validation, validateAllProperties: true);

         AddRange(validation);

         return valid;
      }

      /// <summary>
      /// Invokes Data Annotations validation and adds the validation results.
      /// </summary>
      /// <param name="value">The obejct to validate.</param>
      /// <returns>true if the object is not valid; otherwise false.</returns>
      public bool NotValid(object value) {
         return !Valid(value);
      }

      /// <summary>
      /// Invokes Data Annotations validation and adds the validation results.
      /// </summary>
      /// <typeparam name="T">The type of objects to validate.</typeparam>
      /// <param name="values">The objects to validate.</param>
      /// <returns>true if all object are valid; otherwise false.</returns>
      public bool ValidAll<T>(IList<T> values) {

         if (values == null) throw new ArgumentNullException("values");

         bool valid = true;

         for (int i = 0; i < values.Count; i++) {

            var validation = new List<ValidationResult>();
            object obj = values[i];
            bool objValid = Validator.TryValidateObject(obj, new ValidationContext(obj, null, null), validation, validateAllProperties: true);
            string baseName = String.Concat("[", i.ToString(CultureInfo.InvariantCulture), "].");

            for (int j = 0; j < validation.Count; j++) {

               ValidationResult valResult = validation[j];

               AddError(valResult.ErrorMessage, valResult.MemberNames.Select(n => baseName + n));
            }

            if (valid)
               valid = objValid;
         }

         return valid;
      }

      /// <summary>
      /// Invokes Data Annotations validation and adds the validation results.
      /// </summary>
      /// <typeparam name="T">The type of objects to validate.</typeparam>
      /// <param name="values">The objects to validate.</param>
      /// <returns>true if one or more objects are not valid; otherwise false.</returns>
      public bool NotValidAll<T>(IList<T> values) {
         return !ValidAll(values);
      }

      /// <summary>
      /// Invokes Data Annotations validation and adds the validation results.
      /// </summary>
      /// <typeparam name="TProperty">The type of the property to validate.</typeparam>
      /// <param name="propertySelector">A lambda expression that returns the property to validate.</param>
      /// <returns>true if the property is valid; otherwise false.</returns>
      [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Justification = "For use with lambda expressions.")]
      public bool ValidProperty<TProperty>(Expression<Func<TProperty>> propertySelector) {

         if (propertySelector == null) throw new ArgumentNullException("propertySelector");

         MemberExpression memberExpr = (MemberExpression)propertySelector.Body;
         string propertyName = memberExpr.Member.Name;
         TProperty propertyValue = propertySelector.Compile().Invoke();
         object instance = Expression.Lambda(memberExpr.Expression).Compile().DynamicInvoke();

         var validation = new List<ValidationResult>();
         var context = new ValidationContext(instance, null, null) { 
            MemberName = propertyName 
         };

         bool valid = Validator.TryValidateProperty(propertyValue, context, validation);

         AddRange(validation);

         return valid;
      }

      /// <summary>
      /// Invokes Data Annotations validation and adds the validation results.
      /// </summary>
      /// <typeparam name="TProperty">The type of the property to validate.</typeparam>
      /// <param name="propertySelector">A lambda expression that returns the property to validate.</param>
      /// <returns>true if the property is not valid; otherwise false.</returns>
      [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Justification = "For use with lambda expressions.")]
      public bool NotValidProperty<TProperty>(Expression<Func<TProperty>> propertySelector) {
         return !ValidProperty<TProperty>(propertySelector);
      }

      /// <summary>
      /// Creates and returns an <see cref="ErrorInfo"/> object whose <see cref="ErrorInfo.Errors"/> property
      /// is initialized with all the errors added to this instance so far.
      /// </summary>
      /// <returns>
      /// A new <see cref="ErrorInfo"/> object whose <see cref="ErrorInfo.Errors"/> property
      /// is initialized with all the errors added to this instance so far.
      /// </returns>
      public ErrorInfo ToError() {

         var error = new ErrorInfo();

         for (int i = 0; i < this.errors.Count; i++) {
            ErrorDetail item = this.errors[i];
            error.Errors.Add(new ErrorDetail(item.ErrorMessage, item.MemberNames));
         }

         return error;
      }

      /// <summary>
      /// Removes all errors added to this instance.
      /// </summary>
      public void Clear() {
         this.errors.Clear();
      }

      static string NameOf(LambdaExpression valueSelector, bool includeFirstKeySegment = false) {

         List<string> segments = new List<string>();

         Expression body = valueSelector.Body;

         while (body != null) {

            if (body.NodeType == ExpressionType.Call) {

               MethodCallExpression callExpr = (MethodCallExpression)body;
               segments.Add(GetIndexerExpression(callExpr.Arguments.Single()));
               body = callExpr.Object;

            } else {

               if (body.NodeType == ExpressionType.ArrayIndex) {

                  BinaryExpression binaryExpr = (BinaryExpression)body;
                  segments.Add(GetIndexerExpression(binaryExpr.Right));
                  body = binaryExpr.Left;

                  continue;
               }

               if (body.NodeType == ExpressionType.MemberAccess) {

                  MemberExpression memberExpr = (MemberExpression)body;
                  segments.Add("." + memberExpr.Member.Name);
                  body = memberExpr.Expression;

                  continue;
               }

               body = null;
            }
         }

         if (segments.Count == 0)
            return "";

         segments.Reverse();

         if (!includeFirstKeySegment)
            segments.RemoveAt(0);

         return String.Join("", segments).TrimStart('.');
      }

      static string GetIndexerExpression(Expression expression) {

         Expression body = Expression.Convert(expression, typeof(object));
         var lambdaExpression = Expression.Lambda<Func<object>>(body);

         Func<object> func = lambdaExpression.Compile();

         return String.Concat("[", Convert.ToString(func(), CultureInfo.InvariantCulture), "]");
      }
   }

   /// <summary>
   /// Represents a class that is used to report errors. It can include a single error message
   /// or multiple error message with member names mapping information, that can indicate which members
   /// of the input are incorrect, and can be used map those errors to the origin UI element (i.e. forms).
   /// </summary>
   [DataContract(Namespace = "", Name = "error")]
   [XmlRoot("error")]
   class ErrorInfo : IDataErrorInfo {

      string _Message;
      readonly Collection<ErrorDetail> _Errors;

      /// <summary>
      /// Gets or sets the main error message.
      /// This could be set explicitly, or extracted from the <see cref="ErrorInfo.Errors"/>
      /// collection, where the first error with empty member names is used.
      /// </summary>
      [DataMember(Name = "message")]
      [XmlElement("message")]
      public string Message {
         get {
            return _Message ??
               (from e in Errors
                where e.MemberNames.Count == 0
                  || e.MemberNames.Contains("")
                select e.ErrorMessage).FirstOrDefault();
         }
         set {
            _Message = value;
         }
      }

      /// <summary>
      /// Gets the collection of errors for this instance.
      /// </summary>
      [DataMember(Name = "details")]
      [XmlArray("details"), XmlArrayItem("err")]
      public Collection<ErrorDetail> Errors {
         get { return _Errors; }
      }

      [SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Justification = "Functionality not meant for child types, and same data can be obtained using other members.")]
      string IDataErrorInfo.Error {
         get { return Message; }
      }

      [SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Justification = "Functionality not meant for child types, and same data can be obtained using other members.")]
      string IDataErrorInfo.this[string columnName] {
         get {
            return Errors
               .Where(e => e.MemberNames.Contains(columnName, StringComparer.Ordinal))
               .Select(e => e.ErrorMessage)
               .FirstOrDefault();
         }
      }

      /// <summary>
      /// Initializes a new instance of the <see cref="ErrorInfo"/> class.
      /// </summary>
      public ErrorInfo() {
         this._Errors = new Collection<ErrorDetail>();
      }

      /// <summary>
      /// Initializes a new instance of the <see cref="ErrorInfo"/> class using the provided
      /// error message.
      /// </summary>
      /// <param name="errorMessage">The error message.</param>
      public ErrorInfo(string errorMessage)
         : this() {

         this.Message = errorMessage;
      }

      /// <summary>
      /// Returns the main error message.
      /// </summary>
      /// <returns>The main error message.</returns>
      /// <seealso cref="ErrorInfo.Message"/>
      public override string ToString() {
         return this.Message;
      }
   }

   /// <summary>
   /// Represents a single error that includes a message and member names information.
   /// </summary>
   /// <remarks>
   /// This class is basically a serializable version of <see cref="System.ComponentModel.DataAnnotations.ValidationResult"/>.
   /// </remarks>
   /// <seealso cref="ErrorInfo"/>
   [DataContract(Namespace = "", Name = "err")]
   [XmlRoot("err")]
   class ErrorDetail {

      string _ErrorMessage;
      readonly MemberNamesCollection _MemberNames;

      /// <summary>
      /// Gets or sets the error message.
      /// </summary>
      [DataMember(Name = "message")]
      [XmlElement("message")]
      public string ErrorMessage {
         get { return _ErrorMessage; }
         set { _ErrorMessage = value; }
      }

      /// <summary>
      /// Gets the collection of member names that this error refers to, which may be empty.
      /// </summary>
      [DataMember(Name = "members")]
      [XmlArray("members"), XmlArrayItem("name")]
      public MemberNamesCollection MemberNames {
         get { return _MemberNames; }
      }

      /// <summary>
      /// Initializes a new instance of the <see cref="ErrorDetail"/> class using an empty
      /// error message.
      /// </summary>
      public ErrorDetail()
         : this(null) { }

      /// <summary>
      /// Initializes a new instance of the <see cref="ErrorDetail"/> class using the provided
      /// error message.
      /// </summary>
      /// <param name="errorMessage">The error message.</param>
      public ErrorDetail(string errorMessage)
         : this(errorMessage, null) { }

      /// <summary>
      /// Initializes a new instance of the <see cref="ErrorDetail"/> class using the provided
      /// error message and member names.
      /// </summary>
      /// <param name="errorMessage">The error message.</param>
      /// <param name="memberNames">The member names.</param>
      public ErrorDetail(string errorMessage, IEnumerable<string> memberNames) {

         this.ErrorMessage = errorMessage;
         this._MemberNames = new MemberNamesCollection((memberNames ?? new string[0]).ToList());
      }

      /// <summary>
      /// Returns the error message.
      /// </summary>
      /// <returns>The error message.</returns>
      /// <seealso cref="ErrorDetail.ErrorMessage"/>
      public override string ToString() {
         return this.ErrorMessage;
      }

      /// <summary>
      /// A collection of <see cref="String"/> that represent member names.
      /// </summary>
      /// <remarks>
      /// The sole purpose of this class is to customize the item name used by DataContract serialization
      /// on <see cref="ErrorDetail.MemberNames"/>.
      /// </remarks>
      /// <seealso cref="ErrorDetail.MemberNames"/>
      [CollectionDataContract(Namespace = "", ItemName = "name")]
      public class MemberNamesCollection : Collection<string> {

         /// <summary>
         /// Initializes a new instance of the <see cref="MemberNamesCollection"/> class using the
         /// provided member names.
         /// </summary>
         /// <param name="memberNames">A collection of member names.</param>
         public MemberNamesCollection(IList<string> memberNames)
            : base(memberNames) { }
      }
   }
}

namespace MvcAccount.Web {
   using System.Web.Mvc;

   /// <summary>
   /// Provides a set of static (Shared in Visual Basic) extension methods that provide integration
   /// with ASP.NET MVC classes.
   /// </summary>
   static partial class OperationModelMvcExtensions {

      /// <summary>
      /// Adds the errors from the <paramref name="error"/> parameter to <paramref name="modelState"/>.
      /// </summary>
      /// <param name="modelState">The <see cref="ModelStateDictionary"/> instance.</param>
      /// <param name="error">The errors to add.</param>
      public static void AddModelErrors(this ModelStateDictionary modelState, ErrorInfo error) {

         string message = error.Message;

         if (String.IsNullOrEmpty(message))
            message = null;

         if (message != null)
            modelState.AddModelError("", message);

         foreach (var item in error.Errors) {

            IList<string> memberNames = item.MemberNames;
            string itemMessage = item.ErrorMessage;

            if (memberNames.Count > 0) {

               for (int i = 0; i < memberNames.Count; i++)
                  modelState.AddModelError(memberNames[i] ?? "", itemMessage);

            } else {

               if (message != null
                  && itemMessage == message)
                  continue;

               modelState.AddModelError("", itemMessage);
            }
         }
      }

      /// <summary>
      /// Creates an <see cref="ErrorInfo"/> instance from the errors in <paramref name="modelState"/>.
      /// </summary>
      /// <param name="modelState">The <see cref="ModelStateDictionary"/> instance.</param>
      /// <returns>A new <see cref="ErrorInfo"/> instance.</returns>
      public static ErrorInfo ToError(this ModelStateDictionary modelState) {

         var error = new ErrorInfo();

         foreach (var item in modelState.Where(m => m.Value.Errors.Count > 0)) {
            foreach (var err in item.Value.Errors) {
               error.Errors.Add(new ErrorDetail(err.ErrorMessage, new[] { item.Key }));
            }
         }

         return error;
      }
   }
}
