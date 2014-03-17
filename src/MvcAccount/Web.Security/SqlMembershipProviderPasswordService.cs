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
using System.Collections.Specialized;
using System.Reflection;
using System.Web.Security;

namespace MvcAccount.Web.Security {
   
   /// <summary>
   /// A <see cref="PasswordService"/> that reuses the password encryption implementations
   /// provided by <see cref="SqlMembershipProvider"/>.
   /// </summary>
   public class SqlMembershipProviderPasswordService : PasswordService {

      static readonly Type _type = typeof(SqlMembershipProvider);

      static readonly Func<SqlMembershipProvider, string> _GenerateSalt =
         (Func<SqlMembershipProvider, string>)
            Delegate.CreateDelegate(
               typeof(Func<SqlMembershipProvider, string>),
               _type.GetMethod("GenerateSalt", BindingFlags.Instance | BindingFlags.NonPublic, null, Type.EmptyTypes, null),
               true
            );

      static readonly Func<SqlMembershipProvider, string, int, string, string> _EncodePassword =
         (Func<SqlMembershipProvider, string, int, string, string>)
            Delegate.CreateDelegate(
               typeof(Func<SqlMembershipProvider, string, int, string, string>),
               _type.GetMethod("EncodePassword", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[3] { typeof(string), typeof(int), typeof(string) }, null),
               true
            );

      readonly MembershipPasswordFormat passwordFormat;
      readonly SqlMembershipProvider provider;


      /// <summary>
      /// Initializes a new <see cref="SqlMembershipProviderPasswordService"/> using the provided password format.
      /// </summary>
      /// <param name="passwordFormat">The password encryption method.</param>
      public SqlMembershipProviderPasswordService(MembershipPasswordFormat passwordFormat) {
         
         this.passwordFormat = passwordFormat;
         this.provider = new SqlMembershipProvider();

         var config = new NameValueCollection { 
            { "minRequiredPasswordLength", "1" },
            { "minRequiredNonalphanumericCharacters", "0" },
            { "passwordFormat", passwordFormat.ToString() },
            { "passwordCompatMode", "Framework40" },
            { "connectionString" , "__foo__" }
         };

         this.provider.Initialize(null, config);
      }

      /// <summary>
      /// Converts the <paramref name="clearTextPassword"/> to one that is suitable for storage.
      /// </summary>
      /// <param name="clearTextPassword">The password in clear text.</param>
      /// <returns>The password suitable for storage.</returns>
      public override string ProcessPasswordForStorage(string clearTextPassword) {

         if (this.passwordFormat == MembershipPasswordFormat.Clear) {
            return clearTextPassword;
         }

         string salt = GenerateSalt();
         return String.Concat(salt, "$", EncodePassword(clearTextPassword, (int)this.passwordFormat, salt));
      }

      /// <summary>
      /// Compares a password provided by a user to one that is stored.
      /// </summary>
      /// <param name="clearTextPassword">The password in clear text provided by a user.</param>
      /// <param name="storedPassword">The stored password.</param>
      /// <returns>true if the passwords are equal; otherwise false.</returns>
      public override bool PasswordEquals(string clearTextPassword, string storedPassword) {

         string pass, salt;
         ParseStoredPassword(storedPassword, out salt, out pass);

         string encoded = EncodePassword(clearTextPassword, (int)this.passwordFormat, salt);

         return String.Equals(encoded, pass);
      }

      void ParseStoredPassword(string storedPassword, out string salt, out string pass) {

         if (storedPassword == null) throw new ArgumentNullException("storedPassword");

         if (this.passwordFormat == MembershipPasswordFormat.Clear) {
            
            pass = storedPassword;
            salt = null;
         
         } else {
            
            string[] parts = storedPassword.Split('$');
            pass = parts[1];
            salt = parts[0];
         }
      }

      string GenerateSalt() {
         return _GenerateSalt(this.provider);
      }

      string EncodePassword(string pass, int passwordFormat, string salt) {
         return _EncodePassword(this.provider, pass, passwordFormat, salt);
      }
   }
}
