MvcAccount Namespace
====================
 


Classes
-------

Class                                      | Description                                                                                                          
------------------------------------------ | -------------------------------------------------------------------------------------------------------------------- 
[AccountConfiguration][1]                  | Holds settings that customize the behavior of MvcAccount.                                                            
[AccountController][2]                     | Exposes the functionality of MvcAccount in an ASP.NET MVC application.                                               
[AccountMembershipProvider][3]             | A [MembershipProvider][4] that uses MvcAccount.                                                                      
[AccountRepository][5]                     | Represents a class responsible for querying and persisting account information.                                      
[AccountResources][6]                      | Provides access to localized strings used by MvcAccount.                                                             
[ChangeEmailInput][7]                      | Holds data required by the [ChangeEmail(ChangeEmailInput)][8] action.                                                
[ChangePasswordInput][9]                   | Holds data required by the [ChangePassword(ChangePasswordInput)][10] action.                                         
[ClearTextPasswordService][11]             | A [PasswordService][12] that does not encrypt passwords.                                                             
[FinishResetPasswordInput][13]             | Holds data required by the [RP(String, FinishResetPasswordInput)][14] action.                                        
[FormsAuthenticationService][15]           | Class responsible for creating authentication cookies and setting them as part of the outgoing HTTP response.        
[HtmlUtility][16]                          | Provides helper methods for HTML views.                                                                              
[PasswordLengthAttribute][17]              | Validates the length of new passwords. Settings are taken from [MinPasswordLength][18] and [MaxPasswordLength][19].  
[PasswordService][12]                      | Represents a class that performs operations on passwords, such as validation, encryption, comparison, etc.           
[ResetPasswordInput][20]                   | Holds data required by the [ResetPassword(ResetPasswordInput)][21] action.                                           
[SignInInput][22]                          | Holds data required by the [SignIn(SignInInput, String)][23] action.                                                 
[SqlMembershipProviderPasswordService][24] | A [PasswordService][12] that reuses the password encryption implementations provided by [SqlMembershipProvider][25]. 


Enumerations
------------

Enumeration                    | Description                                               
------------------------------ | --------------------------------------------------------- 
[ResetPasswordErrorReason][26] | Specifies the reason why a reset password attempt failed. 

[1]: AccountConfiguration/README.md
[2]: AccountController/README.md
[3]: AccountMembershipProvider/README.md
[4]: http://msdn.microsoft.com/en-us/library/sfka4yf8
[5]: AccountRepository/README.md
[6]: AccountResources/README.md
[7]: ChangeEmailInput/README.md
[8]: AccountController/ChangeEmail_1.md
[9]: ChangePasswordInput/README.md
[10]: AccountController/ChangePassword_1.md
[11]: ClearTextPasswordService/README.md
[12]: PasswordService/README.md
[13]: FinishResetPasswordInput/README.md
[14]: AccountController/RP_1.md
[15]: FormsAuthenticationService/README.md
[16]: HtmlUtility/README.md
[17]: PasswordLengthAttribute/README.md
[18]: AccountConfiguration/MinPasswordLength.md
[19]: AccountConfiguration/MaxPasswordLength.md
[20]: ResetPasswordInput/README.md
[21]: AccountController/ResetPassword_1.md
[22]: SignInInput/README.md
[23]: AccountController/SignIn_1.md
[24]: SqlMembershipProviderPasswordService/README.md
[25]: http://msdn.microsoft.com/en-us/library/89hwy0w9
[26]: ResetPasswordErrorReason/README.md