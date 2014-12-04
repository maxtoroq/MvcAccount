AccountImplController Class
===========================
Base class for [AccountController][1].


Inheritance Hierarchy
---------------------
[System.Object][2]  
  [System.Web.Mvc.ControllerBase][3]  
    [System.Web.Mvc.Controller][4]  
      [MvcAccount.Shared.BaseController][5]  
        **MvcAccount.Account.AccountImplController**  
          [MvcAccount.AccountController][1]  

**Namespace:** [MvcAccount.Account][6]  
**Assembly:** MvcAccount (in MvcAccount.dll)

Syntax
------

```csharp
public abstract class AccountImplController : BaseController
```

The **AccountImplController** type exposes the following members.


Constructors
------------

                    | Name                       | Description                                                       
------------------- | -------------------------- | ----------------------------------------------------------------- 
![Protected method] | [AccountImplController][7] | Initializes a new instance of the **AccountImplController** class 


Methods
-------

                    | Name            | Description                                                                                                        
------------------- | --------------- | ------------------------------------------------------------------------------------------------------------------ 
![Public method]    | [Index][8]      | The index page.                                                                                                    
![Protected method] | [Initialize][9] | Initializes data that might not be available when the constructor is called. (Inherited from [BaseController][5].) 


Properties
----------

                      | Name                | Description                                                                                            
--------------------- | ------------------- | ------------------------------------------------------------------------------------------------------ 
![Protected property] | [Configuration][10] | The [AccountConfiguration][11] instance for the current request. (Inherited from [BaseController][5].) 


See Also
--------
[MvcAccount.Account Namespace][6]  

[1]: ../../MvcAccount/AccountController/README.md
[2]: http://msdn.microsoft.com/en-us/library/e5kfa45b
[3]: http://msdn.microsoft.com/en-us/library/dd504950
[4]: http://msdn.microsoft.com/en-us/library/dd460481
[5]: ../../MvcAccount.Shared/BaseController/README.md
[6]: ../README.md
[7]: _ctor.md
[8]: Index.md
[9]: ../../MvcAccount.Shared/BaseController/Initialize.md
[10]: ../../MvcAccount.Shared/BaseController/Configuration.md
[11]: ../../MvcAccount/AccountConfiguration/README.md
[Protected method]: ../../_icons/protmethod.gif "Protected method"
[Public method]: ../../_icons/pubmethod.gif "Public method"
[Protected property]: ../../_icons/protproperty.gif "Protected property"