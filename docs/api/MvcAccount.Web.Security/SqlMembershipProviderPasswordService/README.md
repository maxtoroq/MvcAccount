SqlMembershipProviderPasswordService Class
==========================================
A [PasswordService][1] that reuses the password encryption implementations provided by [SqlMembershipProvider][2].


Inheritance Hierarchy
---------------------
[System.Object][3]  
  [MvcAccount.PasswordService][1]  
    **MvcAccount.Web.Security.SqlMembershipProviderPasswordService**  

**Namespace:** [MvcAccount.Web.Security][4]  
**Assembly:** MvcAccount (in MvcAccount.dll)

Syntax
------

```csharp
public class SqlMembershipProviderPasswordService : PasswordService
```

The **SqlMembershipProviderPasswordService** type exposes the following members.


Constructors
------------

Name                                      | Description                                                                                    
----------------------------------------- | ---------------------------------------------------------------------------------------------- 
[SqlMembershipProviderPasswordService][5] | Initializes a new **SqlMembershipProviderPasswordService** using the provided password format. 


Methods
-------

Name                           | Description                                                                                                                                                                                                                                              
------------------------------ | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
[PasswordEquals][6]            | Compares a password provided by a user to one that is stored. (Overrides [PasswordService.PasswordEquals(String, String)][7].)                                                                                                                           
[ProcessPasswordForStorage][8] | Converts the *clearTextPassword* to one that is suitable for storage. (Overrides [PasswordService.ProcessPasswordForStorage(String)][9].)                                                                                                                
[ValidatePassword][10]         | Validates a new password provided by a user. This method can be used to check if the new password has the length required by the encryption method. Returns null by default, which means all passwords are valid. (Inherited from [PasswordService][1].) 


See Also
--------
[MvcAccount.Web.Security Namespace][4]  

[1]: ../../MvcAccount/PasswordService/README.md
[2]: http://msdn.microsoft.com/en-us/library/89hwy0w9
[3]: http://msdn.microsoft.com/en-us/library/e5kfa45b
[4]: ../README.md
[5]: _ctor.md
[6]: PasswordEquals.md
[7]: ../../MvcAccount/PasswordService/PasswordEquals.md
[8]: ProcessPasswordForStorage.md
[9]: ../../MvcAccount/PasswordService/ProcessPasswordForStorage.md
[10]: ../../MvcAccount/PasswordService/ValidatePassword.md