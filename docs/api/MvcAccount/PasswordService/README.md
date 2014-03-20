PasswordService Class
=====================
Represents a class that performs operations on passwords, such as validation, encryption, comparison, etc.


Inheritance Hierarchy
---------------------
[System.Object][1]  
  **MvcAccount.PasswordService**  
    [MvcAccount.ClearTextPasswordService][2]  
    [MvcAccount.SqlMembershipProviderPasswordService][3]  

**Namespace:** [MvcAccount][4]  
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
[PasswordService][5] | Initializes a new instance of the **PasswordService** class 


Methods
-------

Name                            | Description                                                                                                                                                                                                       
------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
[Equals][6]                     | Determines whether the specified [Object][1] is equal to the current [Object][1]. (Inherited from [Object][1].)                                                                                                   
[Finalize][7]                   | Allows an object to try to free resources and perform other cleanup operations before it is reclaimed by garbage collection. (Inherited from [Object][1].)                                                        
[GetHashCode][8]                | Serves as a hash function for a particular type. (Inherited from [Object][1].)                                                                                                                                    
[GetType][9]                    | Gets the [Type][10] of the current instance. (Inherited from [Object][1].)                                                                                                                                        
[MemberwiseClone][11]           | Creates a shallow copy of the current [Object][1]. (Inherited from [Object][1].)                                                                                                                                  
[PasswordEquals][12]            | Compares a password provided by a user to one that is stored.                                                                                                                                                     
[ProcessPasswordForStorage][13] | Converts the *clearTextPassword* to one that is suitable for storage.                                                                                                                                             
[ToString][14]                  | Returns a string that represents the current object. (Inherited from [Object][1].)                                                                                                                                
[ValidatePassword][15]          | Validates a new password provided by a user. This method can be used to check if the new password has the length required by the encryption method. Returns null by default, which means all passwords are valid. 


See Also
--------
[MvcAccount Namespace][4]  

[1]: http://msdn2.microsoft.com/en-us/library/e5kfa45b
[2]: ../ClearTextPasswordService/README.md
[3]: ../SqlMembershipProviderPasswordService/README.md
[4]: ../README.md
[5]: _ctor.md
[6]: http://msdn2.microsoft.com/en-us/library/bsc2ak47
[7]: http://msdn2.microsoft.com/en-us/library/4k87zsw7
[8]: http://msdn2.microsoft.com/en-us/library/zdee4b3y
[9]: http://msdn2.microsoft.com/en-us/library/dfwy45w9
[10]: http://msdn2.microsoft.com/en-us/library/42892f65
[11]: http://msdn2.microsoft.com/en-us/library/57ctke0a
[12]: PasswordEquals.md
[13]: ProcessPasswordForStorage.md
[14]: http://msdn2.microsoft.com/en-us/library/7bxwbwt2
[15]: ValidatePassword.md