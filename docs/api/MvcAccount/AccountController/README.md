AccountController Class
=======================
Exposes the functionality of MvcAccount in an ASP.NET MVC application.


Inheritance Hierarchy
---------------------
[System.Object][1]  
  [System.Web.Mvc.ControllerBase][2]  
    [System.Web.Mvc.Controller][3]  
      **MvcAccount.AccountController**  

**Namespace:** [MvcAccount][4]  
**Assembly:** MvcAccount (in MvcAccount.dll)

Syntax
------

```csharp
public class AccountController : Controller
```

The **AccountController** type exposes the following members.


Constructors
------------

Name                                                                                   | Description                                                                                                                                     
-------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------- 
[AccountController()][5]                                                               | Initializes a new instance of the **AccountController** class.                                                                                  
[AccountController(AccountRepository, PasswordService)][6]                             | Initializes a new instance of the **AccountController** class using the provided repository and password service.                               
[AccountController(AccountRepository, PasswordService, FormsAuthenticationService)][7] | Initializes a new instance of the **AccountController** class using the provided repository, password service and forms authentication service. 


Methods
-------

Name                                                                                 | Description                                                                                                                                                                                                                   
------------------------------------------------------------------------------------ | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
[ChangeEmail()][8]                                                                   | The change email page.                                                                                                                                                                                                        
[ChangeEmail(ChangeEmailInput)][9]                                                   | Attempts to change the email.                                                                                                                                                                                                 
[ChangePassword()][10]                                                               | The change password page.                                                                                                                                                                                                     
[ChangePassword(ChangePasswordInput)][11]                                            | Attempts to change the password.                                                                                                                                                                                              
[Content(String)][12]                                                                | Creates a content result object by using a string. (Inherited from [Controller][3].)                                                                                                                                          
[Content(String, String)][13]                                                        | Creates a content result object by using a string and the content type. (Inherited from [Controller][3].)                                                                                                                     
[Content(String, String, Encoding)][14]                                              | Creates a content result object by using a string, the content type, and content encoding. (Inherited from [Controller][3].)                                                                                                  
[CreateActionInvoker][15]                                                            | Creates an action invoker. (Inherited from [Controller][3].)                                                                                                                                                                  
[CreateTempDataProvider][16]                                                         | Creates a temporary data provider. (Inherited from [Controller][3].)                                                                                                                                                          
[Dispose()][17]                                                                      | Releases all resources that are used by the current instance of the [Controller][3] class. (Inherited from [Controller][3].)                                                                                                  
[Dispose(Boolean)][18]                                                               | Releases unmanaged resources and optionally releases managed resources. (Inherited from [Controller][3].)                                                                                                                     
[EmailChangeVerificationSent][19]                                                    | A page that informs the user that the email change verification e-mail was sent.                                                                                                                                              
[EmailSaved][20]                                                                     | A page that informs the user that his new email was saved.                                                                                                                                                                    
[Equals][21]                                                                         | Determines whether the specified [Object][1] is equal to the current [Object][1]. (Inherited from [Object][1].)                                                                                                               
[Execute][22]                                                                        | Executes the specified request context. (Inherited from [ControllerBase][2].)                                                                                                                                                 
[ExecuteCore][23]                                                                    | Invokes the action in the current controller context. (Inherited from [Controller][3].)                                                                                                                                       
[File(Byte[], String)][24]                                                           | Creates a [FileContentResult][25] object by using the file contents and file type. (Inherited from [Controller][3].)                                                                                                          
[File(Stream, String)][26]                                                           | Creates a [FileStreamResult][27] object by using the [Stream][28] object and content type. (Inherited from [Controller][3].)                                                                                                  
[File(String, String)][29]                                                           | Creates a [FilePathResult][30] object by using the file name and the content type. (Inherited from [Controller][3].)                                                                                                          
[File(Byte[], String, String)][31]                                                   | Creates a [FileContentResult][25] object by using the file contents, content type, and the destination file name. (Inherited from [Controller][3].)                                                                           
[File(Stream, String, String)][32]                                                   | Creates a [FileStreamResult][27] object using the [Stream][28] object, the content type, and the target file name. (Inherited from [Controller][3].)                                                                          
[File(String, String, String)][33]                                                   | Creates a [FilePathResult][30] object by using the file name, the content type, and the file download name. (Inherited from [Controller][3].)                                                                                 
[Finalize][34]                                                                       | Allows an object to try to free resources and perform other cleanup operations before it is reclaimed by garbage collection. (Inherited from [Object][1].)                                                                    
[GetHashCode][35]                                                                    | Serves as a hash function for a particular type. (Inherited from [Object][1].)                                                                                                                                                
[GetType][36]                                                                        | Gets the [Type][37] of the current instance. (Inherited from [Object][1].)                                                                                                                                                    
[HandleUnknownAction][38]                                                            | Called when a request matches this controller, but no method with the specified action name is found in the controller. (Inherited from [Controller][3].)                                                                     
[HttpNotFound()][39]                                                                 | Returns an instance of the [HttpNotFoundResult][40] class. (Inherited from [Controller][3].)                                                                                                                                  
[HttpNotFound(String)][41]                                                           | Returns an instance of the [HttpNotFoundResult][40] class. (Inherited from [Controller][3].)                                                                                                                                  
[Index][42]                                                                          | The index page.                                                                                                                                                                                                               
[Initialize][43]                                                                     | Initializes data that might not be available when the constructor is called. (Inherited from [Controller][3].)                                                                                                                
[JavaScript][44]                                                                     | Creates a [JavaScriptResult][45] object. (Inherited from [Controller][3].)                                                                                                                                                    
[Json(Object)][46]                                                                   | Creates a [JsonResult][47] object that serializes the specified object to JavaScript Object Notation (JSON). (Inherited from [Controller][3].)                                                                                
[Json(Object, String)][48]                                                           | Creates a [JsonResult][47] object that serializes the specified object to JavaScript Object Notation (JSON) format. (Inherited from [Controller][3].)                                                                         
[Json(Object, JsonRequestBehavior)][49]                                              | Creates a [JsonResult][47] object that serializes the specified object to JavaScript Object Notation (JSON) format using the specified JSON request behavior. (Inherited from [Controller][3].)                               
[Json(Object, String, Encoding)][50]                                                 | Creates a [JsonResult][47] object that serializes the specified object to JavaScript Object Notation (JSON) format. (Inherited from [Controller][3].)                                                                         
[Json(Object, String, JsonRequestBehavior)][51]                                      | Creates a [JsonResult][47] object that serializes the specified object to JavaScript Object Notation (JSON) format using the specified content type and JSON request behavior. (Inherited from [Controller][3].)              
[Json(Object, String, Encoding, JsonRequestBehavior)][52]                            | Creates a [JsonResult][47] object that serializes the specified object to JavaScript Object Notation (JSON) format using the content type, content encoding, and the JSON request behavior. (Inherited from [Controller][3].) 
[MemberwiseClone][53]                                                                | Creates a shallow copy of the current [Object][1]. (Inherited from [Object][1].)                                                                                                                                              
[OnActionExecuted][54]                                                               | Called after the action method is invoked. (Inherited from [Controller][3].)                                                                                                                                                  
[OnActionExecuting][55]                                                              | Called before the action method is invoked. (Inherited from [Controller][3].)                                                                                                                                                 
[OnAuthorization][56]                                                                | Called when authorization occurs. (Inherited from [Controller][3].)                                                                                                                                                           
[OnException][57]                                                                    | Called when an unhandled exception occurs in the action. (Inherited from [Controller][3].)                                                                                                                                    
[OnResultExecuted][58]                                                               | Called after the action result that is returned by an action method is executed. (Inherited from [Controller][3].)                                                                                                            
[OnResultExecuting][59]                                                              | Called before the action result that is returned by an action method is executed. (Inherited from [Controller][3].)                                                                                                           
[PartialView()][60]                                                                  | Creates a [PartialViewResult][61] object that renders a partial view. (Inherited from [Controller][3].)                                                                                                                       
[PartialView(Object)][62]                                                            | Creates a [PartialViewResult][61] object that renders a partial view, by using the specified model. (Inherited from [Controller][3].)                                                                                         
[PartialView(String)][63]                                                            | Creates a [PartialViewResult][61] object that renders a partial view, by using the specified view name. (Inherited from [Controller][3].)                                                                                     
[PartialView(String, Object)][64]                                                    | Creates a [PartialViewResult][61] object that renders a partial view, by using the specified view name and model. (Inherited from [Controller][3].)                                                                           
[PasswordReset][65]                                                                  | A page that informs the user that his password has been reset.                                                                                                                                                                
[PasswordResetVerificationSent][66]                                                  | A page that informs the user that the reset password verification e-mail was sent.                                                                                                                                            
[PasswordSaved][67]                                                                  | A page that informs the user that his new password was saved.                                                                                                                                                                 
[Redirect][68]                                                                       | Creates a [RedirectResult][69] object that redirects to the specified URL. (Inherited from [Controller][3].)                                                                                                                  
[RedirectPermanent][70]                                                              | Returns an instance of the [RedirectResult][69] class with the [Permanent][71] property set to true. (Inherited from [Controller][3].)                                                                                        
[RedirectToAction(String)][72]                                                       | Redirects to the specified action using the action name. (Inherited from [Controller][3].)                                                                                                                                    
[RedirectToAction(String, Object)][73]                                               | Redirects to the specified action using the action name and route values. (Inherited from [Controller][3].)                                                                                                                   
[RedirectToAction(String, RouteValueDictionary)][74]                                 | Redirects to the specified action using the action name and route dictionary. (Inherited from [Controller][3].)                                                                                                               
[RedirectToAction(String, String)][75]                                               | Redirects to the specified action using the action name and controller name. (Inherited from [Controller][3].)                                                                                                                
[RedirectToAction(String, String, Object)][76]                                       | Redirects to the specified action using the action name, controller name, and route values. (Inherited from [Controller][3].)                                                                                                 
[RedirectToAction(String, String, RouteValueDictionary)][77]                         | Redirects to the specified action using the action name, controller name, and route dictionary. (Inherited from [Controller][3].)                                                                                             
[RedirectToActionPermanent(String)][78]                                              | Returns an instance of the [RedirectResult][69] class with the [Permanent][71] property set to true using the specified action name. (Inherited from [Controller][3].)                                                        
[RedirectToActionPermanent(String, Object)][79]                                      | Returns an instance of the [RedirectResult][69] class with the [Permanent][71] property set to true using the specified action name, and route values. (Inherited from [Controller][3].)                                      
[RedirectToActionPermanent(String, RouteValueDictionary)][80]                        | Returns an instance of the [RedirectResult][69] class with the [Permanent][71] property set to true using the specified action name, and route values. (Inherited from [Controller][3].)                                      
[RedirectToActionPermanent(String, String)][81]                                      | Returns an instance of the [RedirectResult][69] class with the [Permanent][71] property set to true using the specified action name, and controller name. (Inherited from [Controller][3].)                                   
[RedirectToActionPermanent(String, String, Object)][82]                              | Returns an instance of the [RedirectResult][69] class with the [Permanent][71] property set to true using the specified action name, controller name, and route values. (Inherited from [Controller][3].)                     
[RedirectToActionPermanent(String, String, RouteValueDictionary)][83]                | Returns an instance of the [RedirectResult][69] class with the [Permanent][71] property set to true using the specified action name, controller name, and route values. (Inherited from [Controller][3].)                     
[RedirectToRoute(Object)][84]                                                        | Redirects to the specified route using the specified route values. (Inherited from [Controller][3].)                                                                                                                          
[RedirectToRoute(RouteValueDictionary)][85]                                          | Redirects to the specified route using the route dictionary. (Inherited from [Controller][3].)                                                                                                                                
[RedirectToRoute(String)][86]                                                        | Redirects to the specified route using the route name. (Inherited from [Controller][3].)                                                                                                                                      
[RedirectToRoute(String, Object)][87]                                                | Redirects to the specified route using the route name and route values. (Inherited from [Controller][3].)                                                                                                                     
[RedirectToRoute(String, RouteValueDictionary)][88]                                  | Redirects to the specified route using the route name and route dictionary. (Inherited from [Controller][3].)                                                                                                                 
[RedirectToRoutePermanent(Object)][89]                                               | Returns an instance of the [RedirectResult][69] class with the [Permanent][71] property set to true using the specified route values. (Inherited from [Controller][3].)                                                       
[RedirectToRoutePermanent(RouteValueDictionary)][90]                                 | Returns an instance of the [RedirectResult][69] class with the [Permanent][71] property set to true using the specified route values. (Inherited from [Controller][3].)                                                       
[RedirectToRoutePermanent(String)][91]                                               | Returns an instance of the [RedirectResult][69] class with the [Permanent][71] property set to true using the specified route name. (Inherited from [Controller][3].)                                                         
[RedirectToRoutePermanent(String, Object)][92]                                       | Returns an instance of the [RedirectResult][69] class with the [Permanent][71] property set to true using the specified route name and route values. (Inherited from [Controller][3].)                                        
[RedirectToRoutePermanent(String, RouteValueDictionary)][93]                         | Returns an instance of the [RedirectResult][69] class with the [Permanent][71] property set to true using the specified route name and route values. (Inherited from [Controller][3].)                                        
[ResetPassword()][94]                                                                | The reset password page.                                                                                                                                                                                                      
[ResetPassword(ResetPasswordInput)][95]                                              | Attempts to reset the password.                                                                                                                                                                                               
[RP(String)][96]                                                                     | The reset password callback page.                                                                                                                                                                                             
[RP(String, FinishResetPasswordInput)][97]                                           | Attempts to reset the password.                                                                                                                                                                                               
[SignIn()][98]                                                                       | The sign in page.                                                                                                                                                                                                             
[SignIn(SignInInput, String)][99]                                                    | Attempts to sign in.                                                                                                                                                                                                          
[SignOut][100]                                                                       | Removes the forms-authentication ticket from the browser.                                                                                                                                                                     
[ToString][101]                                                                      | Returns a string that represents the current object. (Inherited from [Object][1].)                                                                                                                                            
[TryUpdateModel&lt;TModel>(TModel)][102]                                             | Updates the specified model instance using values from the controller's current value provider. (Inherited from [Controller][3].)                                                                                             
[TryUpdateModel&lt;TModel>(TModel, String)][103]                                     | Updates the specified model instance using values from the controller's current value provider and a prefix. (Inherited from [Controller][3].)                                                                                
[TryUpdateModel&lt;TModel>(TModel, String[])][104]                                   | Updates the specified model instance using values from the controller's current value provider and included properties. (Inherited from [Controller][3].)                                                                     
[TryUpdateModel&lt;TModel>(TModel, IValueProvider)][105]                             | Updates the specified model instance using values from the value provider. (Inherited from [Controller][3].)                                                                                                                  
[TryUpdateModel&lt;TModel>(TModel, String, String[])][106]                           | Updates the specified model instance using values from the controller's current value provider, a prefix, and included properties. (Inherited from [Controller][3].)                                                          
[TryUpdateModel&lt;TModel>(TModel, String, IValueProvider)][107]                     | Updates the specified model instance using values from the value provider and a prefix. (Inherited from [Controller][3].)                                                                                                     
[TryUpdateModel&lt;TModel>(TModel, String[], IValueProvider)][108]                   | Updates the specified model instance using values from the value provider and a list of properties to include. (Inherited from [Controller][3].)                                                                              
[TryUpdateModel&lt;TModel>(TModel, String, String[], String[])][109]                 | Updates the specified model instance using values from the controller's current value provider, a prefix, a list of properties to exclude, and a list of properties to include. (Inherited from [Controller][3].)             
[TryUpdateModel&lt;TModel>(TModel, String, String[], IValueProvider)][110]           | Updates the specified model instance using values from the value provider, a prefix, and included properties. (Inherited from [Controller][3].)                                                                               
[TryUpdateModel&lt;TModel>(TModel, String, String[], String[], IValueProvider)][111] | Updates the specified model instance using values from the value provider, a prefix, a list of properties to exclude , and a list of properties to include. (Inherited from [Controller][3].)                                 
[TryValidateModel(Object)][112]                                                      | Validates the specified model instance. (Inherited from [Controller][3].)                                                                                                                                                     
[TryValidateModel(Object, String)][113]                                              | Validates the specified model instance using an HTML prefix. (Inherited from [Controller][3].)                                                                                                                                
[UpdateModel&lt;TModel>(TModel)][114]                                                | Updates the specified model instance using values from the controller's current value provider. (Inherited from [Controller][3].)                                                                                             
[UpdateModel&lt;TModel>(TModel, String)][115]                                        | Updates the specified model instance using values from the controller's current value provider and a prefix. (Inherited from [Controller][3].)                                                                                
[UpdateModel&lt;TModel>(TModel, String[])][116]                                      | Updates the specified model instance using values from the controller object's current value provider. (Inherited from [Controller][3].)                                                                                      
[UpdateModel&lt;TModel>(TModel, IValueProvider)][117]                                | Updates the specified model instance using values from the value provider. (Inherited from [Controller][3].)                                                                                                                  
[UpdateModel&lt;TModel>(TModel, String, String[])][118]                              | Updates the specified model instance using values from the controller's current value provider, a prefix, and included properties. (Inherited from [Controller][3].)                                                          
[UpdateModel&lt;TModel>(TModel, String, IValueProvider)][119]                        | Updates the specified model instance using values from the value provider and a prefix. (Inherited from [Controller][3].)                                                                                                     
[UpdateModel&lt;TModel>(TModel, String[], IValueProvider)][120]                      | Updates the specified model instance using values from the value provider, a prefix, and a list of properties to include. (Inherited from [Controller][3].)                                                                   
[UpdateModel&lt;TModel>(TModel, String, String[], String[])][121]                    | Updates the specified model instance using values from the controller's current value provider, a prefix, a list of properties to exclude, and a list of properties to include. (Inherited from [Controller][3].)             
[UpdateModel&lt;TModel>(TModel, String, String[], IValueProvider)][122]              | Updates the specified model instance using values from the value provider, a prefix, and a list of properties to include. (Inherited from [Controller][3].)                                                                   
[UpdateModel&lt;TModel>(TModel, String, String[], String[], IValueProvider)][123]    | Updates the specified model instance using values from the value provider, a prefix, a list of properties to exclude, and a list of properties to include. (Inherited from [Controller][3].)                                  
[ValidateModel(Object)][124]                                                         | Validates the specified model instance. (Inherited from [Controller][3].)                                                                                                                                                     
[ValidateModel(Object, String)][125]                                                 | Validates the specified model instance using an HTML prefix. (Inherited from [Controller][3].)                                                                                                                                
[VE][126]                                                                            | E-mail verification callback.                                                                                                                                                                                                 
[View()][127]                                                                        | Creates a [ViewResult][128] object that renders a view to the response. (Inherited from [Controller][3].)                                                                                                                     
[View(Object)][129]                                                                  | Creates a [ViewResult][128] object by using the model that renders a view to the response. (Inherited from [Controller][3].)                                                                                                  
[View(String)][130]                                                                  | Creates a [ViewResult][128] object by using the view name that renders a view. (Inherited from [Controller][3].)                                                                                                              
[View(IView)][131]                                                                   | Creates a [ViewResult][128] object that renders the specified [IView][132] object. (Inherited from [Controller][3].)                                                                                                          
[View(String, String)][133]                                                          | Creates a [ViewResult][128] object using the view name and master-page name that renders a view to the response. (Inherited from [Controller][3].)                                                                            
[View(String, Object)][134]                                                          | Creates a [ViewResult][128] object by using the view name and model that renders a view to the response. (Inherited from [Controller][3].)                                                                                    
[View(IView, Object)][135]                                                           | Creates a [ViewResult][128] object that renders the specified [IView][132] object. (Inherited from [Controller][3].)                                                                                                          
[View(String, String, Object)][136]                                                  | Creates a [ViewResult][128] object using the view name, master-page name, and model that renders a view. (Inherited from [Controller][3].)                                                                                    
[VNE][137]                                                                           | The email change verification callback.                                                                                                                                                                                       


Properties
----------

Name                     | Description                                                                                                                                       
------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------- 
[ActionInvoker][138]     | Gets the action invoker for the controller. (Inherited from [Controller][3].)                                                                     
[Binders][139]           | Gets or sets the binder. (Inherited from [Controller][3].)                                                                                        
[ControllerContext][140] | Gets or sets the controller context. (Inherited from [ControllerBase][2].)                                                                        
[HttpContext][141]       | Gets HTTP-specific information about an individual HTTP request. (Inherited from [Controller][3].)                                                
[ModelState][142]        | Gets the model state dictionary object that contains the state of the model and of model-binding validation. (Inherited from [Controller][3].)    
[Request][143]           | Gets the [HttpRequestBase][144] object for the current HTTP request. (Inherited from [Controller][3].)                                            
[Response][145]          | Gets the [HttpResponseBase][146] object for the current HTTP response. (Inherited from [Controller][3].)                                          
[RouteData][147]         | Gets the route data for the current request. (Inherited from [Controller][3].)                                                                    
[Server][148]            | Gets the [HttpServerUtilityBase][149] object that provides methods that are used during Web request processing. (Inherited from [Controller][3].) 
[Session][150]           | Gets the [HttpSessionStateBase][151] object for the current HTTP request. (Inherited from [Controller][3].)                                       
[TempData][152]          | Gets or sets the dictionary for temporary data. (Inherited from [ControllerBase][2].)                                                             
[TempDataProvider][153]  | Gets the temporary-data provider object that is used to store data for the next request. (Inherited from [Controller][3].)                        
[Url][154]               | Gets the URL helper object that is used to generate URLs by using routing. (Inherited from [Controller][3].)                                      
[User][155]              | Gets the user security information for the current HTTP request. (Inherited from [Controller][3].)                                                
[ValidateRequest][156]   | Gets or sets a value that indicates whether request validation is enabled for this request. (Inherited from [ControllerBase][2].)                 
[ValueProvider][157]     | Gets or sets the value provider for the controller. (Inherited from [ControllerBase][2].)                                                         
[ViewBag][158]           | Gets the dynamic view data dictionary. (Inherited from [ControllerBase][2].)                                                                      
[ViewData][159]          | Gets or sets the dictionary for view data. (Inherited from [ControllerBase][2].)                                                                  


See Also
--------
[MvcAccount Namespace][4]  

[1]: http://msdn.microsoft.com/en-us/library/e5kfa45b
[2]: http://msdn.microsoft.com/en-us/library/dd504950
[3]: http://msdn.microsoft.com/en-us/library/dd460481
[4]: ../README.md
[5]: _ctor.md
[6]: _ctor_1.md
[7]: _ctor_2.md
[8]: ChangeEmail.md
[9]: ChangeEmail_1.md
[10]: ChangePassword.md
[11]: ChangePassword_1.md
[12]: http://msdn.microsoft.com/en-us/library/dd470588
[13]: http://msdn.microsoft.com/en-us/library/dd492713
[14]: http://msdn.microsoft.com/en-us/library/dd505216
[15]: http://msdn.microsoft.com/en-us/library/ee264001
[16]: http://msdn.microsoft.com/en-us/library/ee703613
[17]: http://msdn.microsoft.com/en-us/library/dd492966
[18]: http://msdn.microsoft.com/en-us/library/dd492699
[19]: EmailChangeVerificationSent.md
[20]: EmailSaved.md
[21]: http://msdn.microsoft.com/en-us/library/bsc2ak47
[22]: http://msdn.microsoft.com/en-us/library/dd460277
[23]: http://msdn.microsoft.com/en-us/library/dd505239
[24]: http://msdn.microsoft.com/en-us/library/dd460208
[25]: http://msdn.microsoft.com/en-us/library/dd492748
[26]: http://msdn.microsoft.com/en-us/library/dd493017
[27]: http://msdn.microsoft.com/en-us/library/dd505251
[28]: http://msdn.microsoft.com/en-us/library/8f86tw9e
[29]: http://msdn.microsoft.com/en-us/library/dd492492
[30]: http://msdn.microsoft.com/en-us/library/dd492762
[31]: http://msdn.microsoft.com/en-us/library/dd470835
[32]: http://msdn.microsoft.com/en-us/library/dd505200
[33]: http://msdn.microsoft.com/en-us/library/dd492593
[34]: http://msdn.microsoft.com/en-us/library/4k87zsw7
[35]: http://msdn.microsoft.com/en-us/library/zdee4b3y
[36]: http://msdn.microsoft.com/en-us/library/dfwy45w9
[37]: http://msdn.microsoft.com/en-us/library/42892f65
[38]: http://msdn.microsoft.com/en-us/library/dd492730
[39]: http://msdn.microsoft.com/en-us/library/gg453938
[40]: http://msdn.microsoft.com/en-us/library/gg402019
[41]: http://msdn.microsoft.com/en-us/library/gg402084
[42]: Index.md
[43]: http://msdn.microsoft.com/en-us/library/dd470201
[44]: http://msdn.microsoft.com/en-us/library/dd505087
[45]: http://msdn.microsoft.com/en-us/library/dd492253
[46]: http://msdn.microsoft.com/en-us/library/dd504936
[47]: http://msdn.microsoft.com/en-us/library/dd470569
[48]: http://msdn.microsoft.com/en-us/library/dd470169
[49]: http://msdn.microsoft.com/en-us/library/ee430920
[50]: http://msdn.microsoft.com/en-us/library/dd470587
[51]: http://msdn.microsoft.com/en-us/library/ee430918
[52]: http://msdn.microsoft.com/en-us/library/ee430908
[53]: http://msdn.microsoft.com/en-us/library/57ctke0a
[54]: http://msdn.microsoft.com/en-us/library/dd460283
[55]: http://msdn.microsoft.com/en-us/library/dd493080
[56]: http://msdn.microsoft.com/en-us/library/dd470545
[57]: http://msdn.microsoft.com/en-us/library/dd460532
[58]: http://msdn.microsoft.com/en-us/library/dd470615
[59]: http://msdn.microsoft.com/en-us/library/dd504998
[60]: http://msdn.microsoft.com/en-us/library/dd460345
[61]: http://msdn.microsoft.com/en-us/library/dd470537
[62]: http://msdn.microsoft.com/en-us/library/dd470145
[63]: http://msdn.microsoft.com/en-us/library/dd505247
[64]: http://msdn.microsoft.com/en-us/library/dd460161
[65]: PasswordReset.md
[66]: PasswordResetVerificationSent.md
[67]: PasswordSaved.md
[68]: http://msdn.microsoft.com/en-us/library/dd492671
[69]: http://msdn.microsoft.com/en-us/library/dd492890
[70]: http://msdn.microsoft.com/en-us/library/gg401950
[71]: http://msdn.microsoft.com/en-us/library/gg401978
[72]: http://msdn.microsoft.com/en-us/library/dd460241
[73]: http://msdn.microsoft.com/en-us/library/dd460291
[74]: http://msdn.microsoft.com/en-us/library/dd492939
[75]: http://msdn.microsoft.com/en-us/library/dd470594
[76]: http://msdn.microsoft.com/en-us/library/dd460311
[77]: http://msdn.microsoft.com/en-us/library/dd505283
[78]: http://msdn.microsoft.com/en-us/library/gg453902
[79]: http://msdn.microsoft.com/en-us/library/gg453883
[80]: http://msdn.microsoft.com/en-us/library/gg453920
[81]: http://msdn.microsoft.com/en-us/library/gg453904
[82]: http://msdn.microsoft.com/en-us/library/gg401893
[83]: http://msdn.microsoft.com/en-us/library/gg453864
[84]: http://msdn.microsoft.com/en-us/library/dd470174
[85]: http://msdn.microsoft.com/en-us/library/dd470199
[86]: http://msdn.microsoft.com/en-us/library/dd492497
[87]: http://msdn.microsoft.com/en-us/library/dd470522
[88]: http://msdn.microsoft.com/en-us/library/dd505024
[89]: http://msdn.microsoft.com/en-us/library/gg453870
[90]: http://msdn.microsoft.com/en-us/library/gg453933
[91]: http://msdn.microsoft.com/en-us/library/gg453941
[92]: http://msdn.microsoft.com/en-us/library/gg416644
[93]: http://msdn.microsoft.com/en-us/library/gg453955
[94]: ResetPassword.md
[95]: ResetPassword_1.md
[96]: RP.md
[97]: RP_1.md
[98]: SignIn.md
[99]: SignIn_1.md
[100]: SignOut.md
[101]: http://msdn.microsoft.com/en-us/library/7bxwbwt2
[102]: http://msdn.microsoft.com/en-us/library/dd460189
[103]: http://msdn.microsoft.com/en-us/library/dd493137
[104]: http://msdn.microsoft.com/en-us/library/dd470377
[105]: http://msdn.microsoft.com/en-us/library/ee728634
[106]: http://msdn.microsoft.com/en-us/library/dd470908
[107]: http://msdn.microsoft.com/en-us/library/ee721265
[108]: http://msdn.microsoft.com/en-us/library/ee703530
[109]: http://msdn.microsoft.com/en-us/library/dd492957
[110]: http://msdn.microsoft.com/en-us/library/ee703635
[111]: http://msdn.microsoft.com/en-us/library/ee703452
[112]: http://msdn.microsoft.com/en-us/library/ff356143
[113]: http://msdn.microsoft.com/en-us/library/ff356144
[114]: http://msdn.microsoft.com/en-us/library/dd470933
[115]: http://msdn.microsoft.com/en-us/library/dd470808
[116]: http://msdn.microsoft.com/en-us/library/dd492193
[117]: http://msdn.microsoft.com/en-us/library/ee703656
[118]: http://msdn.microsoft.com/en-us/library/dd505127
[119]: http://msdn.microsoft.com/en-us/library/ee728613
[120]: http://msdn.microsoft.com/en-us/library/ee703486
[121]: http://msdn.microsoft.com/en-us/library/dd470388
[122]: http://msdn.microsoft.com/en-us/library/ee703664
[123]: http://msdn.microsoft.com/en-us/library/ee703509
[124]: http://msdn.microsoft.com/en-us/library/ff356131
[125]: http://msdn.microsoft.com/en-us/library/ff356138
[126]: VE.md
[127]: http://msdn.microsoft.com/en-us/library/dd460331
[128]: http://msdn.microsoft.com/en-us/library/dd505228
[129]: http://msdn.microsoft.com/en-us/library/dd492930
[130]: http://msdn.microsoft.com/en-us/library/dd460352
[131]: http://msdn.microsoft.com/en-us/library/dd460327
[132]: http://msdn.microsoft.com/en-us/library/dd470357
[133]: http://msdn.microsoft.com/en-us/library/dd470743
[134]: http://msdn.microsoft.com/en-us/library/dd460310
[135]: http://msdn.microsoft.com/en-us/library/dd470544
[136]: http://msdn.microsoft.com/en-us/library/dd492244
[137]: VNE.md
[138]: http://msdn.microsoft.com/en-us/library/dd505131
[139]: http://msdn.microsoft.com/en-us/library/dd492975
[140]: http://msdn.microsoft.com/en-us/library/dd505205
[141]: http://msdn.microsoft.com/en-us/library/dd470552
[142]: http://msdn.microsoft.com/en-us/library/dd504944
[143]: http://msdn.microsoft.com/en-us/library/dd492753
[144]: http://msdn.microsoft.com/en-us/library/cc680816
[145]: http://msdn.microsoft.com/en-us/library/dd470578
[146]: http://msdn.microsoft.com/en-us/library/cc680930
[147]: http://msdn.microsoft.com/en-us/library/dd492210
[148]: http://msdn.microsoft.com/en-us/library/dd505016
[149]: http://msdn.microsoft.com/en-us/library/cc679943
[150]: http://msdn.microsoft.com/en-us/library/dd492995
[151]: http://msdn.microsoft.com/en-us/library/cc679805
[152]: http://msdn.microsoft.com/en-us/library/dd470383
[153]: http://msdn.microsoft.com/en-us/library/dd460181
[154]: http://msdn.microsoft.com/en-us/library/dd492973
[155]: http://msdn.microsoft.com/en-us/library/dd493019
[156]: http://msdn.microsoft.com/en-us/library/dd460533
[157]: http://msdn.microsoft.com/en-us/library/dd470838
[158]: http://msdn.microsoft.com/en-us/library/gg480763
[159]: http://msdn.microsoft.com/en-us/library/dd493086