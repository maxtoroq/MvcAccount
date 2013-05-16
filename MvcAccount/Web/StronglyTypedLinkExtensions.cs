// Copyright 2013 Max Toro Q.
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
using System.Collections.Concurrent;
using System.Linq;
using System.Reflection;
using System.Web.Mvc;
using System.Web.Routing;

namespace MvcAccount.Web {
   
   static class StronglyTypedLinkExtensions {

      static readonly ConcurrentDictionary<MethodInfo, string> actionNames = new ConcurrentDictionary<MethodInfo, string>();

      public static string Action(this UrlHelper urlHelper, Func<ActionResult> action) {
         return ActionImpl(urlHelper, action, default(object[]));
      }

      public static string Action<T>(this UrlHelper urlHelper, Func<T, ActionResult> action, T arg) {
         return ActionImpl(urlHelper, action, arg);
      }

      public static string Action<T1, T2>(this UrlHelper urlHelper, Func<T1, T2, ActionResult> action, T1 arg1, T2 arg2) {
         return ActionImpl(urlHelper, action, arg1, arg2);
      }

      public static string Action<T1, T2, T3>(this UrlHelper urlHelper, Func<T1, T2, T3, ActionResult> action, T1 arg1, T2 arg2, T3 arg3) {
         return ActionImpl(urlHelper, action, arg1, arg2, arg3);
      }

      public static string Action<T1, T2, T3, T4>(this UrlHelper urlHelper, Func<T1, T2, T3, T4, ActionResult> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4) {
         return ActionImpl(urlHelper, action, arg1, arg2, arg3, arg4);
      }

      public static string Action<T1, T2, T3, T4, T5>(this UrlHelper urlHelper, Func<T1, T2, T3, T4, T5, ActionResult> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) {
         return ActionImpl(urlHelper, action, arg1, arg2, arg3, arg4, arg5);
      }

      public static string Action<T1, T2, T3, T4, T5, T6>(this UrlHelper urlHelper, Func<T1, T2, T3, T4, T5, T6, ActionResult> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) {
         return ActionImpl(urlHelper, action, arg1, arg2, arg3, arg4, arg5, arg6);
      }

      public static string Action<T1, T2, T3, T4, T5, T6, T7>(this UrlHelper urlHelper, Func<T1, T2, T3, T4, T5, T6, T7, ActionResult> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) {
         return ActionImpl(urlHelper, action, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
      }

      public static string Action<T1, T2, T3, T4, T5, T6, T7, T8>(this UrlHelper urlHelper, Func<T1, T2, T3, T4, T5, T6, T7, T8, ActionResult> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8) {
         return ActionImpl(urlHelper, action, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
      }

      public static string Action<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this UrlHelper urlHelper, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, ActionResult> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9) {
         return ActionImpl(urlHelper, action, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
      }

      public static string Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this UrlHelper urlHelper, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, ActionResult> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10) {
         return ActionImpl(urlHelper, action, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
      }

      public static string Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this UrlHelper urlHelper, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, ActionResult> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11) {
         return ActionImpl(urlHelper, action, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
      }

      public static string Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this UrlHelper urlHelper, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, ActionResult> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12) {
         return ActionImpl(urlHelper, action, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
      }

      public static string Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this UrlHelper urlHelper, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, ActionResult> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13) {
         return ActionImpl(urlHelper, action, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
      }

      public static string Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this UrlHelper urlHelper, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, ActionResult> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14) {
         return ActionImpl(urlHelper, action, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
      }

      public static string Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this UrlHelper urlHelper, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, ActionResult> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15) {
         return ActionImpl(urlHelper, action, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
      }

      public static string Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this UrlHelper urlHelper, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, ActionResult> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16) {
         return ActionImpl(urlHelper, action, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
      }

      static string ActionImpl(this UrlHelper urlHelper, Delegate action, params object[] args) {

         RouteValueDictionary values = null;

         if (args != null
            && args.Length > 0) {

            values = new RouteValueDictionary();

            var parameters = action.Method.GetParameters();

            for (int i = 0; i < parameters.Length; i++)
               values[parameters[i].Name] = args[i]; 
         }

         string actionName = actionNames.GetOrAdd(action.Method, m => {
            
            ActionNameAttribute attr = m
               .GetCustomAttributes(typeof(ActionNameAttribute), inherit: true)
               .Cast<ActionNameAttribute>()
               .SingleOrDefault();

            return (attr != null) ?
               attr.Name
               : m.Name;
         });

         return urlHelper.Action(actionName, values);
      }
   }
}