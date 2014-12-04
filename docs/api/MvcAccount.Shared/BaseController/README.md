BaseController Class
====================
Base class for all MvcAccount's controllers.


Inheritance Hierarchy
---------------------
[System.Object][1]  
  [System.Web.Mvc.ControllerBase][2]  
    [System.Web.Mvc.Controller][3]  
      **MvcAccount.Shared.BaseController**  
        
**Namespace:** [MvcAccount.Shared][4]  
**Assembly:** MvcAccount (in MvcAccount.dll)

Syntax
------

```csharp
public abstract class BaseController : Controller, 
	IAccountContext
```

The **BaseController** type exposes the following members.


Constructors
------------

                    | Name                | Description                                                
------------------- | ------------------- | ---------------------------------------------------------- 
![Protected method] | [BaseController][5] | Initializes a new instance of the **BaseController** class 


Methods
-------

                    | Name            | Description                                                                                                                          
------------------- | --------------- | ------------------------------------------------------------------------------------------------------------------------------------ 
![Protected method] | [Initialize][6] | Initializes data that might not be available when the constructor is called. (Overrides [Controller.Initialize(RequestContext)][7].) 


Properties
----------

                      | Name               | Description                                                     
--------------------- | ------------------ | --------------------------------------------------------------- 
![Protected property] | [Configuration][8] | The [AccountConfiguration][9] instance for the current request. 


See Also
--------
[MvcAccount.Shared Namespace][4]  


Inheritance Hierarchy
---------------------
[System.Object][1]  
  [System.Web.Mvc.ControllerBase][2]  
    [System.Web.Mvc.Controller][3]  
      **MvcAccount.Shared.BaseController**  
        [MvcAccount.Account.AccountImplController][10]  
        [MvcAccount.Authentication.AuthenticationController][11]  
        [MvcAccount.Email.Change.ChangeController][12]  
        [MvcAccount.Email.Verify.VerifyController][13]  
        [MvcAccount.Password.Change.ChangeController][14]  
        [MvcAccount.Password.Reset.ResetController][15]  

[1]: http://msdn.microsoft.com/en-us/library/e5kfa45b
[2]: http://msdn.microsoft.com/en-us/library/dd504950
[3]: http://msdn.microsoft.com/en-us/library/dd460481
[4]: ../README.md
[5]: _ctor.md
[6]: Initialize.md
[7]: http://msdn.microsoft.com/en-us/library/dd470201
[8]: Configuration.md
[9]: ../../MvcAccount/AccountConfiguration/README.md
[10]: ../../MvcAccount.Account/AccountImplController/README.md
[11]: ../../MvcAccount.Authentication/AuthenticationController/README.md
[12]: ../../MvcAccount.Email.Change/ChangeController/README.md
[13]: ../../MvcAccount.Email.Verify/VerifyController/README.md
[14]: ../../MvcAccount.Password.Change/ChangeController/README.md
[15]: ../../MvcAccount.Password.Reset/ResetController/README.md
[Protected method]: ../../_icons/protmethod.gif "Protected method"
[Protected property]: ../../_icons/protproperty.gif "Protected property"