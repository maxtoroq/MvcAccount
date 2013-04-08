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
using System.Reflection;
using System.Web;
using System.Web.Security;
using MvcAccount.Password;

namespace MvcAccount {
   
   /// <remarks>
   /// The only methods implemented are <see cref="GetUser(string, bool)"/>, <see cref="GetUser(object, bool)"/>
   /// and <see cref="ValidateUser(string, string)"/>. All other methods throw a <see cref="NotImplementedException"/>.
   /// </remarks>
   public class AccountMembershipProvider : MembershipProvider {

      [ThreadStatic]
      static AccountConfiguration _Configuration;

      static AccountConfiguration Configuration {
         get {
            return _Configuration
               ?? (_Configuration = AccountConfiguration.Current());
         }
      }

      /// <summary>
      /// The name of the application using the custom membership provider.
      /// </summary>
      public override string ApplicationName { get; set; }

      /// <summary>
      /// This property always returns false.
      /// </summary>
      public override bool EnablePasswordReset { get { return false; } }

      /// <summary>
      /// This property always returns false.
      /// </summary>
      public override bool EnablePasswordRetrieval { get { return false; } }

      /// <summary>
      /// This property always returns 0.
      /// </summary>
      public override int MaxInvalidPasswordAttempts { get { return 0; } }

      /// <summary>
      /// This property always returns 0.
      /// </summary>
      public override int MinRequiredNonAlphanumericCharacters { get { return 0; } }

      /// <summary>
      /// This property always returns 0.
      /// </summary>
      public override int MinRequiredPasswordLength { get { return 0; } }

      /// <summary>
      /// This property always returns 0.
      /// </summary>
      public override int PasswordAttemptWindow { get { return 0; } }

      /// <summary>
      /// This property always returns <see cref="MembershipPasswordFormat.Clear"/>.
      /// </summary>
      public override MembershipPasswordFormat PasswordFormat { get { return MembershipPasswordFormat.Clear; } }
      
      /// <summary>
      /// This property always returns null.
      /// </summary>
      public override string PasswordStrengthRegularExpression { get { return null; } }

      /// <summary>
      /// This property always returns false.
      /// </summary>
      public override bool RequiresQuestionAndAnswer { get { return false; } }

      /// <summary>
      /// This property always return false.
      /// </summary>
      public override bool RequiresUniqueEmail { get { return false; } }

      static AccountRepositoryWrapper GetRepositoryInstance() {
         return Configuration.RequireDependency(default(AccountRepositoryWrapper));
      }

      static MembershipUser CreateMembershipUser(string providerName, UserWrapper user) {
         
         return new MembershipUser(
            providerName: providerName,
            name: user.Username,
            providerUserKey: user.Id,
            email: user.Email,
            passwordQuestion: null,
            comment: null,
            isApproved: true,
            isLockedOut: !user.Disabled,
            creationDate: default(DateTime),
            lastLoginDate: user.LastSignIn.GetValueOrDefault(),
            lastActivityDate: default(DateTime),
            lastPasswordChangedDate: default(DateTime),
            lastLockoutDate: default(DateTime)
         );
      }

      /// <summary>
      /// Gets information from the data source for a user.
      /// </summary>
      /// <param name="username">The name of the user to get information for.</param>
      /// <param name="userIsOnline">This parameter is ignored.</param>
      /// <returns>
      /// A <see cref="MembershipUser"/> object populated with the specified
      /// user's information from the data source.
      /// </returns>
      public override MembershipUser GetUser(string username, bool userIsOnline) {

         var repo = GetRepositoryInstance();

         UserWrapper user = repo.FindUserByName(username);

         if (user == null)
            return null;

         return CreateMembershipUser(this.Name, user);
      }

      /// <summary>
      /// Gets user information from the data source based on the unique identifier
      /// for the user.
      /// </summary>
      /// <param name="providerUserKey">The unique identifier for the user to get information for.</param>
      /// <param name="userIsOnline">This parameter is ignored.</param>
      /// <returns>
      /// A <see cref="MembershipUser"/> object populated with the specified
      /// user's information from the data source.
      /// </returns>
      public override MembershipUser GetUser(object providerUserKey, bool userIsOnline) {

         var repo = GetRepositoryInstance();

         UserWrapper user = repo.FindUserById(providerUserKey);

         if (user == null)
            return null;

         return CreateMembershipUser(this.Name, user);
      }

      /// <summary>
      /// Verifies that the specified user name and password exist in the data source.
      /// </summary>
      /// <param name="username">The name of the user to validate.</param>
      /// <param name="password">The password for the specified user.</param>
      /// <returns>true if the specified username and password are valid; otherwise, false.</returns>
      public override bool ValidateUser(string username, string password) {

         AccountConfiguration config = Configuration;

         var controller = new Auth.AuthController(
            config.RequireDependency(default(AccountRepository)),
            config.RequireDependency(default(PasswordService))
         );

         controller.Configuration = config;

         return controller.ValidateUser(username, password);
      }

      /// <summary>
      /// This method always throws a <see cref="NotImplementedException"/>.
      /// </summary>
      /// <param name="username">The user to update the password for.</param>
      /// <param name="oldPassword">The current password for the specified user.</param>
      /// <param name="newPassword">The new password for the specified user.</param>
      /// <returns>true if the password was updated successfully; otherwise, false.</returns>
      public override bool ChangePassword(string username, string oldPassword, string newPassword) {
         throw new NotImplementedException("ChangePassword not implemented.");
      }

      /// <summary>
      /// This method always throws a <see cref="NotImplementedException"/>.
      /// </summary>
      /// <param name="username">The user to change the password question and answer for.</param>
      /// <param name="password">The password for the specified user.</param>
      /// <param name="newPasswordQuestion">The new password question for the specified user.</param>
      /// <param name="newPasswordAnswer">The new password answer for the specified user.</param>
      /// <returns>true if the password question and answer are updated successfully; otherwise, false.</returns>
      public override bool ChangePasswordQuestionAndAnswer(string username, string password, string newPasswordQuestion, string newPasswordAnswer) {
         throw new NotImplementedException("ChangePasswordQuestionAndAnswer not implemented.");
      }

      /// <summary>
      /// This method always throws a <see cref="NotImplementedException"/>.
      /// </summary>
      /// <param name="username">The user name for the new user.</param>
      /// <param name="password">The password for the new user.</param>
      /// <param name="email">The e-mail address for the new user.</param>
      /// <param name="passwordQuestion">The password question for the new user.</param>
      /// <param name="passwordAnswer">The password answer for the new user</param>
      /// <param name="isApproved">Whether or not the new user is approved to be validated.</param>
      /// <param name="providerUserKey">The unique identifier from the membership data source for the user.</param>
      /// <param name="status">
      /// A <see cref="MembershipCreateStatus"/> enumeration value indicating
      /// whether the user was created successfully.
      /// </param>
      /// <returns>
      /// A <see cref="MembershipUser"/> object populated with the information
      /// for the newly created user.
      /// </returns>
      public override MembershipUser CreateUser(string username, string password, string email, string passwordQuestion, string passwordAnswer, bool isApproved, object providerUserKey, out MembershipCreateStatus status) {
         throw new NotImplementedException("CreateUser not implemented.");
      }

      /// <summary>
      /// This method always throws a <see cref="NotImplementedException"/>.
      /// </summary>
      /// <param name="username">The name of the user to delete.</param>
      /// <param name="deleteAllRelatedData">
      /// true to delete data related to the user from the database; false to leave
      /// data related to the user in the database.
      /// </param>
      /// <returns>true if the user was successfully deleted; otherwise, false.</returns>
      public override bool DeleteUser(string username, bool deleteAllRelatedData) {
         throw new NotImplementedException("DeleteUser not implemented.");
      }

      /// <summary>
      /// This method always throws a <see cref="NotImplementedException"/>.
      /// </summary>
      /// <param name="emailToMatch">The e-mail address to search for.</param>
      /// <param name="pageIndex">The index of the page of results to return. pageIndex is zero-based.</param>
      /// <param name="pageSize">The size of the page of results to return.</param>
      /// <param name="totalRecords">The total number of matched users.</param>
      /// <returns>
      /// A <see cref="MembershipUserCollection"/> collection that contains a
      /// page of pageSize <see cref="MembershipUser"/> objects beginning at the
      /// page specified by pageIndex.
      /// </returns>
      public override MembershipUserCollection FindUsersByEmail(string emailToMatch, int pageIndex, int pageSize, out int totalRecords) {
         throw new NotImplementedException("FindUsersByEmail not implemented.");
      }

      /// <summary>
      /// This method always throws a <see cref="NotImplementedException"/>.
      /// </summary>
      /// <param name="usernameToMatch">The user name to search for.</param>
      /// <param name="pageIndex">The index of the page of results to return. pageIndex is zero-based.</param>
      /// <param name="pageSize">The size of the page of results to return.</param>
      /// <param name="totalRecords">The total number of matched users.</param>
      /// <returns>
      /// A <see cref="MembershipUserCollection"/> collection that contains a
      /// page of pageSize <see cref="MembershipUser"/> objects beginning at the
      /// page specified by pageIndex.
      /// </returns>
      public override MembershipUserCollection FindUsersByName(string usernameToMatch, int pageIndex, int pageSize, out int totalRecords) {
         throw new NotImplementedException("FindUsersByName not implemented.");
      }

      /// <summary>
      /// This method always throws a <see cref="NotImplementedException"/>.
      /// </summary>
      /// <param name="pageIndex">The index of the page of results to return. pageIndex is zero-based.</param>
      /// <param name="pageSize">The size of the page of results to return.</param>
      /// <param name="totalRecords">The total number of matched users.</param>
      /// <returns>
      /// A <see cref="MembershipUserCollection"/> collection that contains a
      /// page of pageSize <see cref="MembershipUser"/> objects beginning at the
      /// page specified by pageIndex.
      /// </returns>
      public override MembershipUserCollection GetAllUsers(int pageIndex, int pageSize, out int totalRecords) {
         throw new NotImplementedException("GetAllUsers not implemented.");
      }

      /// <summary>
      /// This method always throws a <see cref="NotImplementedException"/>.
      /// </summary>
      /// <returns>The number of users currently accessing the application.</returns>
      public override int GetNumberOfUsersOnline() {
         throw new NotImplementedException("GetNumberOfUsersOnline not implemented.");
      }

      /// <summary>
      /// This method always throws a <see cref="NotImplementedException"/>.
      /// </summary>
      /// <param name="username">The user to retrieve the password for.</param>
      /// <param name="answer">The password answer for the user.</param>
      /// <returns>The password for the specified user name.</returns>
      public override string GetPassword(string username, string answer) {
         throw new NotImplementedException("GetPassword not implemented.");
      }

      /// <summary>
      /// This method always throws a <see cref="NotImplementedException"/>.
      /// </summary>
      /// <param name="email">The e-mail address to search for.</param>
      /// <returns>
      /// The user name associated with the specified e-mail address. If no match is
      /// found, return null.
      /// </returns>
      public override string GetUserNameByEmail(string email) {
         throw new NotImplementedException("GetUserNameByEmail not implemented.");
      }

      /// <summary>
      /// This method always throws a <see cref="NotImplementedException"/>.
      /// </summary>
      /// <param name="username">The user to reset the password for.</param>
      /// <param name="answer">The password answer for the specified user.</param>
      /// <returns>The new password for the specified user.</returns>
      public override string ResetPassword(string username, string answer) {
         throw new NotImplementedException("ResetPassword not implemented.");
      }

      /// <summary>
      /// This method always throws a <see cref="NotImplementedException"/>.
      /// </summary>
      /// <param name="userName">The user whose lock status you want to clear.</param>
      /// <returns>true if the user was successfully unlocked; otherwise, false.</returns>
      public override bool UnlockUser(string userName) {
         throw new NotImplementedException("UnlockUser not implemented.");
      }

      /// <summary>
      /// This method always throws a <see cref="NotImplementedException"/>.
      /// </summary>
      /// <param name="user">
      /// A <see cref="MembershipUser"/> object that represents the user to update
      /// and the updated information for the user.
      /// </param>
      public override void UpdateUser(MembershipUser user) {
         throw new NotImplementedException("UpdateUser not implemented.");
      }
   }
}
