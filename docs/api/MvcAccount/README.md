MvcAccount Namespace
====================
 


Classes
-------

                | Class                           | Description                                                                                                        
--------------- | ------------------------------- | ------------------------------------------------------------------------------------------------------------------ 
![Public class] | [AccountConfiguration][1]       | Holds settings that customize the behavior of MvcAccount.                                                          
![Public class] | [AccountController][2]          | Entry point controller for MvcAccount.                                                                             
![Public class] | [AccountRepository][3]          | Represents a class responsible for querying and persisting account information.                                    
![Public class] | [AccountResources][4]           | Provides access to localized strings.                                                                              
![Public class] | [ClearTextPasswordService][5]   | A [PasswordService][6] that does not encrypt passwords.                                                            
![Public class] | [FormsAuthenticationService][7] | Class responsible for creating authentication cookies and setting them as part of the outgoing HTTP response.      
![Public class] | [PasswordLengthAttribute][8]    | Validates the length of new passwords. Settings are taken from [MinPasswordLength][9] and [MaxPasswordLength][10]. 
![Public class] | [PasswordService][6]            | Represents a class that performs operations on passwords, such as validation, encryption, comparison, etc.         

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
[Public class]: ../_icons/pubclass.gif "Public class"