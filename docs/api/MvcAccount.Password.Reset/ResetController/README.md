ResetController Class
=====================
Exposes password reset functionality.


Inheritance Hierarchy
---------------------
[System.Object][1]  
  [System.Web.Mvc.ControllerBase][2]  
    [System.Web.Mvc.Controller][3]  
      [MvcAccount.Shared.BaseController][4]  
        **MvcAccount.Password.Reset.ResetController**  

**Namespace:** [MvcAccount.Password.Reset][5]  
**Assembly:** MvcAccount (in MvcAccount.dll)

Syntax
------

```csharp
public class ResetController : BaseController
```

The **ResetController** type exposes the following members.


Constructors
------------

                 | Name                                                     | Description                                                                                                  
---------------- | -------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------ 
![Public method] | [ResetController()][6]                                   | Initializes a new instance of the **ResetController** class.                                                 
![Public method] | [ResetController(AccountRepository, PasswordService)][7] | Initializes a new instance of the **ResetController** class, with the provided *repo* and *passwordService*. 


Methods
-------

                    | Name                              | Description                                                                                                                               
------------------- | --------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------- 
![Public method]    | [Done][8]                         | A page that informs the user that his password has been reset.                                                                            
![Public method]    | [Finish(String)][9]               | The reset password callback page.                                                                                                         
![Public method]    | [Finish(String, FinishInput)][10] | Attempts to reset the password.                                                                                                           
![Protected method] | [Initialize][11]                  | Initializes data that might not be available when the constructor is called. (Overrides [BaseController.Initialize(RequestContext)][12].) 
![Public method]    | [Reset()][13]                     | The reset password page.                                                                                                                  
![Public method]    | [Reset(ResetInput)][14]           | Attempts to reset the password.                                                                                                           
![Public method]    | [VerificationSent][15]            | A page that informs the user that the reset password verification e-mail was sent.                                                        


Properties
----------

                      | Name                | Description                                                                                            
--------------------- | ------------------- | ------------------------------------------------------------------------------------------------------ 
![Protected property] | [Configuration][16] | The [AccountConfiguration][17] instance for the current request. (Inherited from [BaseController][4].) 


See Also
--------

#### Reference
[MvcAccount.Password.Reset Namespace][5]  

[1]: http://msdn.microsoft.com/en-us/library/e5kfa45b
[2]: http://msdn.microsoft.com/en-us/library/dd504950
[3]: http://msdn.microsoft.com/en-us/library/dd460481
[4]: ../../MvcAccount.Shared/BaseController/README.md
[5]: ../README.md
[6]: _ctor.md
[7]: _ctor_1.md
[8]: Done.md
[9]: Finish.md
[10]: Finish_1.md
[11]: Initialize.md
[12]: ../../MvcAccount.Shared/BaseController/Initialize.md
[13]: Reset.md
[14]: Reset_1.md
[15]: VerificationSent.md
[16]: ../../MvcAccount.Shared/BaseController/Configuration.md
[17]: ../../MvcAccount/AccountConfiguration/README.md
[Public method]: ../../_icons/pubmethod.gif "Public method"
[Protected method]: ../../_icons/protmethod.gif "Protected method"
[Protected property]: ../../_icons/protproperty.gif "Protected property"