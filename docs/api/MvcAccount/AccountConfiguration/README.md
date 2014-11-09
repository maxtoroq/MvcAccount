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

Name        | Description                                                            
----------- | ---------------------------------------------------------------------- 
[GetNow][4] | Gets the current [DateTime][5].                                        
[Reset][6]  | Resets the members of the configuration class to their default values. 


Properties
----------

Name                                     | Description                                                                                                                                                                                                              
---------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ 
[AccountRepositoryResolver][7]           | A delegate that returns an [AccountRepository][8] implementation. This setting is optional if using controller dependency injection, but required when using [AccountMembershipProvider][9].                             
[ConfigurationResolver][10]              | A delegate that returns an **AccountConfiguration** instance. This setting is required only when using [AccountMembershipProvider][9].                                                                                   
[DateTimeKind][11]                       | The kind of [DateTime][5] to use. The default is [Local][12].                                                                                                                                                            
[DependencyResolver][13]                 | A delegate for resoving dependencies. This setting can be used instead of [AccountRepositoryResolver][7] and [PasswordServiceResolver][14].                                                                              
[DisableOnMaxInvalidSignInAttempts][15]  | True to disable user if [MaxInvalidSignInAttempts][16] is exceeded. User must be manually enabled by an administrator. The default is false.                                                                             
[EmailChangeTicketExpiration][17]        | The amount of time a email change verification link is usable. The default is 24 hours.                                                                                                                                  
[EmailVerificationEnablesUser][18]       | True to enable user when email is verified. The default is true.                                                                                                                                                         
[EnableEmailVerification][19]            | True to send email with link to verify the email address. The default is true.                                                                                                                                           
[FormsAuthenticationServiceResolver][20] | A delegate that returns a [FormsAuthenticationService][21] instance. This setting is always optional since [FormsAuthenticationService][21] is a concrete type, but can be used to provide a specialized implementation. 
[HelpResource][22]                       | A resource where users can ask for help (URL, email, telephone, etc.), used in verification and notification emails.                                                                                                     
[MaxInvalidSignInAttempts][16]           | Max. number of consecutive invalid sign in attempts. The default is 5.                                                                                                                                                   
[MaxPasswordLength][23]                  | Max. length allowed for passwords. The default is 16.                                                                                                                                                                    
[MinPasswordLength][24]                  | Min. length required for passwords. The default is 6.                                                                                                                                                                    
[PasswordResetTicketExpiration][25]      | The amount of time a password reset verification link is usable. The default is 24 hours.                                                                                                                                
[PasswordServiceResolver][14]            | A delegate that returns a [PasswordService][26] implementation. This setting is optional if using controller dependency injection, but required when using [AccountMembershipProvider][9].                               
[PersistentCookieTimeout][27]            | Specifies the time after which persistent authentication cookies expire. The default is 7 days.                                                                                                                          
[ResourceClassKey][28]                   | The name of the resource file (class key) in App_GlobalResources that contains localized string values.                                                                                                                  
[SignInAttemptWindow][29]                | The amount of time that must pass before a new sign in attempt, if user exceeded the [MaxInvalidSignInAttempts][16]. Not used if [DisableOnMaxInvalidSignInAttempts][15] is true. The default is 10 minutes.             
[SiteName][30]                           | The name of the website, used in verification and notification emails. If null the [Host][31] of the current HTTP request URL is used.                                                                                   


See Also
--------
[MvcAccount Namespace][2]  

[1]: http://msdn.microsoft.com/en-us/library/e5kfa45b
[2]: ../README.md
[3]: _ctor.md
[4]: GetNow.md
[5]: http://msdn.microsoft.com/en-us/library/03ybds8y
[6]: Reset.md
[7]: AccountRepositoryResolver.md
[8]: ../AccountRepository/README.md
[9]: ../../MvcAccount.Web.Security/AccountMembershipProvider/README.md
[10]: ConfigurationResolver.md
[11]: DateTimeKind.md
[12]: http://msdn.microsoft.com/en-us/library/shx7s921
[13]: DependencyResolver.md
[14]: PasswordServiceResolver.md
[15]: DisableOnMaxInvalidSignInAttempts.md
[16]: MaxInvalidSignInAttempts.md
[17]: EmailChangeTicketExpiration.md
[18]: EmailVerificationEnablesUser.md
[19]: EnableEmailVerification.md
[20]: FormsAuthenticationServiceResolver.md
[21]: ../FormsAuthenticationService/README.md
[22]: HelpResource.md
[23]: MaxPasswordLength.md
[24]: MinPasswordLength.md
[25]: PasswordResetTicketExpiration.md
[26]: ../PasswordService/README.md
[27]: PersistentCookieTimeout.md
[28]: ResourceClassKey.md
[29]: SignInAttemptWindow.md
[30]: SiteName.md
[31]: http://msdn.microsoft.com/en-us/library/kx8cbz3x