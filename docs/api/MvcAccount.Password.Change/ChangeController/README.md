ChangeController Class
======================
Exposes password change functionality.


Inheritance Hierarchy
---------------------
[System.Object][1]  
  [System.Web.Mvc.ControllerBase][2]  
    [System.Web.Mvc.Controller][3]  
      [MvcAccount.Shared.BaseController][4]  
        **MvcAccount.Password.Change.ChangeController**  

**Namespace:** [MvcAccount.Password.Change][5]  
**Assembly:** MvcAccount (in MvcAccount.dll)

Syntax
------

```csharp
public class ChangeController : BaseController
```

The **ChangeController** type exposes the following members.


Constructors
------------

                 | Name                                                      | Description                                                                                                   
---------------- | --------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------- 
![Public method] | [ChangeController()][6]                                   | Initializes a new instance of the **ChangeController** class.                                                 
![Public method] | [ChangeController(AccountRepository, PasswordService)][7] | Initializes a new instance of the **ChangeController** class, with the provided *repo* and *passwordService*. 


Methods
-------

                    | Name                                 | Description                                                                                                                               
------------------- | ------------------------------------ | ----------------------------------------------------------------------------------------------------------------------------------------- 
![Public method]    | [Change()][8]                        | The change password page.                                                                                                                 
![Public method]    | [Change(ChangeInput, FormButton)][9] | Attempts to change the password.                                                                                                          
![Protected method] | [Initialize][10]                     | Initializes data that might not be available when the constructor is called. (Overrides [BaseController.Initialize(RequestContext)][11].) 
![Public method]    | [Saved][12]                          | A page that informs the user that his new password was saved.                                                                             


Properties
----------

                      | Name                | Description                                                                                            
--------------------- | ------------------- | ------------------------------------------------------------------------------------------------------ 
![Protected property] | [Configuration][13] | The [AccountConfiguration][14] instance for the current request. (Inherited from [BaseController][4].) 


See Also
--------
[MvcAccount.Password.Change Namespace][5]  

[1]: http://msdn.microsoft.com/en-us/library/e5kfa45b
[2]: http://msdn.microsoft.com/en-us/library/dd504950
[3]: http://msdn.microsoft.com/en-us/library/dd460481
[4]: ../../MvcAccount.Shared/BaseController/README.md
[5]: ../README.md
[6]: _ctor.md
[7]: _ctor_1.md
[8]: Change.md
[9]: Change_1.md
[10]: Initialize.md
[11]: ../../MvcAccount.Shared/BaseController/Initialize.md
[12]: Saved.md
[13]: ../../MvcAccount.Shared/BaseController/Configuration.md
[14]: ../../MvcAccount/AccountConfiguration/README.md
[Public method]: ../../_icons/pubmethod.gif "Public method"
[Protected method]: ../../_icons/protmethod.gif "Protected method"
[Protected property]: ../../_icons/protproperty.gif "Protected property"