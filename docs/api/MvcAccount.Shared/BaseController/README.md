BaseController Class
====================
Base class for all MvcAccount's controllers.


Inheritance Hierarchy
---------------------
[System.Object][1]  
  [System.Web.Mvc.ControllerBase][2]  
    [System.Web.Mvc.Controller][3]  
      **MvcAccount.Shared.BaseController**  
        [MvcAccount.Account.AccountImplController][4]  
        [MvcAccount.Authentication.AuthenticationController][5]  
        [MvcAccount.Email.Change.ChangeController][6]  
        [MvcAccount.Email.Verify.VerifyController][7]  
        [MvcAccount.Password.Change.ChangeController][8]  
        [MvcAccount.Password.Reset.ResetController][9]  

**Namespace:** [MvcAccount.Shared][10]  
**Assembly:** MvcAccount (in MvcAccount.dll)

Syntax
------

```csharp
public abstract class BaseController : Controller, 
	IAccountContext
```

The **BaseController** type exposes the following members.


Constructors
------------

Name                 | Description                                                
-------------------- | ---------------------------------------------------------- 
[BaseController][11] | Initializes a new instance of the **BaseController** class 


Methods
-------

Name             | Description                                                                                                                           
---------------- | ------------------------------------------------------------------------------------------------------------------------------------- 
[Initialize][12] | Initializes data that might not be available when the constructor is called. (Overrides [Controller.Initialize(RequestContext)][13].) 


Properties
----------

Name                | Description                                                      
------------------- | ---------------------------------------------------------------- 
[Configuration][14] | The [AccountConfiguration][15] instance for the current request. 


See Also
--------
[MvcAccount.Shared Namespace][10]  

[1]: http://msdn.microsoft.com/en-us/library/e5kfa45b
[2]: http://msdn.microsoft.com/en-us/library/dd504950
[3]: http://msdn.microsoft.com/en-us/library/dd460481
[4]: ../../MvcAccount.Account/AccountImplController/README.md
[5]: ../../MvcAccount.Authentication/AuthenticationController/README.md
[6]: ../../MvcAccount.Email.Change/ChangeController/README.md
[7]: ../../MvcAccount.Email.Verify/VerifyController/README.md
[8]: ../../MvcAccount.Password.Change/ChangeController/README.md
[9]: ../../MvcAccount.Password.Reset/ResetController/README.md
[10]: ../README.md
[11]: _ctor.md
[12]: Initialize.md
[13]: http://msdn.microsoft.com/en-us/library/dd470201
[14]: Configuration.md
[15]: ../../MvcAccount/AccountConfiguration/README.md