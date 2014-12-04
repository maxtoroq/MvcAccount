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
public abstract class AccountRepository
```

The **AccountRepository** type exposes the following members.


Constructors
------------

                    | Name                   | Description                                                   
------------------- | ---------------------- | ------------------------------------------------------------- 
![Protected method] | [AccountRepository][3] | Initializes a new instance of the **AccountRepository** class 


Methods
-------

                 | Name                 | Description                                                                                                                                                                                               
---------------- | -------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public method] | [FindUserByEmail][4] | Gets the user whose email matches the provided *email*.                                                                                                                                                   
![Public method] | [FindUserById][5]    | Gets the user that matches the provided unique identifier. Note to Implementers: *id* can be provided as a [String][6], make sure to convert the value if needed. e.g. `int intId = Convert.ToInt32(id);` 
![Public method] | [FindUserByName][7]  | Gets the user that matches the provided *username*.                                                                                                                                                       
![Public method] | [UpdateUser][8]      | Persists the changes of *user*.                                                                                                                                                                           


See Also
--------
[MvcAccount Namespace][2]  

[1]: http://msdn.microsoft.com/en-us/library/e5kfa45b
[2]: ../README.md
[3]: _ctor.md
[4]: FindUserByEmail.md
[5]: FindUserById.md
[6]: http://msdn.microsoft.com/en-us/library/s1wwdcbf
[7]: FindUserByName.md
[8]: UpdateUser.md
[Protected method]: ../../_icons/protmethod.gif "Protected method"
[Public method]: ../../_icons/pubmethod.gif "Public method"