AccountController Class
=======================
Entry point controller for MvcAccount.


Inheritance Hierarchy
---------------------
[System.Object][1]  
  [System.Web.Mvc.ControllerBase][2]  
    [System.Web.Mvc.Controller][3]  
      [MvcAccount.Shared.BaseController][4]  
        [MvcAccount.Account.AccountImplController][5]  
          **MvcAccount.AccountController**  

**Namespace:** [MvcAccount][6]  
**Assembly:** MvcAccount (in MvcAccount.dll)

Syntax
------

```csharp
public class AccountController : AccountImplController
```

The **AccountController** type exposes the following members.


Constructors
------------

                 | Name                   | Description                                                   
---------------- | ---------------------- | ------------------------------------------------------------- 
![Public method] | [AccountController][7] | Initializes a new instance of the **AccountController** class 


Methods
-------

                    | Name            | Description                                                                                                        
------------------- | --------------- | ------------------------------------------------------------------------------------------------------------------ 
![Public method]    | [Index][8]      | The index page. (Inherited from [AccountImplController][5].)                                                       
![Protected method] | [Initialize][9] | Initializes data that might not be available when the constructor is called. (Inherited from [BaseController][4].) 


Properties
----------

                      | Name                | Description                                                                                            
--------------------- | ------------------- | ------------------------------------------------------------------------------------------------------ 
![Protected property] | [Configuration][10] | The [AccountConfiguration][11] instance for the current request. (Inherited from [BaseController][4].) 


See Also
--------

#### Reference
[MvcAccount Namespace][6]  

[1]: http://msdn.microsoft.com/en-us/library/e5kfa45b
[2]: http://msdn.microsoft.com/en-us/library/dd504950
[3]: http://msdn.microsoft.com/en-us/library/dd460481
[4]: ../../MvcAccount.Shared/BaseController/README.md
[5]: ../../MvcAccount.Account/AccountImplController/README.md
[6]: ../README.md
[7]: _ctor.md
[8]: ../../MvcAccount.Account/AccountImplController/Index.md
[9]: ../../MvcAccount.Shared/BaseController/Initialize.md
[10]: ../../MvcAccount.Shared/BaseController/Configuration.md
[11]: ../AccountConfiguration/README.md
[Public method]: ../../_icons/pubmethod.gif "Public method"
[Protected method]: ../../_icons/protmethod.gif "Protected method"
[Protected property]: ../../_icons/protproperty.gif "Protected property"