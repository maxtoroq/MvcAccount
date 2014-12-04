CryptoPasswordService Class
===========================
A [PasswordService][1] that uses the [Crypto][2] class to hash and compare passwords using PBKDF2.


Inheritance Hierarchy
---------------------
[System.Object][3]  
  [MvcAccount.PasswordService][1]  
    **MvcAccount.Web.Helpers.CryptoPasswordService**  

**Namespace:** [MvcAccount.Web.Helpers][4]  
**Assembly:** MvcAccount (in MvcAccount.dll)

Syntax
------

```csharp
public class CryptoPasswordService : PasswordService
```

The **CryptoPasswordService** type exposes the following members.


Constructors
------------

                 | Name                       | Description                                                       
---------------- | -------------------------- | ----------------------------------------------------------------- 
![Public method] | [CryptoPasswordService][5] | Initializes a new instance of the **CryptoPasswordService** class 


Methods
-------

                 | Name                           | Description                                                                                                                                                                                                                                              
---------------- | ------------------------------ | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public method] | [PasswordEquals][6]            | Compares a password provided by a user to one that is stored. (Overrides [PasswordService.PasswordEquals(String, String)][7].)                                                                                                                           
![Public method] | [ProcessPasswordForStorage][8] | Converts the *clearTextPassword* to one that is suitable for storage. (Overrides [PasswordService.ProcessPasswordForStorage(String)][9].)                                                                                                                
![Public method] | [ValidatePassword][10]         | Validates a new password provided by a user. This method can be used to check if the new password has the length required by the encryption method. Returns null by default, which means all passwords are valid. (Inherited from [PasswordService][1].) 


See Also
--------
[MvcAccount.Web.Helpers Namespace][4]  

[1]: ../../MvcAccount/PasswordService/README.md
[2]: http://msdn.microsoft.com/en-us/library/gg538437
[3]: http://msdn.microsoft.com/en-us/library/e5kfa45b
[4]: ../README.md
[5]: _ctor.md
[6]: PasswordEquals.md
[7]: ../../MvcAccount/PasswordService/PasswordEquals.md
[8]: ProcessPasswordForStorage.md
[9]: ../../MvcAccount/PasswordService/ProcessPasswordForStorage.md
[10]: ../../MvcAccount/PasswordService/ValidatePassword.md
[Public method]: ../../_icons/pubmethod.gif "Public method"