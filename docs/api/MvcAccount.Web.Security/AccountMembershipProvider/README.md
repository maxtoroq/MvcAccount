AccountMembershipProvider Class
===============================
A [MembershipProvider][1] for MvcAccount.


Inheritance Hierarchy
---------------------
[System.Object][2]  
  [System.Configuration.Provider.ProviderBase][3]  
    [System.Web.Security.MembershipProvider][1]  
      **MvcAccount.Web.Security.AccountMembershipProvider**  

**Namespace:** [MvcAccount.Web.Security][4]  
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

Name                                 | Description                                                                                                                                                                                 
------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
[ChangePassword][6]                  | This method always throws a [NotImplementedException][7]. (Overrides [MembershipProvider.ChangePassword(String, String, String)][8].)                                                       
[ChangePasswordQuestionAndAnswer][9] | This method always throws a [NotImplementedException][7]. (Overrides [MembershipProvider.ChangePasswordQuestionAndAnswer(String, String, String, String)][10].)                             
[CreateUser][11]                     | This method always throws a [NotImplementedException][7]. (Overrides [MembershipProvider.CreateUser(String, String, String, String, String, Boolean, Object, MembershipCreateStatus)][12].) 
[DeleteUser][13]                     | This method always throws a [NotImplementedException][7]. (Overrides [MembershipProvider.DeleteUser(String, Boolean)][14].)                                                                 
[FindUsersByEmail][15]               | This method always throws a [NotImplementedException][7]. (Overrides [MembershipProvider.FindUsersByEmail(String, Int32, Int32, Int32)][16].)                                               
[FindUsersByName][17]                | This method always throws a [NotImplementedException][7]. (Overrides [MembershipProvider.FindUsersByName(String, Int32, Int32, Int32)][18].)                                                
[GetAllUsers][19]                    | This method always throws a [NotImplementedException][7]. (Overrides [MembershipProvider.GetAllUsers(Int32, Int32, Int32)][20].)                                                            
[GetNumberOfUsersOnline][21]         | This method always throws a [NotImplementedException][7]. (Overrides [MembershipProvider.GetNumberOfUsersOnline()][22].)                                                                    
[GetPassword][23]                    | This method always throws a [NotImplementedException][7]. (Overrides [MembershipProvider.GetPassword(String, String)][24].)                                                                 
[GetUser(Object, Boolean)][25]       | Gets user information from the data source based on the unique identifier for the user. (Overrides [MembershipProvider.GetUser(Object, Boolean)][26].)                                      
[GetUser(String, Boolean)][27]       | Gets information from the data source for a user. (Overrides [MembershipProvider.GetUser(String, Boolean)][28].)                                                                            
[GetUserNameByEmail][29]             | This method always throws a [NotImplementedException][7]. (Overrides [MembershipProvider.GetUserNameByEmail(String)][30].)                                                                  
[ResetPassword][31]                  | This method always throws a [NotImplementedException][7]. (Overrides [MembershipProvider.ResetPassword(String, String)][32].)                                                               
[UnlockUser][33]                     | This method always throws a [NotImplementedException][7]. (Overrides [MembershipProvider.UnlockUser(String)][34].)                                                                          
[UpdateUser][35]                     | This method always throws a [NotImplementedException][7]. (Overrides [MembershipProvider.UpdateUser(MembershipUser)][36].)                                                                  
[ValidateUser][37]                   | Verifies that the specified user name and password exist in the data source. (Overrides [MembershipProvider.ValidateUser(String, String)][38].)                                             


Properties
----------

Name                                       | Description                                                                                                             
------------------------------------------ | ----------------------------------------------------------------------------------------------------------------------- 
[ApplicationName][39]                      | The name of the application using the custom membership provider. (Overrides [MembershipProvider.ApplicationName][40].) 
[EnablePasswordReset][41]                  | This property always returns false. (Overrides [MembershipProvider.EnablePasswordReset][42].)                           
[EnablePasswordRetrieval][43]              | This property always returns false. (Overrides [MembershipProvider.EnablePasswordRetrieval][44].)                       
[MaxInvalidPasswordAttempts][45]           | This property always returns 0. (Overrides [MembershipProvider.MaxInvalidPasswordAttempts][46].)                        
[MinRequiredNonAlphanumericCharacters][47] | This property always returns 0. (Overrides [MembershipProvider.MinRequiredNonAlphanumericCharacters][48].)              
[MinRequiredPasswordLength][49]            | This property always returns 0. (Overrides [MembershipProvider.MinRequiredPasswordLength][50].)                         
[PasswordAttemptWindow][51]                | This property always returns 0. (Overrides [MembershipProvider.PasswordAttemptWindow][52].)                             
[PasswordFormat][53]                       | This property always returns [Clear][54]. (Overrides [MembershipProvider.PasswordFormat][55].)                          
[PasswordStrengthRegularExpression][56]    | This property always returns null. (Overrides [MembershipProvider.PasswordStrengthRegularExpression][57].)              
[RequiresQuestionAndAnswer][58]            | This property always returns false. (Overrides [MembershipProvider.RequiresQuestionAndAnswer][59].)                     
[RequiresUniqueEmail][60]                  | This property always return false. (Overrides [MembershipProvider.RequiresUniqueEmail][61].)                            


Remarks
-------
 The only methods implemented are [GetUser(String, Boolean)][27], [GetUser(Object, Boolean)][25] and [ValidateUser(String, String)][37]. All other methods throw a [NotImplementedException][7]. 

See Also
--------
[MvcAccount.Web.Security Namespace][4]  

[1]: http://msdn.microsoft.com/en-us/library/sfka4yf8
[2]: http://msdn.microsoft.com/en-us/library/e5kfa45b
[3]: http://msdn.microsoft.com/en-us/library/5x9wbz2y
[4]: ../README.md
[5]: _ctor.md
[6]: ChangePassword.md
[7]: http://msdn.microsoft.com/en-us/library/6byb74h9
[8]: http://msdn.microsoft.com/en-us/library/bdt44e91
[9]: ChangePasswordQuestionAndAnswer.md
[10]: http://msdn.microsoft.com/en-us/library/hdwf5syf
[11]: CreateUser.md
[12]: http://msdn.microsoft.com/en-us/library/ms152040
[13]: DeleteUser.md
[14]: http://msdn.microsoft.com/en-us/library/9y0e13b2
[15]: FindUsersByEmail.md
[16]: http://msdn.microsoft.com/en-us/library/96e54ch9
[17]: FindUsersByName.md
[18]: http://msdn.microsoft.com/en-us/library/89e8kx21
[19]: GetAllUsers.md
[20]: http://msdn.microsoft.com/en-us/library/eab6t4cc
[21]: GetNumberOfUsersOnline.md
[22]: http://msdn.microsoft.com/en-us/library/5z4s4edy
[23]: GetPassword.md
[24]: http://msdn.microsoft.com/en-us/library/67dkyyt9
[25]: GetUser.md
[26]: http://msdn.microsoft.com/en-us/library/ms152044
[27]: GetUser_1.md
[28]: http://msdn.microsoft.com/en-us/library/bwzxkby7
[29]: GetUserNameByEmail.md
[30]: http://msdn.microsoft.com/en-us/library/57hsxfsd
[31]: ResetPassword.md
[32]: http://msdn.microsoft.com/en-us/library/xfk80t55
[33]: UnlockUser.md
[34]: http://msdn.microsoft.com/en-us/library/ms152047
[35]: UpdateUser.md
[36]: http://msdn.microsoft.com/en-us/library/3b6421tx
[37]: ValidateUser.md
[38]: http://msdn.microsoft.com/en-us/library/05d03b82
[39]: ApplicationName.md
[40]: http://msdn.microsoft.com/en-us/library/tb1kfc28
[41]: EnablePasswordReset.md
[42]: http://msdn.microsoft.com/en-us/library/yc26ahtx
[43]: EnablePasswordRetrieval.md
[44]: http://msdn.microsoft.com/en-us/library/cf2xwfk2
[45]: MaxInvalidPasswordAttempts.md
[46]: http://msdn.microsoft.com/en-us/library/ms152049
[47]: MinRequiredNonAlphanumericCharacters.md
[48]: http://msdn.microsoft.com/en-us/library/ms152050
[49]: MinRequiredPasswordLength.md
[50]: http://msdn.microsoft.com/en-us/library/ms152051
[51]: PasswordAttemptWindow.md
[52]: http://msdn.microsoft.com/en-us/library/ms152052
[53]: PasswordFormat.md
[54]: http://msdn.microsoft.com/en-us/library/fx3ae0xh
[55]: http://msdn.microsoft.com/en-us/library/ms152053
[56]: PasswordStrengthRegularExpression.md
[57]: http://msdn.microsoft.com/en-us/library/ms152054
[58]: RequiresQuestionAndAnswer.md
[59]: http://msdn.microsoft.com/en-us/library/yda8bsea
[60]: RequiresUniqueEmail.md
[61]: http://msdn.microsoft.com/en-us/library/ms152055