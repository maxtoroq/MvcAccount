BaseController Class
====================
Base class for all MvcAccount's controllers.


Inheritance Hierarchy
---------------------
[System.Object][1]  
  [System.Web.Mvc.ControllerBase][2]  
    [System.Web.Mvc.Controller][3]  
      **MvcAccount.Shared.BaseController**  
        [More...][4]

**Namespace:** [MvcAccount.Shared][5]  
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
![Protected method] | [BaseController][6] | Initializes a new instance of the **BaseController** class 


Methods
-------

                    | Name            | Description                                                                                                                          
------------------- | --------------- | ------------------------------------------------------------------------------------------------------------------------------------ 
![Protected method] | [Initialize][7] | Initializes data that might not be available when the constructor is called. (Overrides [Controller.Initialize(RequestContext)][8].) 


Properties
----------

                      | Name               | Description                                                      
--------------------- | ------------------ | ---------------------------------------------------------------- 
![Protected property] | [Configuration][9] | The [AccountConfiguration][10] instance for the current request. 


See Also
--------
[MvcAccount.Shared Namespace][5]  


Inheritance Hierarchy (Continued)
---------------------------------
[System.Object][1]  
  [System.Web.Mvc.ControllerBase][2]  
    [System.Web.Mvc.Controller][3]  
      **MvcAccount.Shared.BaseController**  
        [MvcAccount.Account.AccountImplController][11]  
        [MvcAccount.Authentication.AuthenticationController][12]  
        [MvcAccount.Email.Change.ChangeController][13]  
        [MvcAccount.Email.Verify.VerifyController][14]  
        [MvcAccount.Password.Change.ChangeController][15]  
        [MvcAccount.Password.Reset.ResetController][16]  

[1]: http://msdn.microsoft.com/en-us/library/e5kfa45b
[2]: http://msdn.microsoft.com/en-us/library/dd504950
[3]: http://msdn.microsoft.com/en-us/library/dd460481
[4]: #inheritance-hierarchy-continued
[5]: ../README.md
[6]: _ctor.md
[7]: Initialize.md
[8]: http://msdn.microsoft.com/en-us/library/dd470201
[9]: Configuration.md
[10]: ../../MvcAccount/AccountConfiguration/README.md
[11]: ../../MvcAccount.Account/AccountImplController/README.md
[12]: ../../MvcAccount.Authentication/AuthenticationController/README.md
[13]: ../../MvcAccount.Email.Change/ChangeController/README.md
[14]: ../../MvcAccount.Email.Verify/VerifyController/README.md
[15]: ../../MvcAccount.Password.Change/ChangeController/README.md
[16]: ../../MvcAccount.Password.Reset/ResetController/README.md
[Protected method]: ../../_icons/protmethod.gif "Protected method"
[Protected property]: ../../_icons/protproperty.gif "Protected property"