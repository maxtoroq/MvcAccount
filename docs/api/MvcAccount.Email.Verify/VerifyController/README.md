VerifyController Class
======================
Exposes e-mail verification functionality.


Inheritance Hierarchy
---------------------
[System.Object][1]  
  [System.Web.Mvc.ControllerBase][2]  
    [System.Web.Mvc.Controller][3]  
      [MvcAccount.Shared.BaseController][4]  
        **MvcAccount.Email.Verify.VerifyController**  

**Namespace:** [MvcAccount.Email.Verify][5]  
**Assembly:** MvcAccount (in MvcAccount.dll)

Syntax
------

```csharp
public class VerifyController : BaseController
```

The **VerifyController** type exposes the following members.


Constructors
------------

                 | Name                                     | Description                                                                             
---------------- | ---------------------------------------- | --------------------------------------------------------------------------------------- 
![Public method] | [VerifyController()][6]                  | Initializes a new instance of the **VerifyController** class.                           
![Public method] | [VerifyController(AccountRepository)][7] | Initializes a new instance of the **VerifyController** class, with the provided *repo*. 


Methods
-------

                    | Name            | Description                                                                                                                              
------------------- | --------------- | ---------------------------------------------------------------------------------------------------------------------------------------- 
![Protected method] | [Initialize][8] | Initializes data that might not be available when the constructor is called. (Overrides [BaseController.Initialize(RequestContext)][9].) 
![Public method]    | [Verify][10]    | E-mail verification callback.                                                                                                            


Properties
----------

                      | Name                | Description                                                                                            
--------------------- | ------------------- | ------------------------------------------------------------------------------------------------------ 
![Protected property] | [Configuration][11] | The [AccountConfiguration][12] instance for the current request. (Inherited from [BaseController][4].) 


See Also
--------
[MvcAccount.Email.Verify Namespace][5]  

[1]: http://msdn.microsoft.com/en-us/library/e5kfa45b
[2]: http://msdn.microsoft.com/en-us/library/dd504950
[3]: http://msdn.microsoft.com/en-us/library/dd460481
[4]: ../../MvcAccount.Shared/BaseController/README.md
[5]: ../README.md
[6]: _ctor.md
[7]: _ctor_1.md
[8]: Initialize.md
[9]: ../../MvcAccount.Shared/BaseController/Initialize.md
[10]: Verify.md
[11]: ../../MvcAccount.Shared/BaseController/Configuration.md
[12]: ../../MvcAccount/AccountConfiguration/README.md
[Public method]: ../../_icons/pubmethod.gif "Public method"
[Protected method]: ../../_icons/protmethod.gif "Protected method"
[Protected property]: ../../_icons/protproperty.gif "Protected property"