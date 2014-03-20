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
public class CryptoPasswordService : PasswordService
```

The **CryptoPasswordService** type exposes the following members.


Constructors
------------

Name                       | Description                                                       
-------------------------- | ----------------------------------------------------------------- 
[CryptoPasswordService][5] | Initializes a new instance of the **CryptoPasswordService** class 


Methods
-------

Name                            | Description                                                                                                                                                                                                                                              
------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
[Equals][6]                     | Determines whether the specified [Object][3] is equal to the current [Object][3]. (Inherited from [Object][3].)                                                                                                                                          
[Finalize][7]                   | Allows an object to try to free resources and perform other cleanup operations before it is reclaimed by garbage collection. (Inherited from [Object][3].)                                                                                               
[GetHashCode][8]                | Serves as a hash function for a particular type. (Inherited from [Object][3].)                                                                                                                                                                           
[GetType][9]                    | Gets the [Type][10] of the current instance. (Inherited from [Object][3].)                                                                                                                                                                               
[MemberwiseClone][11]           | Creates a shallow copy of the current [Object][3]. (Inherited from [Object][3].)                                                                                                                                                                         
[PasswordEquals][12]            | Compares a password provided by a user to one that is stored. (Overrides [PasswordService.PasswordEquals(String, String)][13].)                                                                                                                          
[ProcessPasswordForStorage][14] | Converts the *clearTextPassword* to one that is suitable for storage. (Overrides [PasswordService.ProcessPasswordForStorage(String)][15].)                                                                                                               
[ToString][16]                  | Returns a string that represents the current object. (Inherited from [Object][3].)                                                                                                                                                                       
[ValidatePassword][17]          | Validates a new password provided by a user. This method can be used to check if the new password has the length required by the encryption method. Returns null by default, which means all passwords are valid. (Inherited from [PasswordService][1].) 


See Also
--------
[MvcAccount.Web.Helpers Namespace][4]  

[1]: ../../MvcAccount/PasswordService/README.md
[2]: http://msdn2.microsoft.com/en-us/library/gg538437
[3]: http://msdn2.microsoft.com/en-us/library/e5kfa45b
[4]: ../README.md
[5]: _ctor.md
[6]: http://msdn2.microsoft.com/en-us/library/bsc2ak47
[7]: http://msdn2.microsoft.com/en-us/library/4k87zsw7
[8]: http://msdn2.microsoft.com/en-us/library/zdee4b3y
[9]: http://msdn2.microsoft.com/en-us/library/dfwy45w9
[10]: http://msdn2.microsoft.com/en-us/library/42892f65
[11]: http://msdn2.microsoft.com/en-us/library/57ctke0a
[12]: PasswordEquals.md
[13]: ../../MvcAccount/PasswordService/PasswordEquals.md
[14]: ProcessPasswordForStorage.md
[15]: ../../MvcAccount/PasswordService/ProcessPasswordForStorage.md
[16]: http://msdn2.microsoft.com/en-us/library/7bxwbwt2
[17]: ../../MvcAccount/PasswordService/ValidatePassword.md