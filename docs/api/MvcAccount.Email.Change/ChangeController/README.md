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
public class ChangeController : BaseController
```

The **ChangeController** type exposes the following members.


Constructors
------------

Name                                                                                  | Description                                                                                                                       
------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------- 
[ChangeController()][6]                                                               | Initializes a new instance of the **ChangeController** class.                                                                     
[ChangeController(AccountRepository, PasswordService)][7]                             | Initializes a new instance of the **ChangeController** class, with the provided *repo* and *passwordService*.                     
[ChangeController(AccountRepository, PasswordService, FormsAuthenticationService)][8] | Initializes a new instance of the **ChangeController** class, with the provided *repo*, *passwordService* and *formsAuthService*. 


Methods
-------

Name                                                                             | Description                                                                                                                                                                                                                   
-------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
[Change()][9]                                                                    | The change email page.                                                                                                                                                                                                        
[Change(ChangeInput, FormButton)][10]                                            | Attempts to change the email.                                                                                                                                                                                                 
[Content(String)][11]                                                            | Creates a content result object by using a string. (Inherited from [Controller][3].)                                                                                                                                          
[Content(String, String)][12]                                                    | Creates a content result object by using a string and the content type. (Inherited from [Controller][3].)                                                                                                                     
[Content(String, String, Encoding)][13]                                          | Creates a content result object by using a string, the content type, and content encoding. (Inherited from [Controller][3].)                                                                                                  
[CreateActionInvoker][14]                                                        | Creates an action invoker. (Inherited from [Controller][3].)                                                                                                                                                                  
[CreateTempDataProvider][15]                                                     | Creates a temporary data provider. (Inherited from [Controller][3].)                                                                                                                                                          
[Dispose()][16]                                                                  | Releases all resources that are used by the current instance of the [Controller][3] class. (Inherited from [Controller][3].)                                                                                                  
[Dispose(Boolean)][17]                                                           | Releases unmanaged resources and optionally releases managed resources. (Inherited from [Controller][3].)                                                                                                                     
[Equals][18]                                                                     | Determines whether the specified [Object][1] is equal to the current [Object][1]. (Inherited from [Object][1].)                                                                                                               
[Execute][19]                                                                    | Executes the specified request context. (Inherited from [ControllerBase][2].)                                                                                                                                                 
[ExecuteCore][20]                                                                | Invokes the action in the current controller context. (Inherited from [Controller][3].)                                                                                                                                       
[File(Byte[], String)][21]                                                       | Creates a [FileContentResult][22] object by using the file contents and file type. (Inherited from [Controller][3].)                                                                                                          
[File(Stream, String)][23]                                                       | Creates a [FileStreamResult][24] object by using the [Stream][25] object and content type. (Inherited from [Controller][3].)                                                                                                  
[File(String, String)][26]                                                       | Creates a [FilePathResult][27] object by using the file name and the content type. (Inherited from [Controller][3].)                                                                                                          
[File(Byte[], String, String)][28]                                               | Creates a [FileContentResult][22] object by using the file contents, content type, and the destination file name. (Inherited from [Controller][3].)                                                                           
[File(Stream, String, String)][29]                                               | Creates a [FileStreamResult][24] object using the [Stream][25] object, the content type, and the target file name. (Inherited from [Controller][3].)                                                                          
[File(String, String, String)][30]                                               | Creates a [FilePathResult][27] object by using the file name, the content type, and the file download name. (Inherited from [Controller][3].)                                                                                 
[Finalize][31]                                                                   | Allows an object to try to free resources and perform other cleanup operations before it is reclaimed by garbage collection. (Inherited from [Object][1].)                                                                    
[GetHashCode][32]                                                                | Serves as a hash function for a particular type. (Inherited from [Object][1].)                                                                                                                                                
[GetType][33]                                                                    | Gets the [Type][34] of the current instance. (Inherited from [Object][1].)                                                                                                                                                    
[HandleUnknownAction][35]                                                        | Called when a request matches this controller, but no method with the specified action name is found in the controller. (Inherited from [Controller][3].)                                                                     
[HttpNotFound()][36]                                                             | Returns an instance of the [HttpNotFoundResult][37] class. (Inherited from [Controller][3].)                                                                                                                                  
[HttpNotFound(String)][38]                                                       | Returns an instance of the [HttpNotFoundResult][37] class. (Inherited from [Controller][3].)                                                                                                                                  
[Initialize][39]                                                                 | Initializes data that might not be available when the constructor is called. (Overrides [BaseController.Initialize(RequestContext)][40].)                                                                                     
[JavaScript][41]                                                                 | Creates a [JavaScriptResult][42] object. (Inherited from [Controller][3].)                                                                                                                                                    
[Json(Object)][43]                                                               | Creates a [JsonResult][44] object that serializes the specified object to JavaScript Object Notation (JSON). (Inherited from [Controller][3].)                                                                                
[Json(Object, String)][45]                                                       | Creates a [JsonResult][44] object that serializes the specified object to JavaScript Object Notation (JSON) format. (Inherited from [Controller][3].)                                                                         
[Json(Object, JsonRequestBehavior)][46]                                          | Creates a [JsonResult][44] object that serializes the specified object to JavaScript Object Notation (JSON) format using the specified JSON request behavior. (Inherited from [Controller][3].)                               
[Json(Object, String, Encoding)][47]                                             | Creates a [JsonResult][44] object that serializes the specified object to JavaScript Object Notation (JSON) format. (Inherited from [Controller][3].)                                                                         
[Json(Object, String, JsonRequestBehavior)][48]                                  | Creates a [JsonResult][44] object that serializes the specified object to JavaScript Object Notation (JSON) format using the specified content type and JSON request behavior. (Inherited from [Controller][3].)              
[Json(Object, String, Encoding, JsonRequestBehavior)][49]                        | Creates a [JsonResult][44] object that serializes the specified object to JavaScript Object Notation (JSON) format using the content type, content encoding, and the JSON request behavior. (Inherited from [Controller][3].) 
[MemberwiseClone][50]                                                            | Creates a shallow copy of the current [Object][1]. (Inherited from [Object][1].)                                                                                                                                              
[OnActionExecuted][51]                                                           | Called after the action method is invoked. (Inherited from [Controller][3].)                                                                                                                                                  
[OnActionExecuting][52]                                                          | Called before the action method is invoked. (Inherited from [Controller][3].)                                                                                                                                                 
[OnAuthorization][53]                                                            | Called when authorization occurs. (Inherited from [Controller][3].)                                                                                                                                                           
[OnException][54]                                                                | Called when an unhandled exception occurs in the action. (Inherited from [Controller][3].)                                                                                                                                    
[OnResultExecuted][55]                                                           | Called after the action result that is returned by an action method is executed. (Inherited from [Controller][3].)                                                                                                            
[OnResultExecuting][56]                                                          | Called before the action result that is returned by an action method is executed. (Inherited from [Controller][3].)                                                                                                           
[PartialView()][57]                                                              | Creates a [PartialViewResult][58] object that renders a partial view. (Inherited from [Controller][3].)                                                                                                                       
[PartialView(Object)][59]                                                        | Creates a [PartialViewResult][58] object that renders a partial view, by using the specified model. (Inherited from [Controller][3].)                                                                                         
[PartialView(String)][60]                                                        | Creates a [PartialViewResult][58] object that renders a partial view, by using the specified view name. (Inherited from [Controller][3].)                                                                                     
[PartialView(String, Object)][61]                                                | Creates a [PartialViewResult][58] object that renders a partial view, by using the specified view name and model. (Inherited from [Controller][3].)                                                                           
[Redirect][62]                                                                   | Creates a [RedirectResult][63] object that redirects to the specified URL. (Inherited from [Controller][3].)                                                                                                                  
[RedirectPermanent][64]                                                          | Returns an instance of the [RedirectResult][63] class with the [Permanent][65] property set to true. (Inherited from [Controller][3].)                                                                                        
[RedirectToAction(String)][66]                                                   | Redirects to the specified action using the action name. (Inherited from [Controller][3].)                                                                                                                                    
[RedirectToAction(String, Object)][67]                                           | Redirects to the specified action using the action name and route values. (Inherited from [Controller][3].)                                                                                                                   
[RedirectToAction(String, RouteValueDictionary)][68]                             | Redirects to the specified action using the action name and route dictionary. (Inherited from [Controller][3].)                                                                                                               
[RedirectToAction(String, String)][69]                                           | Redirects to the specified action using the action name and controller name. (Inherited from [Controller][3].)                                                                                                                
[RedirectToAction(String, String, Object)][70]                                   | Redirects to the specified action using the action name, controller name, and route values. (Inherited from [Controller][3].)                                                                                                 
[RedirectToAction(String, String, RouteValueDictionary)][71]                     | Redirects to the specified action using the action name, controller name, and route dictionary. (Inherited from [Controller][3].)                                                                                             
[RedirectToActionPermanent(String)][72]                                          | Returns an instance of the [RedirectResult][63] class with the [Permanent][65] property set to true using the specified action name. (Inherited from [Controller][3].)                                                        
[RedirectToActionPermanent(String, Object)][73]                                  | Returns an instance of the [RedirectResult][63] class with the [Permanent][65] property set to true using the specified action name, and route values. (Inherited from [Controller][3].)                                      
[RedirectToActionPermanent(String, RouteValueDictionary)][74]                    | Returns an instance of the [RedirectResult][63] class with the [Permanent][65] property set to true using the specified action name, and route values. (Inherited from [Controller][3].)                                      
[RedirectToActionPermanent(String, String)][75]                                  | Returns an instance of the [RedirectResult][63] class with the [Permanent][65] property set to true using the specified action name, and controller name. (Inherited from [Controller][3].)                                   
[RedirectToActionPermanent(String, String, Object)][76]                          | Returns an instance of the [RedirectResult][63] class with the [Permanent][65] property set to true using the specified action name, controller name, and route values. (Inherited from [Controller][3].)                     
[RedirectToActionPermanent(String, String, RouteValueDictionary)][77]            | Returns an instance of the [RedirectResult][63] class with the [Permanent][65] property set to true using the specified action name, controller name, and route values. (Inherited from [Controller][3].)                     
[RedirectToRoute(Object)][78]                                                    | Redirects to the specified route using the specified route values. (Inherited from [Controller][3].)                                                                                                                          
[RedirectToRoute(RouteValueDictionary)][79]                                      | Redirects to the specified route using the route dictionary. (Inherited from [Controller][3].)                                                                                                                                
[RedirectToRoute(String)][80]                                                    | Redirects to the specified route using the route name. (Inherited from [Controller][3].)                                                                                                                                      
[RedirectToRoute(String, Object)][81]                                            | Redirects to the specified route using the route name and route values. (Inherited from [Controller][3].)                                                                                                                     
[RedirectToRoute(String, RouteValueDictionary)][82]                              | Redirects to the specified route using the route name and route dictionary. (Inherited from [Controller][3].)                                                                                                                 
[RedirectToRoutePermanent(Object)][83]                                           | Returns an instance of the [RedirectResult][63] class with the [Permanent][65] property set to true using the specified route values. (Inherited from [Controller][3].)                                                       
[RedirectToRoutePermanent(RouteValueDictionary)][84]                             | Returns an instance of the [RedirectResult][63] class with the [Permanent][65] property set to true using the specified route values. (Inherited from [Controller][3].)                                                       
[RedirectToRoutePermanent(String)][85]                                           | Returns an instance of the [RedirectResult][63] class with the [Permanent][65] property set to true using the specified route name. (Inherited from [Controller][3].)                                                         
[RedirectToRoutePermanent(String, Object)][86]                                   | Returns an instance of the [RedirectResult][63] class with the [Permanent][65] property set to true using the specified route name and route values. (Inherited from [Controller][3].)                                        
[RedirectToRoutePermanent(String, RouteValueDictionary)][87]                     | Returns an instance of the [RedirectResult][63] class with the [Permanent][65] property set to true using the specified route name and route values. (Inherited from [Controller][3].)                                        
[Saved][88]                                                                      | A page that informs the user that his new email was saved.                                                                                                                                                                    
[ToString][89]                                                                   | Returns a string that represents the current object. (Inherited from [Object][1].)                                                                                                                                            
[TryUpdateModel<TModel>(TModel)][90]                                             | Updates the specified model instance using values from the controller's current value provider. (Inherited from [Controller][3].)                                                                                             
[TryUpdateModel<TModel>(TModel, String)][91]                                     | Updates the specified model instance using values from the controller's current value provider and a prefix. (Inherited from [Controller][3].)                                                                                
[TryUpdateModel<TModel>(TModel, String[])][92]                                   | Updates the specified model instance using values from the controller's current value provider and included properties. (Inherited from [Controller][3].)                                                                     
[TryUpdateModel<TModel>(TModel, IValueProvider)][93]                             | Updates the specified model instance using values from the value provider. (Inherited from [Controller][3].)                                                                                                                  
[TryUpdateModel<TModel>(TModel, String, String[])][94]                           | Updates the specified model instance using values from the controller's current value provider, a prefix, and included properties. (Inherited from [Controller][3].)                                                          
[TryUpdateModel<TModel>(TModel, String, IValueProvider)][95]                     | Updates the specified model instance using values from the value provider and a prefix. (Inherited from [Controller][3].)                                                                                                     
[TryUpdateModel<TModel>(TModel, String[], IValueProvider)][96]                   | Updates the specified model instance using values from the value provider and a list of properties to include. (Inherited from [Controller][3].)                                                                              
[TryUpdateModel<TModel>(TModel, String, String[], String[])][97]                 | Updates the specified model instance using values from the controller's current value provider, a prefix, a list of properties to exclude, and a list of properties to include. (Inherited from [Controller][3].)             
[TryUpdateModel<TModel>(TModel, String, String[], IValueProvider)][98]           | Updates the specified model instance using values from the value provider, a prefix, and included properties. (Inherited from [Controller][3].)                                                                               
[TryUpdateModel<TModel>(TModel, String, String[], String[], IValueProvider)][99] | Updates the specified model instance using values from the value provider, a prefix, a list of properties to exclude , and a list of properties to include. (Inherited from [Controller][3].)                                 
[TryValidateModel(Object)][100]                                                  | Validates the specified model instance. (Inherited from [Controller][3].)                                                                                                                                                     
[TryValidateModel(Object, String)][101]                                          | Validates the specified model instance using an HTML prefix. (Inherited from [Controller][3].)                                                                                                                                
[UpdateModel<TModel>(TModel)][102]                                               | Updates the specified model instance using values from the controller's current value provider. (Inherited from [Controller][3].)                                                                                             
[UpdateModel<TModel>(TModel, String)][103]                                       | Updates the specified model instance using values from the controller's current value provider and a prefix. (Inherited from [Controller][3].)                                                                                
[UpdateModel<TModel>(TModel, String[])][104]                                     | Updates the specified model instance using values from the controller object's current value provider. (Inherited from [Controller][3].)                                                                                      
[UpdateModel<TModel>(TModel, IValueProvider)][105]                               | Updates the specified model instance using values from the value provider. (Inherited from [Controller][3].)                                                                                                                  
[UpdateModel<TModel>(TModel, String, String[])][106]                             | Updates the specified model instance using values from the controller's current value provider, a prefix, and included properties. (Inherited from [Controller][3].)                                                          
[UpdateModel<TModel>(TModel, String, IValueProvider)][107]                       | Updates the specified model instance using values from the value provider and a prefix. (Inherited from [Controller][3].)                                                                                                     
[UpdateModel<TModel>(TModel, String[], IValueProvider)][108]                     | Updates the specified model instance using values from the value provider, a prefix, and a list of properties to include. (Inherited from [Controller][3].)                                                                   
[UpdateModel<TModel>(TModel, String, String[], String[])][109]                   | Updates the specified model instance using values from the controller's current value provider, a prefix, a list of properties to exclude, and a list of properties to include. (Inherited from [Controller][3].)             
[UpdateModel<TModel>(TModel, String, String[], IValueProvider)][110]             | Updates the specified model instance using values from the value provider, a prefix, and a list of properties to include. (Inherited from [Controller][3].)                                                                   
[UpdateModel<TModel>(TModel, String, String[], String[], IValueProvider)][111]   | Updates the specified model instance using values from the value provider, a prefix, a list of properties to exclude, and a list of properties to include. (Inherited from [Controller][3].)                                  
[ValidateModel(Object)][112]                                                     | Validates the specified model instance. (Inherited from [Controller][3].)                                                                                                                                                     
[ValidateModel(Object, String)][113]                                             | Validates the specified model instance using an HTML prefix. (Inherited from [Controller][3].)                                                                                                                                
[VerificationSent][114]                                                          | A page that informs the user that the email change verification e-mail was sent.                                                                                                                                              
[Verify][115]                                                                    | The email change verification callback.                                                                                                                                                                                       
[View()][116]                                                                    | Creates a [ViewResult][117] object that renders a view to the response. (Inherited from [Controller][3].)                                                                                                                     
[View(Object)][118]                                                              | Creates a [ViewResult][117] object by using the model that renders a view to the response. (Inherited from [Controller][3].)                                                                                                  
[View(String)][119]                                                              | Creates a [ViewResult][117] object by using the view name that renders a view. (Inherited from [Controller][3].)                                                                                                              
[View(IView)][120]                                                               | Creates a [ViewResult][117] object that renders the specified [IView][121] object. (Inherited from [Controller][3].)                                                                                                          
[View(String, String)][122]                                                      | Creates a [ViewResult][117] object using the view name and master-page name that renders a view to the response. (Inherited from [Controller][3].)                                                                            
[View(String, Object)][123]                                                      | Creates a [ViewResult][117] object by using the view name and model that renders a view to the response. (Inherited from [Controller][3].)                                                                                    
[View(IView, Object)][124]                                                       | Creates a [ViewResult][117] object that renders the specified [IView][121] object. (Inherited from [Controller][3].)                                                                                                          
[View(String, String, Object)][125]                                              | Creates a [ViewResult][117] object using the view name, master-page name, and model that renders a view. (Inherited from [Controller][3].)                                                                                    


Properties
----------

Name                     | Description                                                                                                                                       
------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------- 
[ActionInvoker][126]     | Gets the action invoker for the controller. (Inherited from [Controller][3].)                                                                     
[Binders][127]           | Gets or sets the binder. (Inherited from [Controller][3].)                                                                                        
[Configuration][128]     | The [AccountConfiguration][129] instance for the current request. (Inherited from [BaseController][4].)                                           
[ControllerContext][130] | Gets or sets the controller context. (Inherited from [ControllerBase][2].)                                                                        
[HttpContext][131]       | Gets HTTP-specific information about an individual HTTP request. (Inherited from [Controller][3].)                                                
[ModelState][132]        | Gets the model state dictionary object that contains the state of the model and of model-binding validation. (Inherited from [Controller][3].)    
[Request][133]           | Gets the [HttpRequestBase][134] object for the current HTTP request. (Inherited from [Controller][3].)                                            
[Response][135]          | Gets the [HttpResponseBase][136] object for the current HTTP response. (Inherited from [Controller][3].)                                          
[RouteData][137]         | Gets the route data for the current request. (Inherited from [Controller][3].)                                                                    
[Server][138]            | Gets the [HttpServerUtilityBase][139] object that provides methods that are used during Web request processing. (Inherited from [Controller][3].) 
[Session][140]           | Gets the [HttpSessionStateBase][141] object for the current HTTP request. (Inherited from [Controller][3].)                                       
[TempData][142]          | Gets or sets the dictionary for temporary data. (Inherited from [ControllerBase][2].)                                                             
[TempDataProvider][143]  | Gets the temporary-data provider object that is used to store data for the next request. (Inherited from [Controller][3].)                        
[Url][144]               | Gets the URL helper object that is used to generate URLs by using routing. (Inherited from [Controller][3].)                                      
[User][145]              | Gets the user security information for the current HTTP request. (Inherited from [Controller][3].)                                                
[ValidateRequest][146]   | Gets or sets a value that indicates whether request validation is enabled for this request. (Inherited from [ControllerBase][2].)                 
[ValueProvider][147]     | Gets or sets the value provider for the controller. (Inherited from [ControllerBase][2].)                                                         
[ViewBag][148]           | Gets the dynamic view data dictionary. (Inherited from [ControllerBase][2].)                                                                      
[ViewData][149]          | Gets or sets the dictionary for view data. (Inherited from [ControllerBase][2].)                                                                  


See Also
--------
[MvcAccount.Email.Change Namespace][5]  

[1]: http://msdn2.microsoft.com/en-us/library/e5kfa45b
[2]: http://msdn2.microsoft.com/en-us/library/dd504950
[3]: http://msdn2.microsoft.com/en-us/library/dd460481
[4]: ../../MvcAccount.Shared/BaseController/README.md
[5]: ../README.md
[6]: _ctor.md
[7]: _ctor_1.md
[8]: _ctor_2.md
[9]: Change.md
[10]: Change_1.md
[11]: http://msdn2.microsoft.com/en-us/library/dd470588
[12]: http://msdn2.microsoft.com/en-us/library/dd492713
[13]: http://msdn2.microsoft.com/en-us/library/dd505216
[14]: http://msdn2.microsoft.com/en-us/library/ee264001
[15]: http://msdn2.microsoft.com/en-us/library/ee703613
[16]: http://msdn2.microsoft.com/en-us/library/dd492966
[17]: http://msdn2.microsoft.com/en-us/library/dd492699
[18]: http://msdn2.microsoft.com/en-us/library/bsc2ak47
[19]: http://msdn2.microsoft.com/en-us/library/dd460277
[20]: http://msdn2.microsoft.com/en-us/library/dd505239
[21]: http://msdn2.microsoft.com/en-us/library/dd460208
[22]: http://msdn2.microsoft.com/en-us/library/dd492748
[23]: http://msdn2.microsoft.com/en-us/library/dd493017
[24]: http://msdn2.microsoft.com/en-us/library/dd505251
[25]: http://msdn2.microsoft.com/en-us/library/8f86tw9e
[26]: http://msdn2.microsoft.com/en-us/library/dd492492
[27]: http://msdn2.microsoft.com/en-us/library/dd492762
[28]: http://msdn2.microsoft.com/en-us/library/dd470835
[29]: http://msdn2.microsoft.com/en-us/library/dd505200
[30]: http://msdn2.microsoft.com/en-us/library/dd492593
[31]: http://msdn2.microsoft.com/en-us/library/4k87zsw7
[32]: http://msdn2.microsoft.com/en-us/library/zdee4b3y
[33]: http://msdn2.microsoft.com/en-us/library/dfwy45w9
[34]: http://msdn2.microsoft.com/en-us/library/42892f65
[35]: http://msdn2.microsoft.com/en-us/library/dd492730
[36]: http://msdn2.microsoft.com/en-us/library/gg453938
[37]: http://msdn2.microsoft.com/en-us/library/gg402019
[38]: http://msdn2.microsoft.com/en-us/library/gg402084
[39]: Initialize.md
[40]: ../../MvcAccount.Shared/BaseController/Initialize.md
[41]: http://msdn2.microsoft.com/en-us/library/dd505087
[42]: http://msdn2.microsoft.com/en-us/library/dd492253
[43]: http://msdn2.microsoft.com/en-us/library/dd504936
[44]: http://msdn2.microsoft.com/en-us/library/dd470569
[45]: http://msdn2.microsoft.com/en-us/library/dd470169
[46]: http://msdn2.microsoft.com/en-us/library/ee430920
[47]: http://msdn2.microsoft.com/en-us/library/dd470587
[48]: http://msdn2.microsoft.com/en-us/library/ee430918
[49]: http://msdn2.microsoft.com/en-us/library/ee430908
[50]: http://msdn2.microsoft.com/en-us/library/57ctke0a
[51]: http://msdn2.microsoft.com/en-us/library/dd460283
[52]: http://msdn2.microsoft.com/en-us/library/dd493080
[53]: http://msdn2.microsoft.com/en-us/library/dd470545
[54]: http://msdn2.microsoft.com/en-us/library/dd460532
[55]: http://msdn2.microsoft.com/en-us/library/dd470615
[56]: http://msdn2.microsoft.com/en-us/library/dd504998
[57]: http://msdn2.microsoft.com/en-us/library/dd460345
[58]: http://msdn2.microsoft.com/en-us/library/dd470537
[59]: http://msdn2.microsoft.com/en-us/library/dd470145
[60]: http://msdn2.microsoft.com/en-us/library/dd505247
[61]: http://msdn2.microsoft.com/en-us/library/dd460161
[62]: http://msdn2.microsoft.com/en-us/library/dd492671
[63]: http://msdn2.microsoft.com/en-us/library/dd492890
[64]: http://msdn2.microsoft.com/en-us/library/gg401950
[65]: http://msdn2.microsoft.com/en-us/library/gg401978
[66]: http://msdn2.microsoft.com/en-us/library/dd460241
[67]: http://msdn2.microsoft.com/en-us/library/dd460291
[68]: http://msdn2.microsoft.com/en-us/library/dd492939
[69]: http://msdn2.microsoft.com/en-us/library/dd470594
[70]: http://msdn2.microsoft.com/en-us/library/dd460311
[71]: http://msdn2.microsoft.com/en-us/library/dd505283
[72]: http://msdn2.microsoft.com/en-us/library/gg453902
[73]: http://msdn2.microsoft.com/en-us/library/gg453883
[74]: http://msdn2.microsoft.com/en-us/library/gg453920
[75]: http://msdn2.microsoft.com/en-us/library/gg453904
[76]: http://msdn2.microsoft.com/en-us/library/gg401893
[77]: http://msdn2.microsoft.com/en-us/library/gg453864
[78]: http://msdn2.microsoft.com/en-us/library/dd470174
[79]: http://msdn2.microsoft.com/en-us/library/dd470199
[80]: http://msdn2.microsoft.com/en-us/library/dd492497
[81]: http://msdn2.microsoft.com/en-us/library/dd470522
[82]: http://msdn2.microsoft.com/en-us/library/dd505024
[83]: http://msdn2.microsoft.com/en-us/library/gg453870
[84]: http://msdn2.microsoft.com/en-us/library/gg453933
[85]: http://msdn2.microsoft.com/en-us/library/gg453941
[86]: http://msdn2.microsoft.com/en-us/library/gg416644
[87]: http://msdn2.microsoft.com/en-us/library/gg453955
[88]: Saved.md
[89]: http://msdn2.microsoft.com/en-us/library/7bxwbwt2
[90]: http://msdn2.microsoft.com/en-us/library/dd460189
[91]: http://msdn2.microsoft.com/en-us/library/dd493137
[92]: http://msdn2.microsoft.com/en-us/library/dd470377
[93]: http://msdn2.microsoft.com/en-us/library/ee728634
[94]: http://msdn2.microsoft.com/en-us/library/dd470908
[95]: http://msdn2.microsoft.com/en-us/library/ee721265
[96]: http://msdn2.microsoft.com/en-us/library/ee703530
[97]: http://msdn2.microsoft.com/en-us/library/dd492957
[98]: http://msdn2.microsoft.com/en-us/library/ee703635
[99]: http://msdn2.microsoft.com/en-us/library/ee703452
[100]: http://msdn2.microsoft.com/en-us/library/ff356143
[101]: http://msdn2.microsoft.com/en-us/library/ff356144
[102]: http://msdn2.microsoft.com/en-us/library/dd470933
[103]: http://msdn2.microsoft.com/en-us/library/dd470808
[104]: http://msdn2.microsoft.com/en-us/library/dd492193
[105]: http://msdn2.microsoft.com/en-us/library/ee703656
[106]: http://msdn2.microsoft.com/en-us/library/dd505127
[107]: http://msdn2.microsoft.com/en-us/library/ee728613
[108]: http://msdn2.microsoft.com/en-us/library/ee703486
[109]: http://msdn2.microsoft.com/en-us/library/dd470388
[110]: http://msdn2.microsoft.com/en-us/library/ee703664
[111]: http://msdn2.microsoft.com/en-us/library/ee703509
[112]: http://msdn2.microsoft.com/en-us/library/ff356131
[113]: http://msdn2.microsoft.com/en-us/library/ff356138
[114]: VerificationSent.md
[115]: Verify.md
[116]: http://msdn2.microsoft.com/en-us/library/dd460331
[117]: http://msdn2.microsoft.com/en-us/library/dd505228
[118]: http://msdn2.microsoft.com/en-us/library/dd492930
[119]: http://msdn2.microsoft.com/en-us/library/dd460352
[120]: http://msdn2.microsoft.com/en-us/library/dd460327
[121]: http://msdn2.microsoft.com/en-us/library/dd470357
[122]: http://msdn2.microsoft.com/en-us/library/dd470743
[123]: http://msdn2.microsoft.com/en-us/library/dd460310
[124]: http://msdn2.microsoft.com/en-us/library/dd470544
[125]: http://msdn2.microsoft.com/en-us/library/dd492244
[126]: http://msdn2.microsoft.com/en-us/library/dd505131
[127]: http://msdn2.microsoft.com/en-us/library/dd492975
[128]: ../../MvcAccount.Shared/BaseController/Configuration.md
[129]: ../../MvcAccount/AccountConfiguration/README.md
[130]: http://msdn2.microsoft.com/en-us/library/dd505205
[131]: http://msdn2.microsoft.com/en-us/library/dd470552
[132]: http://msdn2.microsoft.com/en-us/library/dd504944
[133]: http://msdn2.microsoft.com/en-us/library/dd492753
[134]: http://msdn2.microsoft.com/en-us/library/cc680816
[135]: http://msdn2.microsoft.com/en-us/library/dd470578
[136]: http://msdn2.microsoft.com/en-us/library/cc680930
[137]: http://msdn2.microsoft.com/en-us/library/dd492210
[138]: http://msdn2.microsoft.com/en-us/library/dd505016
[139]: http://msdn2.microsoft.com/en-us/library/cc679943
[140]: http://msdn2.microsoft.com/en-us/library/dd492995
[141]: http://msdn2.microsoft.com/en-us/library/cc679805
[142]: http://msdn2.microsoft.com/en-us/library/dd470383
[143]: http://msdn2.microsoft.com/en-us/library/dd460181
[144]: http://msdn2.microsoft.com/en-us/library/dd492973
[145]: http://msdn2.microsoft.com/en-us/library/dd493019
[146]: http://msdn2.microsoft.com/en-us/library/dd460533
[147]: http://msdn2.microsoft.com/en-us/library/dd470838
[148]: http://msdn2.microsoft.com/en-us/library/gg480763
[149]: http://msdn2.microsoft.com/en-us/library/dd493086