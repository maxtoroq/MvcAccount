SignInInput Class
=================
Holds data required by the [SignIn(SignInInput, String)][1] action.


Inheritance Hierarchy
---------------------
[System.Object][2]  
  **MvcAccount.Authentication.SignInInput**  

**Namespace:** [MvcAccount.Authentication][3]  
**Assembly:** MvcAccount (in MvcAccount.dll)

Syntax
------

```csharp
public class SignInInput
```

The **SignInInput** type exposes the following members.


Constructors
------------

Name             | Description                                             
---------------- | ------------------------------------------------------- 
[SignInInput][4] | Initializes a new instance of the **SignInInput** class 


Methods
-------

Name                  | Description                                                                                                                                                
--------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------- 
[Equals][5]           | Determines whether the specified [Object][2] is equal to the current [Object][2]. (Inherited from [Object][2].)                                            
[Finalize][6]         | Allows an object to try to free resources and perform other cleanup operations before it is reclaimed by garbage collection. (Inherited from [Object][2].) 
[GetHashCode][7]      | Serves as a hash function for a particular type. (Inherited from [Object][2].)                                                                             
[GetType][8]          | Gets the [Type][9] of the current instance. (Inherited from [Object][2].)                                                                                  
[MemberwiseClone][10] | Creates a shallow copy of the current [Object][2]. (Inherited from [Object][2].)                                                                           
[ToString][11]        | Returns a string that represents the current object. (Inherited from [Object][2].)                                                                         


Properties
----------

Name             | Description                                                         
---------------- | ------------------------------------------------------------------- 
[Password][12]   | The password.                                                       
[RememberMe][13] | True to create a persistent authentication cookie; otherwise false. 
[Username][14]   | The username.                                                       


See Also
--------
[MvcAccount.Authentication Namespace][3]  

[1]: ../AuthenticationController/SignIn_1.md
[2]: http://msdn.microsoft.com/en-us/library/e5kfa45b
[3]: ../README.md
[4]: _ctor.md
[5]: http://msdn.microsoft.com/en-us/library/bsc2ak47
[6]: http://msdn.microsoft.com/en-us/library/4k87zsw7
[7]: http://msdn.microsoft.com/en-us/library/zdee4b3y
[8]: http://msdn.microsoft.com/en-us/library/dfwy45w9
[9]: http://msdn.microsoft.com/en-us/library/42892f65
[10]: http://msdn.microsoft.com/en-us/library/57ctke0a
[11]: http://msdn.microsoft.com/en-us/library/7bxwbwt2
[12]: Password.md
[13]: RememberMe.md
[14]: Username.md