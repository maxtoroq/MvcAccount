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


Methods
-------

Name                  | Description                                                                                                                                                
--------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------- 
[Equals][3]           | Determines whether the specified [Object][1] is equal to the current [Object][1]. (Inherited from [Object][1].)                                            
[Finalize][4]         | Allows an object to try to free resources and perform other cleanup operations before it is reclaimed by garbage collection. (Inherited from [Object][1].) 
[GetHashCode][5]      | Serves as a hash function for a particular type. (Inherited from [Object][1].)                                                                             
[GetNow][6]           | Gets the current [DateTime][7].                                                                                                                            
[GetType][8]          | Gets the [Type][9] of the current instance. (Inherited from [Object][1].)                                                                                  
[MemberwiseClone][10] | Creates a shallow copy of the current [Object][1]. (Inherited from [Object][1].)                                                                           
[Reset][11]           | Resets the members of the configuration class to their default values.                                                                                     
[ToString][12]        | Returns a string that represents the current object. (Inherited from [Object][1].)                                                                         


Properties
----------

Name                                     | Description                                                                                                                                                                                                              
---------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ 
[AccountRepositoryResolver][13]          | A delegate that returns the [AccountRepository][14] implementation for this application. This setting is optional if using controller dependency injection, but required when using [AccountMembershipProvider][15].     
[DateTimeKind][16]                       | The kind of [DateTime][7] to use. The default is [Local][17].                                                                                                                                                            
[DependencyResolver][18]                 | A delegate for resoving dependencies. This setting can be used instead of [AccountRepositoryResolver][13] and [PasswordServiceResolver][19].                                                                             
[DisableOnMaxInvalidSignInAttempts][20]  | True to disable user if [MaxInvalidSignInAttempts][21] is exceeded. User must be manually enabled by an administrator. The default is false.                                                                             
[EmailChangeTicketExpiration][22]        | The amount of time a email change verification link is usable. The default is 24 hours.                                                                                                                                  
[EmailVerificationEnablesUser][23]       | True to enable user when email is verified. The default is true.                                                                                                                                                         
[EnableEmailVerification][24]            | True to send email with link to verify the email address. The default is true.                                                                                                                                           
[FormsAuthenticationServiceResolver][25] | A delegate that returns a [FormsAuthenticationService][26] instance. This setting is always optional since [FormsAuthenticationService][26] is a concrete type, but can be used to provide a specialized implementation. 
[HelpResource][27]                       | A resource where users can ask for help (URL, email, telephone, etc.), used in verification and notification emails.                                                                                                     
[Instance][28]                           | The **AccountConfiguration** instance.                                                                                                                                                                                   
[MaxInvalidSignInAttempts][21]           | Max. number of consecutive invalid sign in attempts. The default is 5.                                                                                                                                                   
[MaxPasswordLength][29]                  | Max. length allowed for passwords. The default is 16.                                                                                                                                                                    
[MinPasswordLength][30]                  | Min. length required for passwords. The default is 6.                                                                                                                                                                    
[PasswordResetTicketExpiration][31]      | The amount of time a password reset verification link is usable. The default is 24 hours.                                                                                                                                
[PasswordServiceResolver][19]            | A delegate that returns the [PasswordService][32] implementation for this application. This setting is optional if using controller dependency injection, but required when using [AccountMembershipProvider][15].       
[PersistentCookieTimeout][33]            | Specifies the time after which persistent authentication cookies expire. The default is 7 days.                                                                                                                          
[ResourceClassKey][34]                   | The name of the resource file (class key) in App_GlobalResources that contains localized string values.                                                                                                                  
[SignInAttemptWindow][35]                | The amount of time that must pass before a new sign in attempt, if user exceeded the [MaxInvalidSignInAttempts][21]. Not used if [DisableOnMaxInvalidSignInAttempts][20] is true. The default is 10 minutes.             
[SiteName][36]                           | The name of the website, used in verification and notification emails. If null the [Host][37] of the current HTTP request URL is used.                                                                                   


See Also
--------
[MvcAccount Namespace][2]  

[1]: http://msdn2.microsoft.com/en-us/library/e5kfa45b
[2]: ../README.md
[3]: http://msdn2.microsoft.com/en-us/library/bsc2ak47
[4]: http://msdn2.microsoft.com/en-us/library/4k87zsw7
[5]: http://msdn2.microsoft.com/en-us/library/zdee4b3y
[6]: GetNow.md
[7]: http://msdn2.microsoft.com/en-us/library/03ybds8y
[8]: http://msdn2.microsoft.com/en-us/library/dfwy45w9
[9]: http://msdn2.microsoft.com/en-us/library/42892f65
[10]: http://msdn2.microsoft.com/en-us/library/57ctke0a
[11]: Reset.md
[12]: http://msdn2.microsoft.com/en-us/library/7bxwbwt2
[13]: AccountRepositoryResolver.md
[14]: ../AccountRepository/README.md
[15]: ../AccountMembershipProvider/README.md
[16]: DateTimeKind.md
[17]: http://msdn2.microsoft.com/en-us/library/shx7s921
[18]: DependencyResolver.md
[19]: PasswordServiceResolver.md
[20]: DisableOnMaxInvalidSignInAttempts.md
[21]: MaxInvalidSignInAttempts.md
[22]: EmailChangeTicketExpiration.md
[23]: EmailVerificationEnablesUser.md
[24]: EnableEmailVerification.md
[25]: FormsAuthenticationServiceResolver.md
[26]: ../FormsAuthenticationService/README.md
[27]: HelpResource.md
[28]: Instance.md
[29]: MaxPasswordLength.md
[30]: MinPasswordLength.md
[31]: PasswordResetTicketExpiration.md
[32]: ../PasswordService/README.md
[33]: PersistentCookieTimeout.md
[34]: ResourceClassKey.md
[35]: SignInAttemptWindow.md
[36]: SiteName.md
[37]: http://msdn2.microsoft.com/en-us/library/kx8cbz3x