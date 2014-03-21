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
public abstract class PasswordService
```

The **PasswordService** type exposes the following members.


Constructors
------------

Name                 | Description                                                 
-------------------- | ----------------------------------------------------------- 
[PasswordService][6] | Initializes a new instance of the **PasswordService** class 


Methods
-------

Name                            | Description                                                                                                                                                                                                       
------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
[Equals][7]                     | Determines whether the specified [Object][1] is equal to the current [Object][1]. (Inherited from [Object][1].)                                                                                                   
[Finalize][8]                   | Allows an object to try to free resources and perform other cleanup operations before it is reclaimed by garbage collection. (Inherited from [Object][1].)                                                        
[GetHashCode][9]                | Serves as a hash function for a particular type. (Inherited from [Object][1].)                                                                                                                                    
[GetType][10]                   | Gets the [Type][11] of the current instance. (Inherited from [Object][1].)                                                                                                                                        
[MemberwiseClone][12]           | Creates a shallow copy of the current [Object][1]. (Inherited from [Object][1].)                                                                                                                                  
[PasswordEquals][13]            | Compares a password provided by a user to one that is stored.                                                                                                                                                     
[ProcessPasswordForStorage][14] | Converts the *clearTextPassword* to one that is suitable for storage.                                                                                                                                             
[ToString][15]                  | Returns a string that represents the current object. (Inherited from [Object][1].)                                                                                                                                
[ValidatePassword][16]          | Validates a new password provided by a user. This method can be used to check if the new password has the length required by the encryption method. Returns null by default, which means all passwords are valid. 


See Also
--------
[MvcAccount Namespace][5]  

[1]: http://msdn.microsoft.com/en-us/library/e5kfa45b
[2]: ../ClearTextPasswordService/README.md
[3]: ../../MvcAccount.Web.Helpers/CryptoPasswordService/README.md
[4]: ../../MvcAccount.Web.Security/SqlMembershipProviderPasswordService/README.md
[5]: ../README.md
[6]: _ctor.md
[7]: http://msdn.microsoft.com/en-us/library/bsc2ak47
[8]: http://msdn.microsoft.com/en-us/library/4k87zsw7
[9]: http://msdn.microsoft.com/en-us/library/zdee4b3y
[10]: http://msdn.microsoft.com/en-us/library/dfwy45w9
[11]: http://msdn.microsoft.com/en-us/library/42892f65
[12]: http://msdn.microsoft.com/en-us/library/57ctke0a
[13]: PasswordEquals.md
[14]: ProcessPasswordForStorage.md
[15]: http://msdn.microsoft.com/en-us/library/7bxwbwt2
[16]: ValidatePassword.md