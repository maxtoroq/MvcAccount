AccountConfiguration Class
==========================
Holds settings that customize the behavior of MvcAccount.


Inheritance Hierarchy
---------------------
[System.Object][1]  
  **MvcAccount.AccountConfiguration**  

**Namespace:** [MvcAccount][2]  
**Assembly:** MvcAccount (in MvcAccount.dll)

Syntax
------

```csharp
public class AccountConfiguration
```

The **AccountConfiguration** type exposes the following members.


Constructors
------------

Name                      | Description                                                       
------------------------- | ----------------------------------------------------------------- 
[AccountConfiguration][3] | Initializes a new instance of the **AccountConfiguration** class. 


Methods
-------

Name                  | Description                                                                                                                                                
--------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------- 
[Equals][4]           | Determines whether the specified [Object][1] is equal to the current [Object][1]. (Inherited from [Object][1].)                                            
[Finalize][5]         | Allows an object to try to free resources and perform other cleanup operations before it is reclaimed by garbage collection. (Inherited from [Object][1].) 
[GetHashCode][6]      | Serves as a hash function for a particular type. (Inherited from [Object][1].)                                                                             
[GetNow][7]           | Gets the current [DateTime][8].                                                                                                                            
[GetType][9]          | Gets the [Type][10] of the current instance. (Inherited from [Object][1].)                                                                                 
[MemberwiseClone][11] | Creates a shallow copy of the current [Object][1]. (Inherited from [Object][1].)                                                                           
[Reset][12]           | Resets the members of the configuration class to their default values.                                                                                     
[ToString][13]        | Returns a string that represents the current object. (Inherited from [Object][1].)                                                                         


Properties
----------

Name                                     | Description                                                                                                                                                                                                              
---------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ 
[AccountRepositoryResolver][14]          | A delegate that returns an [AccountRepository][15] implementation. This setting is optional if using controller dependency injection, but required when using [AccountMembershipProvider][16].                           
[ConfigurationResolver][17]              | A delegate that returns an **AccountConfiguration** instance. This setting is required only when using [AccountMembershipProvider][16].                                                                                  
[DateTimeKind][18]                       | The kind of [DateTime][8] to use. The default is [Local][19].                                                                                                                                                            
[DependencyResolver][20]                 | A delegate for resoving dependencies. This setting can be used instead of [AccountRepositoryResolver][14] and [PasswordServiceResolver][21].                                                                             
[DisableOnMaxInvalidSignInAttempts][22]  | True to disable user if [MaxInvalidSignInAttempts][23] is exceeded. User must be manually enabled by an administrator. The default is false.                                                                             
[EmailChangeTicketExpiration][24]        | The amount of time a email change verification link is usable. The default is 24 hours.                                                                                                                                  
[EmailVerificationEnablesUser][25]       | True to enable user when email is verified. The default is true.                                                                                                                                                         
[EnableEmailVerification][26]            | True to send email with link to verify the email address. The default is true.                                                                                                                                           
[FormsAuthenticationServiceResolver][27] | A delegate that returns a [FormsAuthenticationService][28] instance. This setting is always optional since [FormsAuthenticationService][28] is a concrete type, but can be used to provide a specialized implementation. 
[HelpResource][29]                       | A resource where users can ask for help (URL, email, telephone, etc.), used in verification and notification emails.                                                                                                     
[MaxInvalidSignInAttempts][23]           | Max. number of consecutive invalid sign in attempts. The default is 5.                                                                                                                                                   
[MaxPasswordLength][30]                  | Max. length allowed for passwords. The default is 16.                                                                                                                                                                    
[MinPasswordLength][31]                  | Min. length required for passwords. The default is 6.                                                                                                                                                                    
[PasswordResetTicketExpiration][32]      | The amount of time a password reset verification link is usable. The default is 24 hours.                                                                                                                                
[PasswordServiceResolver][21]            | A delegate that returns a [PasswordService][33] implementation. This setting is optional if using controller dependency injection, but required when using [AccountMembershipProvider][16].                              
[PersistentCookieTimeout][34]            | Specifies the time after which persistent authentication cookies expire. The default is 7 days.                                                                                                                          
[ResourceClassKey][35]                   | The name of the resource file (class key) in App_GlobalResources that contains localized string values.                                                                                                                  
[SignInAttemptWindow][36]                | The amount of time that must pass before a new sign in attempt, if user exceeded the [MaxInvalidSignInAttempts][23]. Not used if [DisableOnMaxInvalidSignInAttempts][22] is true. The default is 10 minutes.             
[SiteName][37]                           | The name of the website, used in verification and notification emails. If null the [Host][38] of the current HTTP request URL is used.                                                                                   


See Also
--------
[MvcAccount Namespace][2]  

[1]: http://msdn.microsoft.com/en-us/library/e5kfa45b
[2]: ../README.md
[3]: _ctor.md
[4]: http://msdn.microsoft.com/en-us/library/bsc2ak47
[5]: http://msdn.microsoft.com/en-us/library/4k87zsw7
[6]: http://msdn.microsoft.com/en-us/library/zdee4b3y
[7]: GetNow.md
[8]: http://msdn.microsoft.com/en-us/library/03ybds8y
[9]: http://msdn.microsoft.com/en-us/library/dfwy45w9
[10]: http://msdn.microsoft.com/en-us/library/42892f65
[11]: http://msdn.microsoft.com/en-us/library/57ctke0a
[12]: Reset.md
[13]: http://msdn.microsoft.com/en-us/library/7bxwbwt2
[14]: AccountRepositoryResolver.md
[15]: ../AccountRepository/README.md
[16]: ../../MvcAccount.Web.Security/AccountMembershipProvider/README.md
[17]: ConfigurationResolver.md
[18]: DateTimeKind.md
[19]: http://msdn.microsoft.com/en-us/library/shx7s921
[20]: DependencyResolver.md
[21]: PasswordServiceResolver.md
[22]: DisableOnMaxInvalidSignInAttempts.md
[23]: MaxInvalidSignInAttempts.md
[24]: EmailChangeTicketExpiration.md
[25]: EmailVerificationEnablesUser.md
[26]: EnableEmailVerification.md
[27]: FormsAuthenticationServiceResolver.md
[28]: ../FormsAuthenticationService/README.md
[29]: HelpResource.md
[30]: MaxPasswordLength.md
[31]: MinPasswordLength.md
[32]: PasswordResetTicketExpiration.md
[33]: ../PasswordService/README.md
[34]: PersistentCookieTimeout.md
[35]: ResourceClassKey.md
[36]: SignInAttemptWindow.md
[37]: SiteName.md
[38]: http://msdn.microsoft.com/en-us/library/kx8cbz3x