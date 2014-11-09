ClearTextPasswordService Class
==============================
A [PasswordService][1] that does not encrypt passwords.


Inheritance Hierarchy
---------------------
[System.Object][2]  
  [MvcAccount.PasswordService][1]  
    **MvcAccount.ClearTextPasswordService**  

**Namespace:** [MvcAccount][3]  
**Assembly:** MvcAccount (in MvcAccount.dll)

Syntax
------

```csharp
public class ClearTextPasswordService : PasswordService
```

The **ClearTextPasswordService** type exposes the following members.


Constructors
------------

Name                          | Description                                                          
----------------------------- | -------------------------------------------------------------------- 
[ClearTextPasswordService][4] | Initializes a new instance of the **ClearTextPasswordService** class 


Methods
-------

Name                           | Description                                                                                                                                                                                                                                              
------------------------------ | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
[PasswordEquals][5]            | Compares a password provided by a user to one that is stored. (Overrides [PasswordService.PasswordEquals(String, String)][6].)                                                                                                                           
[ProcessPasswordForStorage][7] | Returns *clearTextPassword* unchanged. (Overrides [PasswordService.ProcessPasswordForStorage(String)][8].)                                                                                                                                               
[ValidatePassword][9]          | Validates a new password provided by a user. This method can be used to check if the new password has the length required by the encryption method. Returns null by default, which means all passwords are valid. (Inherited from [PasswordService][1].) 


See Also
--------
[MvcAccount Namespace][3]  

[1]: ../PasswordService/README.md
[2]: http://msdn.microsoft.com/en-us/library/e5kfa45b
[3]: ../README.md
[4]: _ctor.md
[5]: PasswordEquals.md
[6]: ../PasswordService/PasswordEquals.md
[7]: ProcessPasswordForStorage.md
[8]: ../PasswordService/ProcessPasswordForStorage.md
[9]: ../PasswordService/ValidatePassword.md