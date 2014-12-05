ChangeController Class
======================
Exposes e-mail change functionality.


Inheritance Hierarchy
---------------------
[System.Object][1]  
  [System.Web.Mvc.ControllerBase][2]  
    [System.Web.Mvc.Controller][3]  
      [MvcAccount.Shared.BaseController][4]  
        **MvcAccount.Email.Change.ChangeController**  

**Namespace:** [MvcAccount.Email.Change][5]  
**Assembly:** MvcAccount (in MvcAccount.dll)

Syntax
------

```csharp
public class ChangeController : BaseController
```

The **ChangeController** type exposes the following members.


Constructors
------------

                 | Name                                                                                  | Description                                                                                                                       
---------------- | ------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------- 
![Public method] | [ChangeController()][6]                                                               | Initializes a new instance of the **ChangeController** class.                                                                     
![Public method] | [ChangeController(AccountRepository, PasswordService)][7]                             | Initializes a new instance of the **ChangeController** class, with the provided *repo* and *passwordService*.                     
![Public method] | [ChangeController(AccountRepository, PasswordService, FormsAuthenticationService)][8] | Initializes a new instance of the **ChangeController** class, with the provided *repo*, *passwordService* and *formsAuthService*. 


Methods
-------

                    | Name                                  | Description                                                                                                                               
------------------- | ------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------- 
![Public method]    | [Change()][9]                         | The change email page.                                                                                                                    
![Public method]    | [Change(ChangeInput, FormButton)][10] | Attempts to change the email.                                                                                                             
![Protected method] | [Initialize][11]                      | Initializes data that might not be available when the constructor is called. (Overrides [BaseController.Initialize(RequestContext)][12].) 
![Public method]    | [Saved][13]                           | A page that informs the user that his new email was saved.                                                                                
![Public method]    | [VerificationSent][14]                | A page that informs the user that the email change verification e-mail was sent.                                                          
![Public method]    | [Verify][15]                          | The email change verification callback.                                                                                                   


Properties
----------

                      | Name                | Description                                                                                            
--------------------- | ------------------- | ------------------------------------------------------------------------------------------------------ 
![Protected property] | [Configuration][16] | The [AccountConfiguration][17] instance for the current request. (Inherited from [BaseController][4].) 


See Also
--------

#### Reference
[MvcAccount.Email.Change Namespace][5]  

[1]: http://msdn.microsoft.com/en-us/library/e5kfa45b
[2]: http://msdn.microsoft.com/en-us/library/dd504950
[3]: http://msdn.microsoft.com/en-us/library/dd460481
[4]: ../../MvcAccount.Shared/BaseController/README.md
[5]: ../README.md
[6]: _ctor.md
[7]: _ctor_1.md
[8]: _ctor_2.md
[9]: Change.md
[10]: Change_1.md
[11]: Initialize.md
[12]: ../../MvcAccount.Shared/BaseController/Initialize.md
[13]: Saved.md
[14]: VerificationSent.md
[15]: Verify.md
[16]: ../../MvcAccount.Shared/BaseController/Configuration.md
[17]: ../../MvcAccount/AccountConfiguration/README.md
[Public method]: ../../_icons/pubmethod.gif "Public method"
[Protected method]: ../../_icons/protmethod.gif "Protected method"
[Protected property]: ../../_icons/protproperty.gif "Protected property"