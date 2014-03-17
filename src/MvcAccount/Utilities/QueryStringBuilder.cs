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
using System.Collections.Specialized;
using System.Linq;
using System.Web;
using System.Text;

namespace MvcAccount {
   
   /// <summary>
   /// Provides a set of static (Shared in Visual Basic) methods to convert a <see cref="NameValueCollection"/> 
   /// to a <see cref="String"/> using the application/x-www-form-urlencoded format.
   /// </summary>
   /// <remarks>
   /// This class complements <see cref="UriBuilder"/> which does not provide a way to build the
   /// query portion of the URI. It's also useful if you need to send the query string in the
   /// body of an HTTP request.
   /// </remarks>
   static class QueryStringBuilder {

      /// <summary>
      /// Converts the current <see cref="NameValueCollection"/> to a <see cref="String"/> using the
      /// application/x-www-form-urlencoded format.
      /// </summary>
      /// <param name="qs">The <see cref="NameValueCollection"/> to convert.</param>
      /// <returns>A <see cref="String"/> in application/x-www-form-urlencoded format.</returns>
      public static string ToQueryString(this NameValueCollection qs) {
         return ToQueryString(qs, includeDelimiter: false);
      }

      /// <summary>
      /// Converts the current <see cref="NameValueCollection"/> to a <see cref="String"/> using the
      /// application/x-www-form-urlencoded format.
      /// </summary>
      /// <param name="qs">The <see cref="NameValueCollection"/> to convert.</param>
      /// <param name="includeDelimiter">true to include the leading '?' delimiter when the resulting string length is greater than zero; otherwise false.</param>
      /// <returns>A <see cref="String"/> in application/x-www-form-urlencoded format.</returns>
      public static string ToQueryString(this NameValueCollection qs, bool includeDelimiter) {

         var sb = new StringBuilder();

         for (int i = 0; i < qs.AllKeys.Length; i++) {
            
            string key = qs.AllKeys[i];
            string[] values = qs.GetValues(key);

            if (values != null
               && values.Length > 0) {

               string encodedKey = HttpUtility.UrlEncode(key);

               for (int j = 0; j < values.Length; j++) {

                  if (sb.Length > 0) {
                     sb.Append('&');
                  }

                  sb.Append(encodedKey)
                     .Append('=')
                     .Append(HttpUtility.UrlEncode(values[j]));
               } 
            }
         }

         if (includeDelimiter
            && sb.Length > 0) {

            sb.Insert(0, '?');
         }

         return sb.ToString();
      }
   }
}
