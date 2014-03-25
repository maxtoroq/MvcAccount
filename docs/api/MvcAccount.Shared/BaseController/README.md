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

Name                                                                                | Description                                                                                                                                                                                                                   
----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
[Content(String)][12]                                                               | Creates a content result object by using a string. (Inherited from [Controller][3].)                                                                                                                                          
[Content(String, String)][13]                                                       | Creates a content result object by using a string and the content type. (Inherited from [Controller][3].)                                                                                                                     
[Content(String, String, Encoding)][14]                                             | Creates a content result object by using a string, the content type, and content encoding. (Inherited from [Controller][3].)                                                                                                  
[CreateActionInvoker][15]                                                           | Creates an action invoker. (Inherited from [Controller][3].)                                                                                                                                                                  
[CreateTempDataProvider][16]                                                        | Creates a temporary data provider. (Inherited from [Controller][3].)                                                                                                                                                          
[Dispose()][17]                                                                     | Releases all resources that are used by the current instance of the [Controller][3] class. (Inherited from [Controller][3].)                                                                                                  
[Dispose(Boolean)][18]                                                              | Releases unmanaged resources and optionally releases managed resources. (Inherited from [Controller][3].)                                                                                                                     
[Equals][19]                                                                        | Determines whether the specified [Object][1] is equal to the current [Object][1]. (Inherited from [Object][1].)                                                                                                               
[Execute][20]                                                                       | Executes the specified request context. (Inherited from [ControllerBase][2].)                                                                                                                                                 
[ExecuteCore][21]                                                                   | Invokes the action in the current controller context. (Inherited from [Controller][3].)                                                                                                                                       
[File(Byte[], String)][22]                                                          | Creates a [FileContentResult][23] object by using the file contents and file type. (Inherited from [Controller][3].)                                                                                                          
[File(Stream, String)][24]                                                          | Creates a [FileStreamResult][25] object by using the [Stream][26] object and content type. (Inherited from [Controller][3].)                                                                                                  
[File(String, String)][27]                                                          | Creates a [FilePathResult][28] object by using the file name and the content type. (Inherited from [Controller][3].)                                                                                                          
[File(Byte[], String, String)][29]                                                  | Creates a [FileContentResult][23] object by using the file contents, content type, and the destination file name. (Inherited from [Controller][3].)                                                                           
[File(Stream, String, String)][30]                                                  | Creates a [FileStreamResult][25] object using the [Stream][26] object, the content type, and the target file name. (Inherited from [Controller][3].)                                                                          
[File(String, String, String)][31]                                                  | Creates a [FilePathResult][28] object by using the file name, the content type, and the file download name. (Inherited from [Controller][3].)                                                                                 
[Finalize][32]                                                                      | Allows an object to try to free resources and perform other cleanup operations before it is reclaimed by garbage collection. (Inherited from [Object][1].)                                                                    
[GetHashCode][33]                                                                   | Serves as a hash function for a particular type. (Inherited from [Object][1].)                                                                                                                                                
[GetType][34]                                                                       | Gets the [Type][35] of the current instance. (Inherited from [Object][1].)                                                                                                                                                    
[HandleUnknownAction][36]                                                           | Called when a request matches this controller, but no method with the specified action name is found in the controller. (Inherited from [Controller][3].)                                                                     
[HttpNotFound()][37]                                                                | Returns an instance of the [HttpNotFoundResult][38] class. (Inherited from [Controller][3].)                                                                                                                                  
[HttpNotFound(String)][39]                                                          | Returns an instance of the [HttpNotFoundResult][38] class. (Inherited from [Controller][3].)                                                                                                                                  
[Initialize][40]                                                                    | Initializes data that might not be available when the constructor is called. (Overrides [Controller.Initialize(RequestContext)][41].)                                                                                         
[JavaScript][42]                                                                    | Creates a [JavaScriptResult][43] object. (Inherited from [Controller][3].)                                                                                                                                                    
[Json(Object)][44]                                                                  | Creates a [JsonResult][45] object that serializes the specified object to JavaScript Object Notation (JSON). (Inherited from [Controller][3].)                                                                                
[Json(Object, String)][46]                                                          | Creates a [JsonResult][45] object that serializes the specified object to JavaScript Object Notation (JSON) format. (Inherited from [Controller][3].)                                                                         
[Json(Object, JsonRequestBehavior)][47]                                             | Creates a [JsonResult][45] object that serializes the specified object to JavaScript Object Notation (JSON) format using the specified JSON request behavior. (Inherited from [Controller][3].)                               
[Json(Object, String, Encoding)][48]                                                | Creates a [JsonResult][45] object that serializes the specified object to JavaScript Object Notation (JSON) format. (Inherited from [Controller][3].)                                                                         
[Json(Object, String, JsonRequestBehavior)][49]                                     | Creates a [JsonResult][45] object that serializes the specified object to JavaScript Object Notation (JSON) format using the specified content type and JSON request behavior. (Inherited from [Controller][3].)              
[Json(Object, String, Encoding, JsonRequestBehavior)][50]                           | Creates a [JsonResult][45] object that serializes the specified object to JavaScript Object Notation (JSON) format using the content type, content encoding, and the JSON request behavior. (Inherited from [Controller][3].) 
[MemberwiseClone][51]                                                               | Creates a shallow copy of the current [Object][1]. (Inherited from [Object][1].)                                                                                                                                              
[OnActionExecuted][52]                                                              | Called after the action method is invoked. (Inherited from [Controller][3].)                                                                                                                                                  
[OnActionExecuting][53]                                                             | Called before the action method is invoked. (Inherited from [Controller][3].)                                                                                                                                                 
[OnAuthorization][54]                                                               | Called when authorization occurs. (Inherited from [Controller][3].)                                                                                                                                                           
[OnException][55]                                                                   | Called when an unhandled exception occurs in the action. (Inherited from [Controller][3].)                                                                                                                                    
[OnResultExecuted][56]                                                              | Called after the action result that is returned by an action method is executed. (Inherited from [Controller][3].)                                                                                                            
[OnResultExecuting][57]                                                             | Called before the action result that is returned by an action method is executed. (Inherited from [Controller][3].)                                                                                                           
[PartialView()][58]                                                                 | Creates a [PartialViewResult][59] object that renders a partial view. (Inherited from [Controller][3].)                                                                                                                       
[PartialView(Object)][60]                                                           | Creates a [PartialViewResult][59] object that renders a partial view, by using the specified model. (Inherited from [Controller][3].)                                                                                         
[PartialView(String)][61]                                                           | Creates a [PartialViewResult][59] object that renders a partial view, by using the specified view name. (Inherited from [Controller][3].)                                                                                     
[PartialView(String, Object)][62]                                                   | Creates a [PartialViewResult][59] object that renders a partial view, by using the specified view name and model. (Inherited from [Controller][3].)                                                                           
[Redirect][63]                                                                      | Creates a [RedirectResult][64] object that redirects to the specified URL. (Inherited from [Controller][3].)                                                                                                                  
[RedirectPermanent][65]                                                             | Returns an instance of the [RedirectResult][64] class with the [Permanent][66] property set to true. (Inherited from [Controller][3].)                                                                                        
[RedirectToAction(String)][67]                                                      | Redirects to the specified action using the action name. (Inherited from [Controller][3].)                                                                                                                                    
[RedirectToAction(String, Object)][68]                                              | Redirects to the specified action using the action name and route values. (Inherited from [Controller][3].)                                                                                                                   
[RedirectToAction(String, RouteValueDictionary)][69]                                | Redirects to the specified action using the action name and route dictionary. (Inherited from [Controller][3].)                                                                                                               
[RedirectToAction(String, String)][70]                                              | Redirects to the specified action using the action name and controller name. (Inherited from [Controller][3].)                                                                                                                
[RedirectToAction(String, String, Object)][71]                                      | Redirects to the specified action using the action name, controller name, and route values. (Inherited from [Controller][3].)                                                                                                 
[RedirectToAction(String, String, RouteValueDictionary)][72]                        | Redirects to the specified action using the action name, controller name, and route dictionary. (Inherited from [Controller][3].)                                                                                             
[RedirectToActionPermanent(String)][73]                                             | Returns an instance of the [RedirectResult][64] class with the [Permanent][66] property set to true using the specified action name. (Inherited from [Controller][3].)                                                        
[RedirectToActionPermanent(String, Object)][74]                                     | Returns an instance of the [RedirectResult][64] class with the [Permanent][66] property set to true using the specified action name, and route values. (Inherited from [Controller][3].)                                      
[RedirectToActionPermanent(String, RouteValueDictionary)][75]                       | Returns an instance of the [RedirectResult][64] class with the [Permanent][66] property set to true using the specified action name, and route values. (Inherited from [Controller][3].)                                      
[RedirectToActionPermanent(String, String)][76]                                     | Returns an instance of the [RedirectResult][64] class with the [Permanent][66] property set to true using the specified action name, and controller name. (Inherited from [Controller][3].)                                   
[RedirectToActionPermanent(String, String, Object)][77]                             | Returns an instance of the [RedirectResult][64] class with the [Permanent][66] property set to true using the specified action name, controller name, and route values. (Inherited from [Controller][3].)                     
[RedirectToActionPermanent(String, String, RouteValueDictionary)][78]               | Returns an instance of the [RedirectResult][64] class with the [Permanent][66] property set to true using the specified action name, controller name, and route values. (Inherited from [Controller][3].)                     
[RedirectToRoute(Object)][79]                                                       | Redirects to the specified route using the specified route values. (Inherited from [Controller][3].)                                                                                                                          
[RedirectToRoute(RouteValueDictionary)][80]                                         | Redirects to the specified route using the route dictionary. (Inherited from [Controller][3].)                                                                                                                                
[RedirectToRoute(String)][81]                                                       | Redirects to the specified route using the route name. (Inherited from [Controller][3].)                                                                                                                                      
[RedirectToRoute(String, Object)][82]                                               | Redirects to the specified route using the route name and route values. (Inherited from [Controller][3].)                                                                                                                     
[RedirectToRoute(String, RouteValueDictionary)][83]                                 | Redirects to the specified route using the route name and route dictionary. (Inherited from [Controller][3].)                                                                                                                 
[RedirectToRoutePermanent(Object)][84]                                              | Returns an instance of the [RedirectResult][64] class with the [Permanent][66] property set to true using the specified route values. (Inherited from [Controller][3].)                                                       
[RedirectToRoutePermanent(RouteValueDictionary)][85]                                | Returns an instance of the [RedirectResult][64] class with the [Permanent][66] property set to true using the specified route values. (Inherited from [Controller][3].)                                                       
[RedirectToRoutePermanent(String)][86]                                              | Returns an instance of the [RedirectResult][64] class with the [Permanent][66] property set to true using the specified route name. (Inherited from [Controller][3].)                                                         
[RedirectToRoutePermanent(String, Object)][87]                                      | Returns an instance of the [RedirectResult][64] class with the [Permanent][66] property set to true using the specified route name and route values. (Inherited from [Controller][3].)                                        
[RedirectToRoutePermanent(String, RouteValueDictionary)][88]                        | Returns an instance of the [RedirectResult][64] class with the [Permanent][66] property set to true using the specified route name and route values. (Inherited from [Controller][3].)                                        
[ToString][89]                                                                      | Returns a string that represents the current object. (Inherited from [Object][1].)                                                                                                                                            
[TryUpdateModel&lt;TModel>(TModel)][90]                                             | Updates the specified model instance using values from the controller's current value provider. (Inherited from [Controller][3].)                                                                                             
[TryUpdateModel&lt;TModel>(TModel, String)][91]                                     | Updates the specified model instance using values from the controller's current value provider and a prefix. (Inherited from [Controller][3].)                                                                                
[TryUpdateModel&lt;TModel>(TModel, String[])][92]                                   | Updates the specified model instance using values from the controller's current value provider and included properties. (Inherited from [Controller][3].)                                                                     
[TryUpdateModel&lt;TModel>(TModel, IValueProvider)][93]                             | Updates the specified model instance using values from the value provider. (Inherited from [Controller][3].)                                                                                                                  
[TryUpdateModel&lt;TModel>(TModel, String, String[])][94]                           | Updates the specified model instance using values from the controller's current value provider, a prefix, and included properties. (Inherited from [Controller][3].)                                                          
[TryUpdateModel&lt;TModel>(TModel, String, IValueProvider)][95]                     | Updates the specified model instance using values from the value provider and a prefix. (Inherited from [Controller][3].)                                                                                                     
[TryUpdateModel&lt;TModel>(TModel, String[], IValueProvider)][96]                   | Updates the specified model instance using values from the value provider and a list of properties to include. (Inherited from [Controller][3].)                                                                              
[TryUpdateModel&lt;TModel>(TModel, String, String[], String[])][97]                 | Updates the specified model instance using values from the controller's current value provider, a prefix, a list of properties to exclude, and a list of properties to include. (Inherited from [Controller][3].)             
[TryUpdateModel&lt;TModel>(TModel, String, String[], IValueProvider)][98]           | Updates the specified model instance using values from the value provider, a prefix, and included properties. (Inherited from [Controller][3].)                                                                               
[TryUpdateModel&lt;TModel>(TModel, String, String[], String[], IValueProvider)][99] | Updates the specified model instance using values from the value provider, a prefix, a list of properties to exclude , and a list of properties to include. (Inherited from [Controller][3].)                                 
[TryValidateModel(Object)][100]                                                     | Validates the specified model instance. (Inherited from [Controller][3].)                                                                                                                                                     
[TryValidateModel(Object, String)][101]                                             | Validates the specified model instance using an HTML prefix. (Inherited from [Controller][3].)                                                                                                                                
[UpdateModel&lt;TModel>(TModel)][102]                                               | Updates the specified model instance using values from the controller's current value provider. (Inherited from [Controller][3].)                                                                                             
[UpdateModel&lt;TModel>(TModel, String)][103]                                       | Updates the specified model instance using values from the controller's current value provider and a prefix. (Inherited from [Controller][3].)                                                                                
[UpdateModel&lt;TModel>(TModel, String[])][104]                                     | Updates the specified model instance using values from the controller object's current value provider. (Inherited from [Controller][3].)                                                                                      
[UpdateModel&lt;TModel>(TModel, IValueProvider)][105]                               | Updates the specified model instance using values from the value provider. (Inherited from [Controller][3].)                                                                                                                  
[UpdateModel&lt;TModel>(TModel, String, String[])][106]                             | Updates the specified model instance using values from the controller's current value provider, a prefix, and included properties. (Inherited from [Controller][3].)                                                          
[UpdateModel&lt;TModel>(TModel, String, IValueProvider)][107]                       | Updates the specified model instance using values from the value provider and a prefix. (Inherited from [Controller][3].)                                                                                                     
[UpdateModel&lt;TModel>(TModel, String[], IValueProvider)][108]                     | Updates the specified model instance using values from the value provider, a prefix, and a list of properties to include. (Inherited from [Controller][3].)                                                                   
[UpdateModel&lt;TModel>(TModel, String, String[], String[])][109]                   | Updates the specified model instance using values from the controller's current value provider, a prefix, a list of properties to exclude, and a list of properties to include. (Inherited from [Controller][3].)             
[UpdateModel&lt;TModel>(TModel, String, String[], IValueProvider)][110]             | Updates the specified model instance using values from the value provider, a prefix, and a list of properties to include. (Inherited from [Controller][3].)                                                                   
[UpdateModel&lt;TModel>(TModel, String, String[], String[], IValueProvider)][111]   | Updates the specified model instance using values from the value provider, a prefix, a list of properties to exclude, and a list of properties to include. (Inherited from [Controller][3].)                                  
[ValidateModel(Object)][112]                                                        | Validates the specified model instance. (Inherited from [Controller][3].)                                                                                                                                                     
[ValidateModel(Object, String)][113]                                                | Validates the specified model instance using an HTML prefix. (Inherited from [Controller][3].)                                                                                                                                
[View()][114]                                                                       | Creates a [ViewResult][115] object that renders a view to the response. (Inherited from [Controller][3].)                                                                                                                     
[View(Object)][116]                                                                 | Creates a [ViewResult][115] object by using the model that renders a view to the response. (Inherited from [Controller][3].)                                                                                                  
[View(String)][117]                                                                 | Creates a [ViewResult][115] object by using the view name that renders a view. (Inherited from [Controller][3].)                                                                                                              
[View(IView)][118]                                                                  | Creates a [ViewResult][115] object that renders the specified [IView][119] object. (Inherited from [Controller][3].)                                                                                                          
[View(String, String)][120]                                                         | Creates a [ViewResult][115] object using the view name and master-page name that renders a view to the response. (Inherited from [Controller][3].)                                                                            
[View(String, Object)][121]                                                         | Creates a [ViewResult][115] object by using the view name and model that renders a view to the response. (Inherited from [Controller][3].)                                                                                    
[View(IView, Object)][122]                                                          | Creates a [ViewResult][115] object that renders the specified [IView][119] object. (Inherited from [Controller][3].)                                                                                                          
[View(String, String, Object)][123]                                                 | Creates a [ViewResult][115] object using the view name, master-page name, and model that renders a view. (Inherited from [Controller][3].)                                                                                    


Properties
----------

Name                     | Description                                                                                                                                       
------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------- 
[ActionInvoker][124]     | Gets the action invoker for the controller. (Inherited from [Controller][3].)                                                                     
[Binders][125]           | Gets or sets the binder. (Inherited from [Controller][3].)                                                                                        
[Configuration][126]     | The [AccountConfiguration][127] instance for the current request.                                                                                 
[ControllerContext][128] | Gets or sets the controller context. (Inherited from [ControllerBase][2].)                                                                        
[HttpContext][129]       | Gets HTTP-specific information about an individual HTTP request. (Inherited from [Controller][3].)                                                
[ModelState][130]        | Gets the model state dictionary object that contains the state of the model and of model-binding validation. (Inherited from [Controller][3].)    
[Request][131]           | Gets the [HttpRequestBase][132] object for the current HTTP request. (Inherited from [Controller][3].)                                            
[Response][133]          | Gets the [HttpResponseBase][134] object for the current HTTP response. (Inherited from [Controller][3].)                                          
[RouteData][135]         | Gets the route data for the current request. (Inherited from [Controller][3].)                                                                    
[Server][136]            | Gets the [HttpServerUtilityBase][137] object that provides methods that are used during Web request processing. (Inherited from [Controller][3].) 
[Session][138]           | Gets the [HttpSessionStateBase][139] object for the current HTTP request. (Inherited from [Controller][3].)                                       
[TempData][140]          | Gets or sets the dictionary for temporary data. (Inherited from [ControllerBase][2].)                                                             
[TempDataProvider][141]  | Gets the temporary-data provider object that is used to store data for the next request. (Inherited from [Controller][3].)                        
[Url][142]               | Gets the URL helper object that is used to generate URLs by using routing. (Inherited from [Controller][3].)                                      
[User][143]              | Gets the user security information for the current HTTP request. (Inherited from [Controller][3].)                                                
[ValidateRequest][144]   | Gets or sets a value that indicates whether request validation is enabled for this request. (Inherited from [ControllerBase][2].)                 
[ValueProvider][145]     | Gets or sets the value provider for the controller. (Inherited from [ControllerBase][2].)                                                         
[ViewBag][146]           | Gets the dynamic view data dictionary. (Inherited from [ControllerBase][2].)                                                                      
[ViewData][147]          | Gets or sets the dictionary for view data. (Inherited from [ControllerBase][2].)                                                                  


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
[12]: http://msdn.microsoft.com/en-us/library/dd470588
[13]: http://msdn.microsoft.com/en-us/library/dd492713
[14]: http://msdn.microsoft.com/en-us/library/dd505216
[15]: http://msdn.microsoft.com/en-us/library/ee264001
[16]: http://msdn.microsoft.com/en-us/library/ee703613
[17]: http://msdn.microsoft.com/en-us/library/dd492966
[18]: http://msdn.microsoft.com/en-us/library/dd492699
[19]: http://msdn.microsoft.com/en-us/library/bsc2ak47
[20]: http://msdn.microsoft.com/en-us/library/dd460277
[21]: http://msdn.microsoft.com/en-us/library/dd505239
[22]: http://msdn.microsoft.com/en-us/library/dd460208
[23]: http://msdn.microsoft.com/en-us/library/dd492748
[24]: http://msdn.microsoft.com/en-us/library/dd493017
[25]: http://msdn.microsoft.com/en-us/library/dd505251
[26]: http://msdn.microsoft.com/en-us/library/8f86tw9e
[27]: http://msdn.microsoft.com/en-us/library/dd492492
[28]: http://msdn.microsoft.com/en-us/library/dd492762
[29]: http://msdn.microsoft.com/en-us/library/dd470835
[30]: http://msdn.microsoft.com/en-us/library/dd505200
[31]: http://msdn.microsoft.com/en-us/library/dd492593
[32]: http://msdn.microsoft.com/en-us/library/4k87zsw7
[33]: http://msdn.microsoft.com/en-us/library/zdee4b3y
[34]: http://msdn.microsoft.com/en-us/library/dfwy45w9
[35]: http://msdn.microsoft.com/en-us/library/42892f65
[36]: http://msdn.microsoft.com/en-us/library/dd492730
[37]: http://msdn.microsoft.com/en-us/library/gg453938
[38]: http://msdn.microsoft.com/en-us/library/gg402019
[39]: http://msdn.microsoft.com/en-us/library/gg402084
[40]: Initialize.md
[41]: http://msdn.microsoft.com/en-us/library/dd470201
[42]: http://msdn.microsoft.com/en-us/library/dd505087
[43]: http://msdn.microsoft.com/en-us/library/dd492253
[44]: http://msdn.microsoft.com/en-us/library/dd504936
[45]: http://msdn.microsoft.com/en-us/library/dd470569
[46]: http://msdn.microsoft.com/en-us/library/dd470169
[47]: http://msdn.microsoft.com/en-us/library/ee430920
[48]: http://msdn.microsoft.com/en-us/library/dd470587
[49]: http://msdn.microsoft.com/en-us/library/ee430918
[50]: http://msdn.microsoft.com/en-us/library/ee430908
[51]: http://msdn.microsoft.com/en-us/library/57ctke0a
[52]: http://msdn.microsoft.com/en-us/library/dd460283
[53]: http://msdn.microsoft.com/en-us/library/dd493080
[54]: http://msdn.microsoft.com/en-us/library/dd470545
[55]: http://msdn.microsoft.com/en-us/library/dd460532
[56]: http://msdn.microsoft.com/en-us/library/dd470615
[57]: http://msdn.microsoft.com/en-us/library/dd504998
[58]: http://msdn.microsoft.com/en-us/library/dd460345
[59]: http://msdn.microsoft.com/en-us/library/dd470537
[60]: http://msdn.microsoft.com/en-us/library/dd470145
[61]: http://msdn.microsoft.com/en-us/library/dd505247
[62]: http://msdn.microsoft.com/en-us/library/dd460161
[63]: http://msdn.microsoft.com/en-us/library/dd492671
[64]: http://msdn.microsoft.com/en-us/library/dd492890
[65]: http://msdn.microsoft.com/en-us/library/gg401950
[66]: http://msdn.microsoft.com/en-us/library/gg401978
[67]: http://msdn.microsoft.com/en-us/library/dd460241
[68]: http://msdn.microsoft.com/en-us/library/dd460291
[69]: http://msdn.microsoft.com/en-us/library/dd492939
[70]: http://msdn.microsoft.com/en-us/library/dd470594
[71]: http://msdn.microsoft.com/en-us/library/dd460311
[72]: http://msdn.microsoft.com/en-us/library/dd505283
[73]: http://msdn.microsoft.com/en-us/library/gg453902
[74]: http://msdn.microsoft.com/en-us/library/gg453883
[75]: http://msdn.microsoft.com/en-us/library/gg453920
[76]: http://msdn.microsoft.com/en-us/library/gg453904
[77]: http://msdn.microsoft.com/en-us/library/gg401893
[78]: http://msdn.microsoft.com/en-us/library/gg453864
[79]: http://msdn.microsoft.com/en-us/library/dd470174
[80]: http://msdn.microsoft.com/en-us/library/dd470199
[81]: http://msdn.microsoft.com/en-us/library/dd492497
[82]: http://msdn.microsoft.com/en-us/library/dd470522
[83]: http://msdn.microsoft.com/en-us/library/dd505024
[84]: http://msdn.microsoft.com/en-us/library/gg453870
[85]: http://msdn.microsoft.com/en-us/library/gg453933
[86]: http://msdn.microsoft.com/en-us/library/gg453941
[87]: http://msdn.microsoft.com/en-us/library/gg416644
[88]: http://msdn.microsoft.com/en-us/library/gg453955
[89]: http://msdn.microsoft.com/en-us/library/7bxwbwt2
[90]: http://msdn.microsoft.com/en-us/library/dd460189
[91]: http://msdn.microsoft.com/en-us/library/dd493137
[92]: http://msdn.microsoft.com/en-us/library/dd470377
[93]: http://msdn.microsoft.com/en-us/library/ee728634
[94]: http://msdn.microsoft.com/en-us/library/dd470908
[95]: http://msdn.microsoft.com/en-us/library/ee721265
[96]: http://msdn.microsoft.com/en-us/library/ee703530
[97]: http://msdn.microsoft.com/en-us/library/dd492957
[98]: http://msdn.microsoft.com/en-us/library/ee703635
[99]: http://msdn.microsoft.com/en-us/library/ee703452
[100]: http://msdn.microsoft.com/en-us/library/ff356143
[101]: http://msdn.microsoft.com/en-us/library/ff356144
[102]: http://msdn.microsoft.com/en-us/library/dd470933
[103]: http://msdn.microsoft.com/en-us/library/dd470808
[104]: http://msdn.microsoft.com/en-us/library/dd492193
[105]: http://msdn.microsoft.com/en-us/library/ee703656
[106]: http://msdn.microsoft.com/en-us/library/dd505127
[107]: http://msdn.microsoft.com/en-us/library/ee728613
[108]: http://msdn.microsoft.com/en-us/library/ee703486
[109]: http://msdn.microsoft.com/en-us/library/dd470388
[110]: http://msdn.microsoft.com/en-us/library/ee703664
[111]: http://msdn.microsoft.com/en-us/library/ee703509
[112]: http://msdn.microsoft.com/en-us/library/ff356131
[113]: http://msdn.microsoft.com/en-us/library/ff356138
[114]: http://msdn.microsoft.com/en-us/library/dd460331
[115]: http://msdn.microsoft.com/en-us/library/dd505228
[116]: http://msdn.microsoft.com/en-us/library/dd492930
[117]: http://msdn.microsoft.com/en-us/library/dd460352
[118]: http://msdn.microsoft.com/en-us/library/dd460327
[119]: http://msdn.microsoft.com/en-us/library/dd470357
[120]: http://msdn.microsoft.com/en-us/library/dd470743
[121]: http://msdn.microsoft.com/en-us/library/dd460310
[122]: http://msdn.microsoft.com/en-us/library/dd470544
[123]: http://msdn.microsoft.com/en-us/library/dd492244
[124]: http://msdn.microsoft.com/en-us/library/dd505131
[125]: http://msdn.microsoft.com/en-us/library/dd492975
[126]: Configuration.md
[127]: ../../MvcAccount/AccountConfiguration/README.md
[128]: http://msdn.microsoft.com/en-us/library/dd505205
[129]: http://msdn.microsoft.com/en-us/library/dd470552
[130]: http://msdn.microsoft.com/en-us/library/dd504944
[131]: http://msdn.microsoft.com/en-us/library/dd492753
[132]: http://msdn.microsoft.com/en-us/library/cc680816
[133]: http://msdn.microsoft.com/en-us/library/dd470578
[134]: http://msdn.microsoft.com/en-us/library/cc680930
[135]: http://msdn.microsoft.com/en-us/library/dd492210
[136]: http://msdn.microsoft.com/en-us/library/dd505016
[137]: http://msdn.microsoft.com/en-us/library/cc679943
[138]: http://msdn.microsoft.com/en-us/library/dd492995
[139]: http://msdn.microsoft.com/en-us/library/cc679805
[140]: http://msdn.microsoft.com/en-us/library/dd470383
[141]: http://msdn.microsoft.com/en-us/library/dd460181
[142]: http://msdn.microsoft.com/en-us/library/dd492973
[143]: http://msdn.microsoft.com/en-us/library/dd493019
[144]: http://msdn.microsoft.com/en-us/library/dd460533
[145]: http://msdn.microsoft.com/en-us/library/dd470838
[146]: http://msdn.microsoft.com/en-us/library/gg480763
[147]: http://msdn.microsoft.com/en-us/library/dd493086