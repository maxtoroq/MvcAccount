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
using System.Web.Security;
using System.Collections.Specialized;
using System.Web;
using System.Web.Mvc;
using System.Globalization;

namespace MvcAccount {
   
   class VerificationData {

      public object UserId { get; private set; }
      public string UserData { get; private set; }

      public static VerificationData Parse(string cipher) {

         if (!cipher.HasValue())
            return null;

         byte[] ticketBytes;

         try {
            ticketBytes = MachineKey.Decode(cipher, MachineKeyProtection.Encryption);
         } catch (ArgumentException) {
            return null;
         }

         string ticketClear = Encoding.Unicode.GetString(ticketBytes);
         NameValueCollection parameters = HttpUtility.ParseQueryString(ticketClear);

         return new VerificationData(parameters["uid"], parameters["data"]);
      }

      internal VerificationData(object userId, string userData) {

         this.UserId = userId;
         this.UserData = userData;
      }

      internal Uri GetVerificationUrl(string action, Controller controller) {

         var parameters = new NameValueCollection { 
            { "uid", this.UserId.ToStringInvariant() },
            { "data", this.UserData },
            { "rnd", new Random(0).Next(100).ToStringInvariant() }
         };

         byte[] ticketBytes = Encoding.Unicode.GetBytes(parameters.ToQueryString());
         string ticketCipher = MachineKey.Encode(ticketBytes, MachineKeyProtection.Encryption);

         return new Uri(controller.Request.Url, controller.Url.Action(action, new { id = ticketCipher }));
      }
   }
}
