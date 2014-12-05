AuthenticationController Class
==============================
Exposes authentication functionality.


Inheritance Hierarchy
---------------------
[System.Object][1]  
  [System.Web.Mvc.ControllerBase][2]  
    [System.Web.Mvc.Controller][3]  
      [MvcAccount.Shared.BaseController][4]  
        **MvcAccount.Authentication.AuthenticationController**  

**Namespace:** [MvcAccount.Authentication][5]  
**Assembly:** MvcAccount (in MvcAccount.dll)

Syntax
------

```csharp
public class AuthenticationController : BaseController
```

The **AuthenticationController** type exposes the following members.


Constructors
------------

                 | Name                                                                                          | Description                                                                                                                               
---------------- | --------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------- 
![Public method] | [AuthenticationController()][6]                                                               | Initializes a new instance of the **AuthenticationController** class.                                                                     
![Public method] | [AuthenticationController(AccountRepository, PasswordService)][7]                             | Initializes a new instance of the **AuthenticationController** class, with the provided *repo* and *passwordService*.                     
![Public method] | [AuthenticationController(AccountRepository, PasswordService, FormsAuthenticationService)][8] | Initializes a new instance of the **AuthenticationController** class, with the provided *repo*, *passwordService* and *formsAuthService*. 


Methods
-------

                    | Name                              | Description                                                                                                                               
------------------- | --------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------- 
![Protected method] | [Initialize][9]                   | Initializes data that might not be available when the constructor is called. (Overrides [BaseController.Initialize(RequestContext)][10].) 
![Public method]    | [SignIn()][11]                    | The sign in page.                                                                                                                         
![Public method]    | [SignIn(SignInInput, String)][12] | Attempts to sign in.                                                                                                                      
![Public method]    | [SignOut][13]                     | Removes the forms-authentication ticket from the browser.                                                                                 


Properties
----------

                      | Name                | Description                                                                                            
--------------------- | ------------------- | ------------------------------------------------------------------------------------------------------ 
![Protected property] | [Configuration][14] | The [AccountConfiguration][15] instance for the current request. (Inherited from [BaseController][4].) 


See Also
--------

#### Reference
[MvcAccount.Authentication Namespace][5]  

[1]: http://msdn.microsoft.com/en-us/library/e5kfa45b
[2]: http://msdn.microsoft.com/en-us/library/dd504950
[3]: http://msdn.microsoft.com/en-us/library/dd460481
[4]: ../../MvcAccount.Shared/BaseController/README.md
[5]: ../README.md
[6]: _ctor.md
[7]: _ctor_1.md
[8]: _ctor_2.md
[9]: Initialize.md
[10]: ../../MvcAccount.Shared/BaseController/Initialize.md
[11]: SignIn.md
[12]: SignIn_1.md
[13]: SignOut.md
[14]: ../../MvcAccount.Shared/BaseController/Configuration.md
[15]: ../../MvcAccount/AccountConfiguration/README.md
[Public method]: ../../_icons/pubmethod.gif "Public method"
[Protected method]: ../../_icons/protmethod.gif "Protected method"
[Protected property]: ../../_icons/protproperty.gif "Protected property"