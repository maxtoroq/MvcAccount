AccountMembershipProvider Class
===============================
A [MembershipProvider][1] that uses MvcAccount.


Inheritance Hierarchy
---------------------
[System.Object][2]  
  [System.Configuration.Provider.ProviderBase][3]  
    [System.Web.Security.MembershipProvider][1]  
      **MvcAccount.AccountMembershipProvider**  

**Namespace:** [MvcAccount][4]  
**Assembly:** MvcAccount (in MvcAccount.dll)

Syntax
------

```csharp
public class AccountMembershipProvider : MembershipProvider
```

The **AccountMembershipProvider** type exposes the following members.


Constructors
------------

Name                           | Description                                                           
------------------------------ | --------------------------------------------------------------------- 
[AccountMembershipProvider][5] | Initializes a new instance of the **AccountMembershipProvider** class 


Methods
-------

Name                                                               | Description                                                                                                                                                                                 
------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
[ChangePassword][6]                                                | This method always throws a [NotImplementedException][7]. (Overrides [MembershipProvider.ChangePassword(String, String, String)][8].)                                                       
[ChangePasswordQuestionAndAnswer][9]                               | This method always throws a [NotImplementedException][7]. (Overrides [MembershipProvider.ChangePasswordQuestionAndAnswer(String, String, String, String)][10].)                             
[CreateUser][11]                                                   | This method always throws a [NotImplementedException][7]. (Overrides [MembershipProvider.CreateUser(String, String, String, String, String, Boolean, Object, MembershipCreateStatus)][12].) 
[DecryptPassword][13]                                              | Decrypts an encrypted password. (Inherited from [MembershipProvider][1].)                                                                                                                   
[DeleteUser][14]                                                   | This method always throws a [NotImplementedException][7]. (Overrides [MembershipProvider.DeleteUser(String, Boolean)][15].)                                                                 
[EncryptPassword(Byte[])][16]                                      | Encrypts a password. (Inherited from [MembershipProvider][1].)                                                                                                                              
[EncryptPassword(Byte[], MembershipPasswordCompatibilityMode)][17] | Encrypts the specified password using the specified password-compatibility mode. (Inherited from [MembershipProvider][1].)                                                                  
[Equals][18]                                                       | Determines whether the specified [Object][2] is equal to the current [Object][2]. (Inherited from [Object][2].)                                                                             
[Finalize][19]                                                     | Allows an object to try to free resources and perform other cleanup operations before it is reclaimed by garbage collection. (Inherited from [Object][2].)                                  
[FindUsersByEmail][20]                                             | This method always throws a [NotImplementedException][7]. (Overrides [MembershipProvider.FindUsersByEmail(String, Int32, Int32, Int32)][21].)                                               
[FindUsersByName][22]                                              | This method always throws a [NotImplementedException][7]. (Overrides [MembershipProvider.FindUsersByName(String, Int32, Int32, Int32)][23].)                                                
[GetAllUsers][24]                                                  | This method always throws a [NotImplementedException][7]. (Overrides [MembershipProvider.GetAllUsers(Int32, Int32, Int32)][25].)                                                            
[GetHashCode][26]                                                  | Serves as a hash function for a particular type. (Inherited from [Object][2].)                                                                                                              
[GetNumberOfUsersOnline][27]                                       | This method always throws a [NotImplementedException][7]. (Overrides [MembershipProvider.GetNumberOfUsersOnline()][28].)                                                                    
[GetPassword][29]                                                  | This method always throws a [NotImplementedException][7]. (Overrides [MembershipProvider.GetPassword(String, String)][30].)                                                                 
[GetType][31]                                                      | Gets the [Type][32] of the current instance. (Inherited from [Object][2].)                                                                                                                  
[GetUser(Object, Boolean)][33]                                     | Gets user information from the data source based on the unique identifier for the user. (Overrides [MembershipProvider.GetUser(Object, Boolean)][34].)                                      
[GetUser(String, Boolean)][35]                                     | Gets information from the data source for a user. (Overrides [MembershipProvider.GetUser(String, Boolean)][36].)                                                                            
[GetUserNameByEmail][37]                                           | This method always throws a [NotImplementedException][7]. (Overrides [MembershipProvider.GetUserNameByEmail(String)][38].)                                                                  
[Initialize][39]                                                   | Initializes the provider. (Inherited from [ProviderBase][3].)                                                                                                                               
[MemberwiseClone][40]                                              | Creates a shallow copy of the current [Object][2]. (Inherited from [Object][2].)                                                                                                            
[OnValidatingPassword][41]                                         | Raises the [ValidatingPassword][42] event if an event handler has been defined. (Inherited from [MembershipProvider][1].)                                                                   
[ResetPassword][43]                                                | This method always throws a [NotImplementedException][7]. (Overrides [MembershipProvider.ResetPassword(String, String)][44].)                                                               
[ToString][45]                                                     | Returns a string that represents the current object. (Inherited from [Object][2].)                                                                                                          
[UnlockUser][46]                                                   | This method always throws a [NotImplementedException][7]. (Overrides [MembershipProvider.UnlockUser(String)][47].)                                                                          
[UpdateUser][48]                                                   | This method always throws a [NotImplementedException][7]. (Overrides [MembershipProvider.UpdateUser(MembershipUser)][49].)                                                                  
[ValidateUser][50]                                                 | Verifies that the specified user name and password exist in the data source. (Overrides [MembershipProvider.ValidateUser(String, String)][51].)                                             


Properties
----------

Name                                       | Description                                                                                                                                         
------------------------------------------ | --------------------------------------------------------------------------------------------------------------------------------------------------- 
[ApplicationName][52]                      | The name of the application using the custom membership provider. (Overrides [MembershipProvider.ApplicationName][53].)                             
[Description][54]                          | Gets a brief, friendly description suitable for display in administrative tools or other user interfaces (UIs). (Inherited from [ProviderBase][3].) 
[EnablePasswordReset][55]                  | This property always returns false. (Overrides [MembershipProvider.EnablePasswordReset][56].)                                                       
[EnablePasswordRetrieval][57]              | This property always returns false. (Overrides [MembershipProvider.EnablePasswordRetrieval][58].)                                                   
[MaxInvalidPasswordAttempts][59]           | This property always returns 0. (Overrides [MembershipProvider.MaxInvalidPasswordAttempts][60].)                                                    
[MinRequiredNonAlphanumericCharacters][61] | This property always returns 0. (Overrides [MembershipProvider.MinRequiredNonAlphanumericCharacters][62].)                                          
[MinRequiredPasswordLength][63]            | This property always returns 0. (Overrides [MembershipProvider.MinRequiredPasswordLength][64].)                                                     
[Name][65]                                 | Gets the friendly name used to refer to the provider during configuration. (Inherited from [ProviderBase][3].)                                      
[PasswordAttemptWindow][66]                | This property always returns 0. (Overrides [MembershipProvider.PasswordAttemptWindow][67].)                                                         
[PasswordFormat][68]                       | This property always returns [Clear][69]. (Overrides [MembershipProvider.PasswordFormat][70].)                                                      
[PasswordStrengthRegularExpression][71]    | This property always returns null. (Overrides [MembershipProvider.PasswordStrengthRegularExpression][72].)                                          
[RequiresQuestionAndAnswer][73]            | This property always returns false. (Overrides [MembershipProvider.RequiresQuestionAndAnswer][74].)                                                 
[RequiresUniqueEmail][75]                  | This property always return false. (Overrides [MembershipProvider.RequiresUniqueEmail][76].)                                                        


Events
------

Name                     | Description                                                                                                             
------------------------ | ----------------------------------------------------------------------------------------------------------------------- 
[ValidatingPassword][42] | Occurs when a user is created, a password is changed, or a password is reset. (Inherited from [MembershipProvider][1].) 


Remarks
-------
 The only methods implemented are [GetUser(String, Boolean)][35], [GetUser(Object, Boolean)][33] and [ValidateUser(String, String)][50]. All other methods throw a [NotImplementedException][7]. 

See Also
--------
[MvcAccount Namespace][4]  

[1]: http://msdn2.microsoft.com/en-us/library/sfka4yf8
[2]: http://msdn2.microsoft.com/en-us/library/e5kfa45b
[3]: http://msdn2.microsoft.com/en-us/library/5x9wbz2y
[4]: ../README.md
[5]: _ctor.md
[6]: ChangePassword.md
[7]: http://msdn2.microsoft.com/en-us/library/6byb74h9
[8]: http://msdn2.microsoft.com/en-us/library/bdt44e91
[9]: ChangePasswordQuestionAndAnswer.md
[10]: http://msdn2.microsoft.com/en-us/library/hdwf5syf
[11]: CreateUser.md
[12]: http://msdn2.microsoft.com/en-us/library/ms152040
[13]: http://msdn2.microsoft.com/en-us/library/ms152041
[14]: DeleteUser.md
[15]: http://msdn2.microsoft.com/en-us/library/9y0e13b2
[16]: http://msdn2.microsoft.com/en-us/library/ms152042
[17]: http://msdn2.microsoft.com/en-us/library/dd384926
[18]: http://msdn2.microsoft.com/en-us/library/bsc2ak47
[19]: http://msdn2.microsoft.com/en-us/library/4k87zsw7
[20]: FindUsersByEmail.md
[21]: http://msdn2.microsoft.com/en-us/library/96e54ch9
[22]: FindUsersByName.md
[23]: http://msdn2.microsoft.com/en-us/library/89e8kx21
[24]: GetAllUsers.md
[25]: http://msdn2.microsoft.com/en-us/library/eab6t4cc
[26]: http://msdn2.microsoft.com/en-us/library/zdee4b3y
[27]: GetNumberOfUsersOnline.md
[28]: http://msdn2.microsoft.com/en-us/library/5z4s4edy
[29]: GetPassword.md
[30]: http://msdn2.microsoft.com/en-us/library/67dkyyt9
[31]: http://msdn2.microsoft.com/en-us/library/dfwy45w9
[32]: http://msdn2.microsoft.com/en-us/library/42892f65
[33]: GetUser.md
[34]: http://msdn2.microsoft.com/en-us/library/ms152044
[35]: GetUser_1.md
[36]: http://msdn2.microsoft.com/en-us/library/bwzxkby7
[37]: GetUserNameByEmail.md
[38]: http://msdn2.microsoft.com/en-us/library/57hsxfsd
[39]: http://msdn2.microsoft.com/en-us/library/h5sw72ew
[40]: http://msdn2.microsoft.com/en-us/library/57ctke0a
[41]: http://msdn2.microsoft.com/en-us/library/ms152046
[42]: http://msdn2.microsoft.com/en-us/library/ms152058
[43]: ResetPassword.md
[44]: http://msdn2.microsoft.com/en-us/library/xfk80t55
[45]: http://msdn2.microsoft.com/en-us/library/7bxwbwt2
[46]: UnlockUser.md
[47]: http://msdn2.microsoft.com/en-us/library/ms152047
[48]: UpdateUser.md
[49]: http://msdn2.microsoft.com/en-us/library/3b6421tx
[50]: ValidateUser.md
[51]: http://msdn2.microsoft.com/en-us/library/05d03b82
[52]: ApplicationName.md
[53]: http://msdn2.microsoft.com/en-us/library/tb1kfc28
[54]: http://msdn2.microsoft.com/en-us/library/ms135292
[55]: EnablePasswordReset.md
[56]: http://msdn2.microsoft.com/en-us/library/yc26ahtx
[57]: EnablePasswordRetrieval.md
[58]: http://msdn2.microsoft.com/en-us/library/cf2xwfk2
[59]: MaxInvalidPasswordAttempts.md
[60]: http://msdn2.microsoft.com/en-us/library/ms152049
[61]: MinRequiredNonAlphanumericCharacters.md
[62]: http://msdn2.microsoft.com/en-us/library/ms152050
[63]: MinRequiredPasswordLength.md
[64]: http://msdn2.microsoft.com/en-us/library/ms152051
[65]: http://msdn2.microsoft.com/en-us/library/7ahd1sxb
[66]: PasswordAttemptWindow.md
[67]: http://msdn2.microsoft.com/en-us/library/ms152052
[68]: PasswordFormat.md
[69]: http://msdn2.microsoft.com/en-us/library/fx3ae0xh
[70]: http://msdn2.microsoft.com/en-us/library/ms152053
[71]: PasswordStrengthRegularExpression.md
[72]: http://msdn2.microsoft.com/en-us/library/ms152054
[73]: RequiresQuestionAndAnswer.md
[74]: http://msdn2.microsoft.com/en-us/library/yda8bsea
[75]: RequiresUniqueEmail.md
[76]: http://msdn2.microsoft.com/en-us/library/ms152055