PasswordService Class
=====================
Represents a class that performs operations on passwords, such as validation, encryption, comparison, etc.


Inheritance Hierarchy
---------------------
[System.Object][1]  
  **MvcAccount.PasswordService**  
    [MvcAccount.ClearTextPasswordService][2]  
    [MvcAccount.Web.Helpers.CryptoPasswordService][3]  
    [MvcAccount.Web.Security.SqlMembershipProviderPasswordService][4]  

**Namespace:** [MvcAccount][5]  
**Assembly:** MvcAccount (in MvcAccount.dll)

Syntax
------

```csharp
public abstract class PasswordService
```

The **PasswordService** type exposes the following members.


Constructors
------------

                    | Name                 | Description                                                 
------------------- | -------------------- | ----------------------------------------------------------- 
![Protected method] | [PasswordService][6] | Initializes a new instance of the **PasswordService** class 


Methods
-------

                 | Name                           | Description                                                                                                                                                                                                       
---------------- | ------------------------------ | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public method] | [PasswordEquals][7]            | Compares a password provided by a user to one that is stored.                                                                                                                                                     
![Public method] | [ProcessPasswordForStorage][8] | Converts the *clearTextPassword* to one that is suitable for storage.                                                                                                                                             
![Public method] | [ValidatePassword][9]          | Validates a new password provided by a user. This method can be used to check if the new password has the length required by the encryption method. Returns null by default, which means all passwords are valid. 


See Also
--------

#### Reference
[MvcAccount Namespace][5]  

[1]: http://msdn.microsoft.com/en-us/library/e5kfa45b
[2]: ../ClearTextPasswordService/README.md
[3]: ../../MvcAccount.Web.Helpers/CryptoPasswordService/README.md
[4]: ../../MvcAccount.Web.Security/SqlMembershipProviderPasswordService/README.md
[5]: ../README.md
[6]: _ctor.md
[7]: PasswordEquals.md
[8]: ProcessPasswordForStorage.md
[9]: ValidatePassword.md
[Protected method]: ../../_icons/protmethod.gif "Protected method"
[Public method]: ../../_icons/pubmethod.gif "Public method"