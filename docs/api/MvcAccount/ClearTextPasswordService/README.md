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

Name                            | Description                                                                                                                                                                                                                                              
------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
[Equals][5]                     | Determines whether the specified [Object][2] is equal to the current [Object][2]. (Inherited from [Object][2].)                                                                                                                                          
[Finalize][6]                   | Allows an object to try to free resources and perform other cleanup operations before it is reclaimed by garbage collection. (Inherited from [Object][2].)                                                                                               
[GetHashCode][7]                | Serves as a hash function for a particular type. (Inherited from [Object][2].)                                                                                                                                                                           
[GetType][8]                    | Gets the [Type][9] of the current instance. (Inherited from [Object][2].)                                                                                                                                                                                
[MemberwiseClone][10]           | Creates a shallow copy of the current [Object][2]. (Inherited from [Object][2].)                                                                                                                                                                         
[PasswordEquals][11]            | Compares a password provided by a user to one that is stored. (Overrides [PasswordService.PasswordEquals(String, String)][12].)                                                                                                                          
[ProcessPasswordForStorage][13] | Returns *clearTextPassword* unchanged. (Overrides [PasswordService.ProcessPasswordForStorage(String)][14].)                                                                                                                                              
[ToString][15]                  | Returns a string that represents the current object. (Inherited from [Object][2].)                                                                                                                                                                       
[ValidatePassword][16]          | Validates a new password provided by a user. This method can be used to check if the new password has the length required by the encryption method. Returns null by default, which means all passwords are valid. (Inherited from [PasswordService][1].) 


See Also
--------
[MvcAccount Namespace][3]  

[1]: ../PasswordService/README.md
[2]: http://msdn2.microsoft.com/en-us/library/e5kfa45b
[3]: ../README.md
[4]: _ctor.md
[5]: http://msdn2.microsoft.com/en-us/library/bsc2ak47
[6]: http://msdn2.microsoft.com/en-us/library/4k87zsw7
[7]: http://msdn2.microsoft.com/en-us/library/zdee4b3y
[8]: http://msdn2.microsoft.com/en-us/library/dfwy45w9
[9]: http://msdn2.microsoft.com/en-us/library/42892f65
[10]: http://msdn2.microsoft.com/en-us/library/57ctke0a
[11]: PasswordEquals.md
[12]: ../PasswordService/PasswordEquals.md
[13]: ProcessPasswordForStorage.md
[14]: ../PasswordService/ProcessPasswordForStorage.md
[15]: http://msdn2.microsoft.com/en-us/library/7bxwbwt2
[16]: ../PasswordService/ValidatePassword.md