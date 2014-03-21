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
public class ChangeController : BaseController
```

The **ChangeController** type exposes the following members.


Constructors
------------

Name                                                      | Description                                                                                                   
--------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------- 
[ChangeController()][6]                                   | Initializes a new instance of the **ChangeController** class.                                                 
[ChangeController(AccountRepository, PasswordService)][7] | Initializes a new instance of the **ChangeController** class, with the provided *repo* and *passwordService*. 


Methods
-------

Name                                                                             | Description                                                                                                                                                                                                                   
-------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
[Change()][8]                                                                    | The change password page.                                                                                                                                                                                                     
[Change(ChangeInput, FormButton)][9]                                             | Attempts to change the password.                                                                                                                                                                                              
[Content(String)][10]                                                            | Creates a content result object by using a string. (Inherited from [Controller][3].)                                                                                                                                          
[Content(String, String)][11]                                                    | Creates a content result object by using a string and the content type. (Inherited from [Controller][3].)                                                                                                                     
[Content(String, String, Encoding)][12]                                          | Creates a content result object by using a string, the content type, and content encoding. (Inherited from [Controller][3].)                                                                                                  
[CreateActionInvoker][13]                                                        | Creates an action invoker. (Inherited from [Controller][3].)                                                                                                                                                                  
[CreateTempDataProvider][14]                                                     | Creates a temporary data provider. (Inherited from [Controller][3].)                                                                                                                                                          
[Dispose()][15]                                                                  | Releases all resources that are used by the current instance of the [Controller][3] class. (Inherited from [Controller][3].)                                                                                                  
[Dispose(Boolean)][16]                                                           | Releases unmanaged resources and optionally releases managed resources. (Inherited from [Controller][3].)                                                                                                                     
[Equals][17]                                                                     | Determines whether the specified [Object][1] is equal to the current [Object][1]. (Inherited from [Object][1].)                                                                                                               
[Execute][18]                                                                    | Executes the specified request context. (Inherited from [ControllerBase][2].)                                                                                                                                                 
[ExecuteCore][19]                                                                | Invokes the action in the current controller context. (Inherited from [Controller][3].)                                                                                                                                       
[File(Byte[], String)][20]                                                       | Creates a [FileContentResult][21] object by using the file contents and file type. (Inherited from [Controller][3].)                                                                                                          
[File(Stream, String)][22]                                                       | Creates a [FileStreamResult][23] object by using the [Stream][24] object and content type. (Inherited from [Controller][3].)                                                                                                  
[File(String, String)][25]                                                       | Creates a [FilePathResult][26] object by using the file name and the content type. (Inherited from [Controller][3].)                                                                                                          
[File(Byte[], String, String)][27]                                               | Creates a [FileContentResult][21] object by using the file contents, content type, and the destination file name. (Inherited from [Controller][3].)                                                                           
[File(Stream, String, String)][28]                                               | Creates a [FileStreamResult][23] object using the [Stream][24] object, the content type, and the target file name. (Inherited from [Controller][3].)                                                                          
[File(String, String, String)][29]                                               | Creates a [FilePathResult][26] object by using the file name, the content type, and the file download name. (Inherited from [Controller][3].)                                                                                 
[Finalize][30]                                                                   | Allows an object to try to free resources and perform other cleanup operations before it is reclaimed by garbage collection. (Inherited from [Object][1].)                                                                    
[GetHashCode][31]                                                                | Serves as a hash function for a particular type. (Inherited from [Object][1].)                                                                                                                                                
[GetType][32]                                                                    | Gets the [Type][33] of the current instance. (Inherited from [Object][1].)                                                                                                                                                    
[HandleUnknownAction][34]                                                        | Called when a request matches this controller, but no method with the specified action name is found in the controller. (Inherited from [Controller][3].)                                                                     
[HttpNotFound()][35]                                                             | Returns an instance of the [HttpNotFoundResult][36] class. (Inherited from [Controller][3].)                                                                                                                                  
[HttpNotFound(String)][37]                                                       | Returns an instance of the [HttpNotFoundResult][36] class. (Inherited from [Controller][3].)                                                                                                                                  
[Initialize][38]                                                                 | Initializes data that might not be available when the constructor is called. (Overrides [BaseController.Initialize(RequestContext)][39].)                                                                                     
[JavaScript][40]                                                                 | Creates a [JavaScriptResult][41] object. (Inherited from [Controller][3].)                                                                                                                                                    
[Json(Object)][42]                                                               | Creates a [JsonResult][43] object that serializes the specified object to JavaScript Object Notation (JSON). (Inherited from [Controller][3].)                                                                                
[Json(Object, String)][44]                                                       | Creates a [JsonResult][43] object that serializes the specified object to JavaScript Object Notation (JSON) format. (Inherited from [Controller][3].)                                                                         
[Json(Object, JsonRequestBehavior)][45]                                          | Creates a [JsonResult][43] object that serializes the specified object to JavaScript Object Notation (JSON) format using the specified JSON request behavior. (Inherited from [Controller][3].)                               
[Json(Object, String, Encoding)][46]                                             | Creates a [JsonResult][43] object that serializes the specified object to JavaScript Object Notation (JSON) format. (Inherited from [Controller][3].)                                                                         
[Json(Object, String, JsonRequestBehavior)][47]                                  | Creates a [JsonResult][43] object that serializes the specified object to JavaScript Object Notation (JSON) format using the specified content type and JSON request behavior. (Inherited from [Controller][3].)              
[Json(Object, String, Encoding, JsonRequestBehavior)][48]                        | Creates a [JsonResult][43] object that serializes the specified object to JavaScript Object Notation (JSON) format using the content type, content encoding, and the JSON request behavior. (Inherited from [Controller][3].) 
[MemberwiseClone][49]                                                            | Creates a shallow copy of the current [Object][1]. (Inherited from [Object][1].)                                                                                                                                              
[OnActionExecuted][50]                                                           | Called after the action method is invoked. (Inherited from [Controller][3].)                                                                                                                                                  
[OnActionExecuting][51]                                                          | Called before the action method is invoked. (Inherited from [Controller][3].)                                                                                                                                                 
[OnAuthorization][52]                                                            | Called when authorization occurs. (Inherited from [Controller][3].)                                                                                                                                                           
[OnException][53]                                                                | Called when an unhandled exception occurs in the action. (Inherited from [Controller][3].)                                                                                                                                    
[OnResultExecuted][54]                                                           | Called after the action result that is returned by an action method is executed. (Inherited from [Controller][3].)                                                                                                            
[OnResultExecuting][55]                                                          | Called before the action result that is returned by an action method is executed. (Inherited from [Controller][3].)                                                                                                           
[PartialView()][56]                                                              | Creates a [PartialViewResult][57] object that renders a partial view. (Inherited from [Controller][3].)                                                                                                                       
[PartialView(Object)][58]                                                        | Creates a [PartialViewResult][57] object that renders a partial view, by using the specified model. (Inherited from [Controller][3].)                                                                                         
[PartialView(String)][59]                                                        | Creates a [PartialViewResult][57] object that renders a partial view, by using the specified view name. (Inherited from [Controller][3].)                                                                                     
[PartialView(String, Object)][60]                                                | Creates a [PartialViewResult][57] object that renders a partial view, by using the specified view name and model. (Inherited from [Controller][3].)                                                                           
[Redirect][61]                                                                   | Creates a [RedirectResult][62] object that redirects to the specified URL. (Inherited from [Controller][3].)                                                                                                                  
[RedirectPermanent][63]                                                          | Returns an instance of the [RedirectResult][62] class with the [Permanent][64] property set to true. (Inherited from [Controller][3].)                                                                                        
[RedirectToAction(String)][65]                                                   | Redirects to the specified action using the action name. (Inherited from [Controller][3].)                                                                                                                                    
[RedirectToAction(String, Object)][66]                                           | Redirects to the specified action using the action name and route values. (Inherited from [Controller][3].)                                                                                                                   
[RedirectToAction(String, RouteValueDictionary)][67]                             | Redirects to the specified action using the action name and route dictionary. (Inherited from [Controller][3].)                                                                                                               
[RedirectToAction(String, String)][68]                                           | Redirects to the specified action using the action name and controller name. (Inherited from [Controller][3].)                                                                                                                
[RedirectToAction(String, String, Object)][69]                                   | Redirects to the specified action using the action name, controller name, and route values. (Inherited from [Controller][3].)                                                                                                 
[RedirectToAction(String, String, RouteValueDictionary)][70]                     | Redirects to the specified action using the action name, controller name, and route dictionary. (Inherited from [Controller][3].)                                                                                             
[RedirectToActionPermanent(String)][71]                                          | Returns an instance of the [RedirectResult][62] class with the [Permanent][64] property set to true using the specified action name. (Inherited from [Controller][3].)                                                        
[RedirectToActionPermanent(String, Object)][72]                                  | Returns an instance of the [RedirectResult][62] class with the [Permanent][64] property set to true using the specified action name, and route values. (Inherited from [Controller][3].)                                      
[RedirectToActionPermanent(String, RouteValueDictionary)][73]                    | Returns an instance of the [RedirectResult][62] class with the [Permanent][64] property set to true using the specified action name, and route values. (Inherited from [Controller][3].)                                      
[RedirectToActionPermanent(String, String)][74]                                  | Returns an instance of the [RedirectResult][62] class with the [Permanent][64] property set to true using the specified action name, and controller name. (Inherited from [Controller][3].)                                   
[RedirectToActionPermanent(String, String, Object)][75]                          | Returns an instance of the [RedirectResult][62] class with the [Permanent][64] property set to true using the specified action name, controller name, and route values. (Inherited from [Controller][3].)                     
[RedirectToActionPermanent(String, String, RouteValueDictionary)][76]            | Returns an instance of the [RedirectResult][62] class with the [Permanent][64] property set to true using the specified action name, controller name, and route values. (Inherited from [Controller][3].)                     
[RedirectToRoute(Object)][77]                                                    | Redirects to the specified route using the specified route values. (Inherited from [Controller][3].)                                                                                                                          
[RedirectToRoute(RouteValueDictionary)][78]                                      | Redirects to the specified route using the route dictionary. (Inherited from [Controller][3].)                                                                                                                                
[RedirectToRoute(String)][79]                                                    | Redirects to the specified route using the route name. (Inherited from [Controller][3].)                                                                                                                                      
[RedirectToRoute(String, Object)][80]                                            | Redirects to the specified route using the route name and route values. (Inherited from [Controller][3].)                                                                                                                     
[RedirectToRoute(String, RouteValueDictionary)][81]                              | Redirects to the specified route using the route name and route dictionary. (Inherited from [Controller][3].)                                                                                                                 
[RedirectToRoutePermanent(Object)][82]                                           | Returns an instance of the [RedirectResult][62] class with the [Permanent][64] property set to true using the specified route values. (Inherited from [Controller][3].)                                                       
[RedirectToRoutePermanent(RouteValueDictionary)][83]                             | Returns an instance of the [RedirectResult][62] class with the [Permanent][64] property set to true using the specified route values. (Inherited from [Controller][3].)                                                       
[RedirectToRoutePermanent(String)][84]                                           | Returns an instance of the [RedirectResult][62] class with the [Permanent][64] property set to true using the specified route name. (Inherited from [Controller][3].)                                                         
[RedirectToRoutePermanent(String, Object)][85]                                   | Returns an instance of the [RedirectResult][62] class with the [Permanent][64] property set to true using the specified route name and route values. (Inherited from [Controller][3].)                                        
[RedirectToRoutePermanent(String, RouteValueDictionary)][86]                     | Returns an instance of the [RedirectResult][62] class with the [Permanent][64] property set to true using the specified route name and route values. (Inherited from [Controller][3].)                                        
[Saved][87]                                                                      | A page that informs the user that his new password was saved.                                                                                                                                                                 
[ToString][88]                                                                   | Returns a string that represents the current object. (Inherited from [Object][1].)                                                                                                                                            
[TryUpdateModel<TModel>(TModel)][89]                                             | Updates the specified model instance using values from the controller's current value provider. (Inherited from [Controller][3].)                                                                                             
[TryUpdateModel<TModel>(TModel, String)][90]                                     | Updates the specified model instance using values from the controller's current value provider and a prefix. (Inherited from [Controller][3].)                                                                                
[TryUpdateModel<TModel>(TModel, String[])][91]                                   | Updates the specified model instance using values from the controller's current value provider and included properties. (Inherited from [Controller][3].)                                                                     
[TryUpdateModel<TModel>(TModel, IValueProvider)][92]                             | Updates the specified model instance using values from the value provider. (Inherited from [Controller][3].)                                                                                                                  
[TryUpdateModel<TModel>(TModel, String, String[])][93]                           | Updates the specified model instance using values from the controller's current value provider, a prefix, and included properties. (Inherited from [Controller][3].)                                                          
[TryUpdateModel<TModel>(TModel, String, IValueProvider)][94]                     | Updates the specified model instance using values from the value provider and a prefix. (Inherited from [Controller][3].)                                                                                                     
[TryUpdateModel<TModel>(TModel, String[], IValueProvider)][95]                   | Updates the specified model instance using values from the value provider and a list of properties to include. (Inherited from [Controller][3].)                                                                              
[TryUpdateModel<TModel>(TModel, String, String[], String[])][96]                 | Updates the specified model instance using values from the controller's current value provider, a prefix, a list of properties to exclude, and a list of properties to include. (Inherited from [Controller][3].)             
[TryUpdateModel<TModel>(TModel, String, String[], IValueProvider)][97]           | Updates the specified model instance using values from the value provider, a prefix, and included properties. (Inherited from [Controller][3].)                                                                               
[TryUpdateModel<TModel>(TModel, String, String[], String[], IValueProvider)][98] | Updates the specified model instance using values from the value provider, a prefix, a list of properties to exclude , and a list of properties to include. (Inherited from [Controller][3].)                                 
[TryValidateModel(Object)][99]                                                   | Validates the specified model instance. (Inherited from [Controller][3].)                                                                                                                                                     
[TryValidateModel(Object, String)][100]                                          | Validates the specified model instance using an HTML prefix. (Inherited from [Controller][3].)                                                                                                                                
[UpdateModel<TModel>(TModel)][101]                                               | Updates the specified model instance using values from the controller's current value provider. (Inherited from [Controller][3].)                                                                                             
[UpdateModel<TModel>(TModel, String)][102]                                       | Updates the specified model instance using values from the controller's current value provider and a prefix. (Inherited from [Controller][3].)                                                                                
[UpdateModel<TModel>(TModel, String[])][103]                                     | Updates the specified model instance using values from the controller object's current value provider. (Inherited from [Controller][3].)                                                                                      
[UpdateModel<TModel>(TModel, IValueProvider)][104]                               | Updates the specified model instance using values from the value provider. (Inherited from [Controller][3].)                                                                                                                  
[UpdateModel<TModel>(TModel, String, String[])][105]                             | Updates the specified model instance using values from the controller's current value provider, a prefix, and included properties. (Inherited from [Controller][3].)                                                          
[UpdateModel<TModel>(TModel, String, IValueProvider)][106]                       | Updates the specified model instance using values from the value provider and a prefix. (Inherited from [Controller][3].)                                                                                                     
[UpdateModel<TModel>(TModel, String[], IValueProvider)][107]                     | Updates the specified model instance using values from the value provider, a prefix, and a list of properties to include. (Inherited from [Controller][3].)                                                                   
[UpdateModel<TModel>(TModel, String, String[], String[])][108]                   | Updates the specified model instance using values from the controller's current value provider, a prefix, a list of properties to exclude, and a list of properties to include. (Inherited from [Controller][3].)             
[UpdateModel<TModel>(TModel, String, String[], IValueProvider)][109]             | Updates the specified model instance using values from the value provider, a prefix, and a list of properties to include. (Inherited from [Controller][3].)                                                                   
[UpdateModel<TModel>(TModel, String, String[], String[], IValueProvider)][110]   | Updates the specified model instance using values from the value provider, a prefix, a list of properties to exclude, and a list of properties to include. (Inherited from [Controller][3].)                                  
[ValidateModel(Object)][111]                                                     | Validates the specified model instance. (Inherited from [Controller][3].)                                                                                                                                                     
[ValidateModel(Object, String)][112]                                             | Validates the specified model instance using an HTML prefix. (Inherited from [Controller][3].)                                                                                                                                
[View()][113]                                                                    | Creates a [ViewResult][114] object that renders a view to the response. (Inherited from [Controller][3].)                                                                                                                     
[View(Object)][115]                                                              | Creates a [ViewResult][114] object by using the model that renders a view to the response. (Inherited from [Controller][3].)                                                                                                  
[View(String)][116]                                                              | Creates a [ViewResult][114] object by using the view name that renders a view. (Inherited from [Controller][3].)                                                                                                              
[View(IView)][117]                                                               | Creates a [ViewResult][114] object that renders the specified [IView][118] object. (Inherited from [Controller][3].)                                                                                                          
[View(String, String)][119]                                                      | Creates a [ViewResult][114] object using the view name and master-page name that renders a view to the response. (Inherited from [Controller][3].)                                                                            
[View(String, Object)][120]                                                      | Creates a [ViewResult][114] object by using the view name and model that renders a view to the response. (Inherited from [Controller][3].)                                                                                    
[View(IView, Object)][121]                                                       | Creates a [ViewResult][114] object that renders the specified [IView][118] object. (Inherited from [Controller][3].)                                                                                                          
[View(String, String, Object)][122]                                              | Creates a [ViewResult][114] object using the view name, master-page name, and model that renders a view. (Inherited from [Controller][3].)                                                                                    


Properties
----------

Name                     | Description                                                                                                                                       
------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------- 
[ActionInvoker][123]     | Gets the action invoker for the controller. (Inherited from [Controller][3].)                                                                     
[Binders][124]           | Gets or sets the binder. (Inherited from [Controller][3].)                                                                                        
[Configuration][125]     | The [AccountConfiguration][126] instance for the current request. (Inherited from [BaseController][4].)                                           
[ControllerContext][127] | Gets or sets the controller context. (Inherited from [ControllerBase][2].)                                                                        
[HttpContext][128]       | Gets HTTP-specific information about an individual HTTP request. (Inherited from [Controller][3].)                                                
[ModelState][129]        | Gets the model state dictionary object that contains the state of the model and of model-binding validation. (Inherited from [Controller][3].)    
[Request][130]           | Gets the [HttpRequestBase][131] object for the current HTTP request. (Inherited from [Controller][3].)                                            
[Response][132]          | Gets the [HttpResponseBase][133] object for the current HTTP response. (Inherited from [Controller][3].)                                          
[RouteData][134]         | Gets the route data for the current request. (Inherited from [Controller][3].)                                                                    
[Server][135]            | Gets the [HttpServerUtilityBase][136] object that provides methods that are used during Web request processing. (Inherited from [Controller][3].) 
[Session][137]           | Gets the [HttpSessionStateBase][138] object for the current HTTP request. (Inherited from [Controller][3].)                                       
[TempData][139]          | Gets or sets the dictionary for temporary data. (Inherited from [ControllerBase][2].)                                                             
[TempDataProvider][140]  | Gets the temporary-data provider object that is used to store data for the next request. (Inherited from [Controller][3].)                        
[Url][141]               | Gets the URL helper object that is used to generate URLs by using routing. (Inherited from [Controller][3].)                                      
[User][142]              | Gets the user security information for the current HTTP request. (Inherited from [Controller][3].)                                                
[ValidateRequest][143]   | Gets or sets a value that indicates whether request validation is enabled for this request. (Inherited from [ControllerBase][2].)                 
[ValueProvider][144]     | Gets or sets the value provider for the controller. (Inherited from [ControllerBase][2].)                                                         
[ViewBag][145]           | Gets the dynamic view data dictionary. (Inherited from [ControllerBase][2].)                                                                      
[ViewData][146]          | Gets or sets the dictionary for view data. (Inherited from [ControllerBase][2].)                                                                  


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
[10]: http://msdn.microsoft.com/en-us/library/dd470588
[11]: http://msdn.microsoft.com/en-us/library/dd492713
[12]: http://msdn.microsoft.com/en-us/library/dd505216
[13]: http://msdn.microsoft.com/en-us/library/ee264001
[14]: http://msdn.microsoft.com/en-us/library/ee703613
[15]: http://msdn.microsoft.com/en-us/library/dd492966
[16]: http://msdn.microsoft.com/en-us/library/dd492699
[17]: http://msdn.microsoft.com/en-us/library/bsc2ak47
[18]: http://msdn.microsoft.com/en-us/library/dd460277
[19]: http://msdn.microsoft.com/en-us/library/dd505239
[20]: http://msdn.microsoft.com/en-us/library/dd460208
[21]: http://msdn.microsoft.com/en-us/library/dd492748
[22]: http://msdn.microsoft.com/en-us/library/dd493017
[23]: http://msdn.microsoft.com/en-us/library/dd505251
[24]: http://msdn.microsoft.com/en-us/library/8f86tw9e
[25]: http://msdn.microsoft.com/en-us/library/dd492492
[26]: http://msdn.microsoft.com/en-us/library/dd492762
[27]: http://msdn.microsoft.com/en-us/library/dd470835
[28]: http://msdn.microsoft.com/en-us/library/dd505200
[29]: http://msdn.microsoft.com/en-us/library/dd492593
[30]: http://msdn.microsoft.com/en-us/library/4k87zsw7
[31]: http://msdn.microsoft.com/en-us/library/zdee4b3y
[32]: http://msdn.microsoft.com/en-us/library/dfwy45w9
[33]: http://msdn.microsoft.com/en-us/library/42892f65
[34]: http://msdn.microsoft.com/en-us/library/dd492730
[35]: http://msdn.microsoft.com/en-us/library/gg453938
[36]: http://msdn.microsoft.com/en-us/library/gg402019
[37]: http://msdn.microsoft.com/en-us/library/gg402084
[38]: Initialize.md
[39]: ../../MvcAccount.Shared/BaseController/Initialize.md
[40]: http://msdn.microsoft.com/en-us/library/dd505087
[41]: http://msdn.microsoft.com/en-us/library/dd492253
[42]: http://msdn.microsoft.com/en-us/library/dd504936
[43]: http://msdn.microsoft.com/en-us/library/dd470569
[44]: http://msdn.microsoft.com/en-us/library/dd470169
[45]: http://msdn.microsoft.com/en-us/library/ee430920
[46]: http://msdn.microsoft.com/en-us/library/dd470587
[47]: http://msdn.microsoft.com/en-us/library/ee430918
[48]: http://msdn.microsoft.com/en-us/library/ee430908
[49]: http://msdn.microsoft.com/en-us/library/57ctke0a
[50]: http://msdn.microsoft.com/en-us/library/dd460283
[51]: http://msdn.microsoft.com/en-us/library/dd493080
[52]: http://msdn.microsoft.com/en-us/library/dd470545
[53]: http://msdn.microsoft.com/en-us/library/dd460532
[54]: http://msdn.microsoft.com/en-us/library/dd470615
[55]: http://msdn.microsoft.com/en-us/library/dd504998
[56]: http://msdn.microsoft.com/en-us/library/dd460345
[57]: http://msdn.microsoft.com/en-us/library/dd470537
[58]: http://msdn.microsoft.com/en-us/library/dd470145
[59]: http://msdn.microsoft.com/en-us/library/dd505247
[60]: http://msdn.microsoft.com/en-us/library/dd460161
[61]: http://msdn.microsoft.com/en-us/library/dd492671
[62]: http://msdn.microsoft.com/en-us/library/dd492890
[63]: http://msdn.microsoft.com/en-us/library/gg401950
[64]: http://msdn.microsoft.com/en-us/library/gg401978
[65]: http://msdn.microsoft.com/en-us/library/dd460241
[66]: http://msdn.microsoft.com/en-us/library/dd460291
[67]: http://msdn.microsoft.com/en-us/library/dd492939
[68]: http://msdn.microsoft.com/en-us/library/dd470594
[69]: http://msdn.microsoft.com/en-us/library/dd460311
[70]: http://msdn.microsoft.com/en-us/library/dd505283
[71]: http://msdn.microsoft.com/en-us/library/gg453902
[72]: http://msdn.microsoft.com/en-us/library/gg453883
[73]: http://msdn.microsoft.com/en-us/library/gg453920
[74]: http://msdn.microsoft.com/en-us/library/gg453904
[75]: http://msdn.microsoft.com/en-us/library/gg401893
[76]: http://msdn.microsoft.com/en-us/library/gg453864
[77]: http://msdn.microsoft.com/en-us/library/dd470174
[78]: http://msdn.microsoft.com/en-us/library/dd470199
[79]: http://msdn.microsoft.com/en-us/library/dd492497
[80]: http://msdn.microsoft.com/en-us/library/dd470522
[81]: http://msdn.microsoft.com/en-us/library/dd505024
[82]: http://msdn.microsoft.com/en-us/library/gg453870
[83]: http://msdn.microsoft.com/en-us/library/gg453933
[84]: http://msdn.microsoft.com/en-us/library/gg453941
[85]: http://msdn.microsoft.com/en-us/library/gg416644
[86]: http://msdn.microsoft.com/en-us/library/gg453955
[87]: Saved.md
[88]: http://msdn.microsoft.com/en-us/library/7bxwbwt2
[89]: http://msdn.microsoft.com/en-us/library/dd460189
[90]: http://msdn.microsoft.com/en-us/library/dd493137
[91]: http://msdn.microsoft.com/en-us/library/dd470377
[92]: http://msdn.microsoft.com/en-us/library/ee728634
[93]: http://msdn.microsoft.com/en-us/library/dd470908
[94]: http://msdn.microsoft.com/en-us/library/ee721265
[95]: http://msdn.microsoft.com/en-us/library/ee703530
[96]: http://msdn.microsoft.com/en-us/library/dd492957
[97]: http://msdn.microsoft.com/en-us/library/ee703635
[98]: http://msdn.microsoft.com/en-us/library/ee703452
[99]: http://msdn.microsoft.com/en-us/library/ff356143
[100]: http://msdn.microsoft.com/en-us/library/ff356144
[101]: http://msdn.microsoft.com/en-us/library/dd470933
[102]: http://msdn.microsoft.com/en-us/library/dd470808
[103]: http://msdn.microsoft.com/en-us/library/dd492193
[104]: http://msdn.microsoft.com/en-us/library/ee703656
[105]: http://msdn.microsoft.com/en-us/library/dd505127
[106]: http://msdn.microsoft.com/en-us/library/ee728613
[107]: http://msdn.microsoft.com/en-us/library/ee703486
[108]: http://msdn.microsoft.com/en-us/library/dd470388
[109]: http://msdn.microsoft.com/en-us/library/ee703664
[110]: http://msdn.microsoft.com/en-us/library/ee703509
[111]: http://msdn.microsoft.com/en-us/library/ff356131
[112]: http://msdn.microsoft.com/en-us/library/ff356138
[113]: http://msdn.microsoft.com/en-us/library/dd460331
[114]: http://msdn.microsoft.com/en-us/library/dd505228
[115]: http://msdn.microsoft.com/en-us/library/dd492930
[116]: http://msdn.microsoft.com/en-us/library/dd460352
[117]: http://msdn.microsoft.com/en-us/library/dd460327
[118]: http://msdn.microsoft.com/en-us/library/dd470357
[119]: http://msdn.microsoft.com/en-us/library/dd470743
[120]: http://msdn.microsoft.com/en-us/library/dd460310
[121]: http://msdn.microsoft.com/en-us/library/dd470544
[122]: http://msdn.microsoft.com/en-us/library/dd492244
[123]: http://msdn.microsoft.com/en-us/library/dd505131
[124]: http://msdn.microsoft.com/en-us/library/dd492975
[125]: ../../MvcAccount.Shared/BaseController/Configuration.md
[126]: ../../MvcAccount/AccountConfiguration/README.md
[127]: http://msdn.microsoft.com/en-us/library/dd505205
[128]: http://msdn.microsoft.com/en-us/library/dd470552
[129]: http://msdn.microsoft.com/en-us/library/dd504944
[130]: http://msdn.microsoft.com/en-us/library/dd492753
[131]: http://msdn.microsoft.com/en-us/library/cc680816
[132]: http://msdn.microsoft.com/en-us/library/dd470578
[133]: http://msdn.microsoft.com/en-us/library/cc680930
[134]: http://msdn.microsoft.com/en-us/library/dd492210
[135]: http://msdn.microsoft.com/en-us/library/dd505016
[136]: http://msdn.microsoft.com/en-us/library/cc679943
[137]: http://msdn.microsoft.com/en-us/library/dd492995
[138]: http://msdn.microsoft.com/en-us/library/cc679805
[139]: http://msdn.microsoft.com/en-us/library/dd470383
[140]: http://msdn.microsoft.com/en-us/library/dd460181
[141]: http://msdn.microsoft.com/en-us/library/dd492973
[142]: http://msdn.microsoft.com/en-us/library/dd493019
[143]: http://msdn.microsoft.com/en-us/library/dd460533
[144]: http://msdn.microsoft.com/en-us/library/dd470838
[145]: http://msdn.microsoft.com/en-us/library/gg480763
[146]: http://msdn.microsoft.com/en-us/library/dd493086