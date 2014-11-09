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


Properties
----------

Name            | Description                                                         
--------------- | ------------------------------------------------------------------- 
[Password][5]   | The password.                                                       
[RememberMe][6] | True to create a persistent authentication cookie; otherwise false. 
[Username][7]   | The username.                                                       


See Also
--------
[MvcAccount.Authentication Namespace][3]  

[1]: ../AuthenticationController/SignIn_1.md
[2]: http://msdn.microsoft.com/en-us/library/e5kfa45b
[3]: ../README.md
[4]: _ctor.md
[5]: Password.md
[6]: RememberMe.md
[7]: Username.md