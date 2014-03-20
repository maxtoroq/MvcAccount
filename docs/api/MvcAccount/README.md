MvcAccount Namespace
====================
 


Classes
-------

Class                           | Description                                                                                                        
------------------------------- | ------------------------------------------------------------------------------------------------------------------ 
[AccountConfiguration][1]       | Holds settings that customize the behavior of MvcAccount.                                                          
[AccountController][2]          | Entry point controller for MvcAccount.                                                                             
[AccountRepository][3]          | Represents a class responsible for querying and persisting account information.                                    
[AccountResources][4]           | Provides access to localized strings.                                                                              
[ClearTextPasswordService][5]   | A [PasswordService][6] that does not encrypt passwords.                                                            
[FormsAuthenticationService][7] | Class responsible for creating authentication cookies and setting them as part of the outgoing HTTP response.      
[PasswordLengthAttribute][8]    | Validates the length of new passwords. Settings are taken from [MinPasswordLength][9] and [MaxPasswordLength][10]. 
[PasswordService][6]            | Represents a class that performs operations on passwords, such as validation, encryption, comparison, etc.         

[1]: AccountConfiguration/README.md
[2]: AccountController/README.md
[3]: AccountRepository/README.md
[4]: AccountResources/README.md
[5]: ClearTextPasswordService/README.md
[6]: PasswordService/README.md
[7]: FormsAuthenticationService/README.md
[8]: PasswordLengthAttribute/README.md
[9]: AccountConfiguration/MinPasswordLength.md
[10]: AccountConfiguration/MaxPasswordLength.md