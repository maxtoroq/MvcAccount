AccountRepository Class
=======================
Represents a class responsible for querying and persisting account information.


Inheritance Hierarchy
---------------------
[System.Object][1]  
  **MvcAccount.AccountRepository**  

**Namespace:** [MvcAccount][2]  
**Assembly:** MvcAccount (in MvcAccount.dll)

Syntax
------

```csharp
public abstract class AccountRepository
```

The **AccountRepository** type exposes the following members.


Constructors
------------

Name                   | Description                                                   
---------------------- | ------------------------------------------------------------- 
[AccountRepository][3] | Initializes a new instance of the **AccountRepository** class 


Methods
-------

Name                  | Description                                                                                                                                                                                               
--------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
[Equals][4]           | Determines whether the specified [Object][1] is equal to the current [Object][1]. (Inherited from [Object][1].)                                                                                           
[Finalize][5]         | Allows an object to try to free resources and perform other cleanup operations before it is reclaimed by garbage collection. (Inherited from [Object][1].)                                                
[FindUserByEmail][6]  | Gets the user whose email matches the provided *email*.                                                                                                                                                   
[FindUserById][7]     | Gets the user that matches the provided unique identifier. Note to Implementers: *id* can be provided as a [String][8], make sure to convert the value if needed. e.g. `int intId = Convert.ToInt32(id);` 
[FindUserByName][9]   | Gets the user that matches the provided *username*.                                                                                                                                                       
[GetHashCode][10]     | Serves as a hash function for a particular type. (Inherited from [Object][1].)                                                                                                                            
[GetType][11]         | Gets the [Type][12] of the current instance. (Inherited from [Object][1].)                                                                                                                                
[MemberwiseClone][13] | Creates a shallow copy of the current [Object][1]. (Inherited from [Object][1].)                                                                                                                          
[ToString][14]        | Returns a string that represents the current object. (Inherited from [Object][1].)                                                                                                                        
[UpdateUser][15]      | Persists the changes of *user*.                                                                                                                                                                           


See Also
--------
[MvcAccount Namespace][2]  

[1]: http://msdn.microsoft.com/en-us/library/e5kfa45b
[2]: ../README.md
[3]: _ctor.md
[4]: http://msdn.microsoft.com/en-us/library/bsc2ak47
[5]: http://msdn.microsoft.com/en-us/library/4k87zsw7
[6]: FindUserByEmail.md
[7]: FindUserById.md
[8]: http://msdn.microsoft.com/en-us/library/s1wwdcbf
[9]: FindUserByName.md
[10]: http://msdn.microsoft.com/en-us/library/zdee4b3y
[11]: http://msdn.microsoft.com/en-us/library/dfwy45w9
[12]: http://msdn.microsoft.com/en-us/library/42892f65
[13]: http://msdn.microsoft.com/en-us/library/57ctke0a
[14]: http://msdn.microsoft.com/en-us/library/7bxwbwt2
[15]: UpdateUser.md