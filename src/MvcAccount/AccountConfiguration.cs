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
using System.Diagnostics.CodeAnalysis;

namespace MvcAccount {
   
   /// <summary>
   /// Holds settings that customize the behavior of MvcAccount.
   /// </summary>
   public class AccountConfiguration {

      static readonly AccountConfiguration _Instance = new AccountConfiguration();

      Func<AccountRepository> _AccountRepositoryResolver;
      Func<PasswordService> _PasswordServiceResolver;
      Func<FormsAuthenticationService> _FormsAuthenticationServiceResolver;

      const string requiredDependencyMessage = 
         "You must set MvcAccount.AccountConfiguration.Instance.{0}. " +
         "If you are using a dependency injection container you can set MvcAccount.AccountConfiguration.Instance.DependencyResolver instead.";

      /// <summary>
      /// The <see cref="AccountConfiguration"/> instance.
      /// </summary>
      public static AccountConfiguration Instance {
         get { return _Instance; }
      }

      /// <summary>
      /// A delegate that returns the <see cref="AccountRepository"/> implementation for
      /// this application. This setting is optional if using controller dependency injection,
      /// but required when using <see cref="AccountMembershipProvider"/>.
      /// </summary>
      public Func<AccountRepository> AccountRepositoryResolver {
         get {
            if (_AccountRepositoryResolver == null && DependencyResolver != null) 
               _AccountRepositoryResolver = () => (AccountRepository)DependencyResolver(typeof(AccountRepository));
            return _AccountRepositoryResolver;
         }
         set {
            _AccountRepositoryResolver = value;
         }
      }

      /// <summary>
      /// A delegate that returns the <see cref="PasswordService"/> implementation for
      /// this application. This setting is optional if using controller dependency injection,
      /// but required when using <see cref="AccountMembershipProvider"/>.
      /// </summary>
      public Func<PasswordService> PasswordServiceResolver {
         get { 
            if (_PasswordServiceResolver == null && DependencyResolver != null) 
               _PasswordServiceResolver = () => (PasswordService)DependencyResolver(typeof(PasswordService));
            return _PasswordServiceResolver;
         }
         set {
            _PasswordServiceResolver = value;
         }
      }

      /// <summary>
      /// A delegate that returns a <see cref="FormsAuthenticationService"/> instance. 
      /// This setting is always optional since <see cref="FormsAuthenticationService"/> is
      /// a concrete type, but can be used to provide a specialized implementation.
      /// </summary>
      public Func<FormsAuthenticationService> FormsAuthenticationServiceResolver {
         get {
            if (_FormsAuthenticationServiceResolver == null) {
               if (DependencyResolver != null)
                  _FormsAuthenticationServiceResolver = () => (FormsAuthenticationService)DependencyResolver(typeof(FormsAuthenticationService));
               else
                  _FormsAuthenticationServiceResolver = () => new FormsAuthenticationService();
            }
            return _FormsAuthenticationServiceResolver;
         }
         set {
            _FormsAuthenticationServiceResolver = value;
         }
      }

      /// <summary>
      /// A delegate for resoving dependencies. This setting can be used instead of 
      /// <see cref="AccountRepositoryResolver"/> and <see cref="PasswordServiceResolver"/>.
      /// </summary>
      public Func<Type, object> DependencyResolver { get; set; }

      /// <summary>
      /// True to send email with link to verify the email address. The default is true.
      /// </summary>
      public bool EnableEmailVerification { get; set; }

      /// <summary>
      /// True to enable user when email is verified. The default is true.
      /// </summary>
      public bool EmailVerificationEnablesUser { get; set; }

      /// <summary>
      /// Max. number of consecutive invalid sign in attempts. The default is 5.
      /// </summary>
      public int MaxInvalidSignInAttempts { get; set; }

      /// <summary>
      /// True to disable user if <see cref="MaxInvalidSignInAttempts"/> is exceeded.
      /// User must be manually enabled by an administrator. The default is false.
      /// </summary>
      public bool DisableOnMaxInvalidSignInAttempts { get; set; }

      /// <summary>
      /// The amount of time that must pass before a new sign in attempt, if user exceeded
      /// the <see cref="MaxInvalidSignInAttempts"/>.
      /// Not used if <see cref="DisableOnMaxInvalidSignInAttempts"/> is true.
      /// The default is 10 minutes.
      /// </summary>
      public TimeSpan SignInAttemptWindow { get; set; }

      /// <summary>
      /// Min. length required for passwords. The default is 6.
      /// </summary>
      public int MinPasswordLength { get; set; }

      /// <summary>
      /// Max. length allowed for passwords. The default is 16.
      /// </summary>
      public int MaxPasswordLength { get; set; }

      /// <summary>
      /// The kind of <see cref="DateTime"/> to use. The default is <see cref="System.DateTimeKind.Local"/>.
      /// </summary>
      public DateTimeKind DateTimeKind { get; set; }

      /// <summary>
      /// Specifies the time after which persistent authentication cookies expire.
      /// The default is 7 days.
      /// </summary>
      /// <remarks>
      /// ASP.NET uses the same expiration for both persistent and non-persistent authentication cookies.
      /// This settings allows you to increase the expiration of persistent authentication cookies.
      /// </remarks>
      public TimeSpan PersistentCookieTimeout { get; set; }

      /// <summary>
      /// The amount of time a password reset verification link is usable. The default is 24 hours.
      /// </summary>
      public TimeSpan PasswordResetTicketExpiration { get; set; }

      /// <summary>
      /// The amount of time a email change verification link is usable. The default is 24 hours.
      /// </summary>
      public TimeSpan EmailChangeTicketExpiration { get; set; }

      /// <summary>
      /// The name of the website, used in verification and notification emails.
      /// If null the <see cref="Uri.Host"/> of the current HTTP request URL is used.
      /// </summary>
      public string SiteName { get; set; }

      /// <summary>
      /// A resource where users can ask for help (URL, email, telephone, etc.),
      /// used in verification and notification emails.
      /// </summary>
      public string HelpResource { get; set; }

      /// <summary>
      /// The name of the resource file (class key) in App_GlobalResources that contains localized string values.
      /// </summary>
      public string ResourceClassKey { get; set; }

      private AccountConfiguration() {
         Reset();
      }

      /// <summary>
      /// Resets the members of the configuration class to their default values.
      /// </summary>
      public void Reset() {

         this.EnableEmailVerification = true;
         this.EmailVerificationEnablesUser = true;
         this.MaxInvalidSignInAttempts = 5;
         this.DisableOnMaxInvalidSignInAttempts = false;
         this.SignInAttemptWindow = TimeSpan.FromMinutes(10);
         this.MinPasswordLength = 6;
         this.MaxPasswordLength = 16;
         this.DateTimeKind = DateTimeKind.Local;
         this.PersistentCookieTimeout = TimeSpan.FromDays(7);
         this.PasswordResetTicketExpiration = TimeSpan.FromHours(24);
         this.EmailChangeTicketExpiration = TimeSpan.FromHours(24);
         this.SiteName = null;
         this.HelpResource = null;
         this.ResourceClassKey = null;
      }
      
      /// <summary>
      /// Gets the current <see cref="DateTime"/>.
      /// </summary>
      /// <returns>The current <see cref="DateTime"/>, which depends on <see cref="AccountConfiguration.DateTimeKind"/>.</returns>
      /// <seealso cref="AccountConfiguration.DateTimeKind"/>
      [SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate", Justification = "Calling the member twice in succession creates different results.")]
      public DateTime GetNow() {
         
         return (this.DateTimeKind == DateTimeKind.Utc) ?
            DateTime.UtcNow
            : DateTime.Now;
      }

      internal AccountRepository RequireAccountRepository() {

         var resolver = this.AccountRepositoryResolver;

         if (resolver == null)
            throw new InvalidOperationException(requiredDependencyMessage.FormatInvariant("AccountRepositoryResolver"));

         return resolver();
      }

      internal PasswordService RequirePasswordService() {

         var resolver = this.PasswordServiceResolver;

         if (resolver == null)
            throw new InvalidOperationException(requiredDependencyMessage.FormatInvariant("PasswordServiceResolver"));

         return resolver();
      }
   }
}
