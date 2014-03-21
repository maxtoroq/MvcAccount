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
public abstract class AccountImplController : BaseController
```

The **AccountImplController** type exposes the following members.


Constructors
------------

Name                       | Description                                                       
-------------------------- | ----------------------------------------------------------------- 
[AccountImplController][7] | Initializes a new instance of the **AccountImplController** class 


Methods
-------

Name                                                                             | Description                                                                                                                                                                                                                   
-------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
[Content(String)][8]                                                             | Creates a content result object by using a string. (Inherited from [Controller][4].)                                                                                                                                          
[Content(String, String)][9]                                                     | Creates a content result object by using a string and the content type. (Inherited from [Controller][4].)                                                                                                                     
[Content(String, String, Encoding)][10]                                          | Creates a content result object by using a string, the content type, and content encoding. (Inherited from [Controller][4].)                                                                                                  
[CreateActionInvoker][11]                                                        | Creates an action invoker. (Inherited from [Controller][4].)                                                                                                                                                                  
[CreateTempDataProvider][12]                                                     | Creates a temporary data provider. (Inherited from [Controller][4].)                                                                                                                                                          
[Dispose()][13]                                                                  | Releases all resources that are used by the current instance of the [Controller][4] class. (Inherited from [Controller][4].)                                                                                                  
[Dispose(Boolean)][14]                                                           | Releases unmanaged resources and optionally releases managed resources. (Inherited from [Controller][4].)                                                                                                                     
[Equals][15]                                                                     | Determines whether the specified [Object][2] is equal to the current [Object][2]. (Inherited from [Object][2].)                                                                                                               
[Execute][16]                                                                    | Executes the specified request context. (Inherited from [ControllerBase][3].)                                                                                                                                                 
[ExecuteCore][17]                                                                | Invokes the action in the current controller context. (Inherited from [Controller][4].)                                                                                                                                       
[File(Byte[], String)][18]                                                       | Creates a [FileContentResult][19] object by using the file contents and file type. (Inherited from [Controller][4].)                                                                                                          
[File(Stream, String)][20]                                                       | Creates a [FileStreamResult][21] object by using the [Stream][22] object and content type. (Inherited from [Controller][4].)                                                                                                  
[File(String, String)][23]                                                       | Creates a [FilePathResult][24] object by using the file name and the content type. (Inherited from [Controller][4].)                                                                                                          
[File(Byte[], String, String)][25]                                               | Creates a [FileContentResult][19] object by using the file contents, content type, and the destination file name. (Inherited from [Controller][4].)                                                                           
[File(Stream, String, String)][26]                                               | Creates a [FileStreamResult][21] object using the [Stream][22] object, the content type, and the target file name. (Inherited from [Controller][4].)                                                                          
[File(String, String, String)][27]                                               | Creates a [FilePathResult][24] object by using the file name, the content type, and the file download name. (Inherited from [Controller][4].)                                                                                 
[Finalize][28]                                                                   | Allows an object to try to free resources and perform other cleanup operations before it is reclaimed by garbage collection. (Inherited from [Object][2].)                                                                    
[GetHashCode][29]                                                                | Serves as a hash function for a particular type. (Inherited from [Object][2].)                                                                                                                                                
[GetType][30]                                                                    | Gets the [Type][31] of the current instance. (Inherited from [Object][2].)                                                                                                                                                    
[HandleUnknownAction][32]                                                        | Called when a request matches this controller, but no method with the specified action name is found in the controller. (Inherited from [Controller][4].)                                                                     
[HttpNotFound()][33]                                                             | Returns an instance of the [HttpNotFoundResult][34] class. (Inherited from [Controller][4].)                                                                                                                                  
[HttpNotFound(String)][35]                                                       | Returns an instance of the [HttpNotFoundResult][34] class. (Inherited from [Controller][4].)                                                                                                                                  
[Index][36]                                                                      | The index page.                                                                                                                                                                                                               
[Initialize][37]                                                                 | Initializes data that might not be available when the constructor is called. (Inherited from [BaseController][5].)                                                                                                            
[JavaScript][38]                                                                 | Creates a [JavaScriptResult][39] object. (Inherited from [Controller][4].)                                                                                                                                                    
[Json(Object)][40]                                                               | Creates a [JsonResult][41] object that serializes the specified object to JavaScript Object Notation (JSON). (Inherited from [Controller][4].)                                                                                
[Json(Object, String)][42]                                                       | Creates a [JsonResult][41] object that serializes the specified object to JavaScript Object Notation (JSON) format. (Inherited from [Controller][4].)                                                                         
[Json(Object, JsonRequestBehavior)][43]                                          | Creates a [JsonResult][41] object that serializes the specified object to JavaScript Object Notation (JSON) format using the specified JSON request behavior. (Inherited from [Controller][4].)                               
[Json(Object, String, Encoding)][44]                                             | Creates a [JsonResult][41] object that serializes the specified object to JavaScript Object Notation (JSON) format. (Inherited from [Controller][4].)                                                                         
[Json(Object, String, JsonRequestBehavior)][45]                                  | Creates a [JsonResult][41] object that serializes the specified object to JavaScript Object Notation (JSON) format using the specified content type and JSON request behavior. (Inherited from [Controller][4].)              
[Json(Object, String, Encoding, JsonRequestBehavior)][46]                        | Creates a [JsonResult][41] object that serializes the specified object to JavaScript Object Notation (JSON) format using the content type, content encoding, and the JSON request behavior. (Inherited from [Controller][4].) 
[MemberwiseClone][47]                                                            | Creates a shallow copy of the current [Object][2]. (Inherited from [Object][2].)                                                                                                                                              
[OnActionExecuted][48]                                                           | Called after the action method is invoked. (Inherited from [Controller][4].)                                                                                                                                                  
[OnActionExecuting][49]                                                          | Called before the action method is invoked. (Inherited from [Controller][4].)                                                                                                                                                 
[OnAuthorization][50]                                                            | Called when authorization occurs. (Inherited from [Controller][4].)                                                                                                                                                           
[OnException][51]                                                                | Called when an unhandled exception occurs in the action. (Inherited from [Controller][4].)                                                                                                                                    
[OnResultExecuted][52]                                                           | Called after the action result that is returned by an action method is executed. (Inherited from [Controller][4].)                                                                                                            
[OnResultExecuting][53]                                                          | Called before the action result that is returned by an action method is executed. (Inherited from [Controller][4].)                                                                                                           
[PartialView()][54]                                                              | Creates a [PartialViewResult][55] object that renders a partial view. (Inherited from [Controller][4].)                                                                                                                       
[PartialView(Object)][56]                                                        | Creates a [PartialViewResult][55] object that renders a partial view, by using the specified model. (Inherited from [Controller][4].)                                                                                         
[PartialView(String)][57]                                                        | Creates a [PartialViewResult][55] object that renders a partial view, by using the specified view name. (Inherited from [Controller][4].)                                                                                     
[PartialView(String, Object)][58]                                                | Creates a [PartialViewResult][55] object that renders a partial view, by using the specified view name and model. (Inherited from [Controller][4].)                                                                           
[Redirect][59]                                                                   | Creates a [RedirectResult][60] object that redirects to the specified URL. (Inherited from [Controller][4].)                                                                                                                  
[RedirectPermanent][61]                                                          | Returns an instance of the [RedirectResult][60] class with the [Permanent][62] property set to true. (Inherited from [Controller][4].)                                                                                        
[RedirectToAction(String)][63]                                                   | Redirects to the specified action using the action name. (Inherited from [Controller][4].)                                                                                                                                    
[RedirectToAction(String, Object)][64]                                           | Redirects to the specified action using the action name and route values. (Inherited from [Controller][4].)                                                                                                                   
[RedirectToAction(String, RouteValueDictionary)][65]                             | Redirects to the specified action using the action name and route dictionary. (Inherited from [Controller][4].)                                                                                                               
[RedirectToAction(String, String)][66]                                           | Redirects to the specified action using the action name and controller name. (Inherited from [Controller][4].)                                                                                                                
[RedirectToAction(String, String, Object)][67]                                   | Redirects to the specified action using the action name, controller name, and route values. (Inherited from [Controller][4].)                                                                                                 
[RedirectToAction(String, String, RouteValueDictionary)][68]                     | Redirects to the specified action using the action name, controller name, and route dictionary. (Inherited from [Controller][4].)                                                                                             
[RedirectToActionPermanent(String)][69]                                          | Returns an instance of the [RedirectResult][60] class with the [Permanent][62] property set to true using the specified action name. (Inherited from [Controller][4].)                                                        
[RedirectToActionPermanent(String, Object)][70]                                  | Returns an instance of the [RedirectResult][60] class with the [Permanent][62] property set to true using the specified action name, and route values. (Inherited from [Controller][4].)                                      
[RedirectToActionPermanent(String, RouteValueDictionary)][71]                    | Returns an instance of the [RedirectResult][60] class with the [Permanent][62] property set to true using the specified action name, and route values. (Inherited from [Controller][4].)                                      
[RedirectToActionPermanent(String, String)][72]                                  | Returns an instance of the [RedirectResult][60] class with the [Permanent][62] property set to true using the specified action name, and controller name. (Inherited from [Controller][4].)                                   
[RedirectToActionPermanent(String, String, Object)][73]                          | Returns an instance of the [RedirectResult][60] class with the [Permanent][62] property set to true using the specified action name, controller name, and route values. (Inherited from [Controller][4].)                     
[RedirectToActionPermanent(String, String, RouteValueDictionary)][74]            | Returns an instance of the [RedirectResult][60] class with the [Permanent][62] property set to true using the specified action name, controller name, and route values. (Inherited from [Controller][4].)                     
[RedirectToRoute(Object)][75]                                                    | Redirects to the specified route using the specified route values. (Inherited from [Controller][4].)                                                                                                                          
[RedirectToRoute(RouteValueDictionary)][76]                                      | Redirects to the specified route using the route dictionary. (Inherited from [Controller][4].)                                                                                                                                
[RedirectToRoute(String)][77]                                                    | Redirects to the specified route using the route name. (Inherited from [Controller][4].)                                                                                                                                      
[RedirectToRoute(String, Object)][78]                                            | Redirects to the specified route using the route name and route values. (Inherited from [Controller][4].)                                                                                                                     
[RedirectToRoute(String, RouteValueDictionary)][79]                              | Redirects to the specified route using the route name and route dictionary. (Inherited from [Controller][4].)                                                                                                                 
[RedirectToRoutePermanent(Object)][80]                                           | Returns an instance of the [RedirectResult][60] class with the [Permanent][62] property set to true using the specified route values. (Inherited from [Controller][4].)                                                       
[RedirectToRoutePermanent(RouteValueDictionary)][81]                             | Returns an instance of the [RedirectResult][60] class with the [Permanent][62] property set to true using the specified route values. (Inherited from [Controller][4].)                                                       
[RedirectToRoutePermanent(String)][82]                                           | Returns an instance of the [RedirectResult][60] class with the [Permanent][62] property set to true using the specified route name. (Inherited from [Controller][4].)                                                         
[RedirectToRoutePermanent(String, Object)][83]                                   | Returns an instance of the [RedirectResult][60] class with the [Permanent][62] property set to true using the specified route name and route values. (Inherited from [Controller][4].)                                        
[RedirectToRoutePermanent(String, RouteValueDictionary)][84]                     | Returns an instance of the [RedirectResult][60] class with the [Permanent][62] property set to true using the specified route name and route values. (Inherited from [Controller][4].)                                        
[ToString][85]                                                                   | Returns a string that represents the current object. (Inherited from [Object][2].)                                                                                                                                            
[TryUpdateModel<TModel>(TModel)][86]                                             | Updates the specified model instance using values from the controller's current value provider. (Inherited from [Controller][4].)                                                                                             
[TryUpdateModel<TModel>(TModel, String)][87]                                     | Updates the specified model instance using values from the controller's current value provider and a prefix. (Inherited from [Controller][4].)                                                                                
[TryUpdateModel<TModel>(TModel, String[])][88]                                   | Updates the specified model instance using values from the controller's current value provider and included properties. (Inherited from [Controller][4].)                                                                     
[TryUpdateModel<TModel>(TModel, IValueProvider)][89]                             | Updates the specified model instance using values from the value provider. (Inherited from [Controller][4].)                                                                                                                  
[TryUpdateModel<TModel>(TModel, String, String[])][90]                           | Updates the specified model instance using values from the controller's current value provider, a prefix, and included properties. (Inherited from [Controller][4].)                                                          
[TryUpdateModel<TModel>(TModel, String, IValueProvider)][91]                     | Updates the specified model instance using values from the value provider and a prefix. (Inherited from [Controller][4].)                                                                                                     
[TryUpdateModel<TModel>(TModel, String[], IValueProvider)][92]                   | Updates the specified model instance using values from the value provider and a list of properties to include. (Inherited from [Controller][4].)                                                                              
[TryUpdateModel<TModel>(TModel, String, String[], String[])][93]                 | Updates the specified model instance using values from the controller's current value provider, a prefix, a list of properties to exclude, and a list of properties to include. (Inherited from [Controller][4].)             
[TryUpdateModel<TModel>(TModel, String, String[], IValueProvider)][94]           | Updates the specified model instance using values from the value provider, a prefix, and included properties. (Inherited from [Controller][4].)                                                                               
[TryUpdateModel<TModel>(TModel, String, String[], String[], IValueProvider)][95] | Updates the specified model instance using values from the value provider, a prefix, a list of properties to exclude , and a list of properties to include. (Inherited from [Controller][4].)                                 
[TryValidateModel(Object)][96]                                                   | Validates the specified model instance. (Inherited from [Controller][4].)                                                                                                                                                     
[TryValidateModel(Object, String)][97]                                           | Validates the specified model instance using an HTML prefix. (Inherited from [Controller][4].)                                                                                                                                
[UpdateModel<TModel>(TModel)][98]                                                | Updates the specified model instance using values from the controller's current value provider. (Inherited from [Controller][4].)                                                                                             
[UpdateModel<TModel>(TModel, String)][99]                                        | Updates the specified model instance using values from the controller's current value provider and a prefix. (Inherited from [Controller][4].)                                                                                
[UpdateModel<TModel>(TModel, String[])][100]                                     | Updates the specified model instance using values from the controller object's current value provider. (Inherited from [Controller][4].)                                                                                      
[UpdateModel<TModel>(TModel, IValueProvider)][101]                               | Updates the specified model instance using values from the value provider. (Inherited from [Controller][4].)                                                                                                                  
[UpdateModel<TModel>(TModel, String, String[])][102]                             | Updates the specified model instance using values from the controller's current value provider, a prefix, and included properties. (Inherited from [Controller][4].)                                                          
[UpdateModel<TModel>(TModel, String, IValueProvider)][103]                       | Updates the specified model instance using values from the value provider and a prefix. (Inherited from [Controller][4].)                                                                                                     
[UpdateModel<TModel>(TModel, String[], IValueProvider)][104]                     | Updates the specified model instance using values from the value provider, a prefix, and a list of properties to include. (Inherited from [Controller][4].)                                                                   
[UpdateModel<TModel>(TModel, String, String[], String[])][105]                   | Updates the specified model instance using values from the controller's current value provider, a prefix, a list of properties to exclude, and a list of properties to include. (Inherited from [Controller][4].)             
[UpdateModel<TModel>(TModel, String, String[], IValueProvider)][106]             | Updates the specified model instance using values from the value provider, a prefix, and a list of properties to include. (Inherited from [Controller][4].)                                                                   
[UpdateModel<TModel>(TModel, String, String[], String[], IValueProvider)][107]   | Updates the specified model instance using values from the value provider, a prefix, a list of properties to exclude, and a list of properties to include. (Inherited from [Controller][4].)                                  
[ValidateModel(Object)][108]                                                     | Validates the specified model instance. (Inherited from [Controller][4].)                                                                                                                                                     
[ValidateModel(Object, String)][109]                                             | Validates the specified model instance using an HTML prefix. (Inherited from [Controller][4].)                                                                                                                                
[View()][110]                                                                    | Creates a [ViewResult][111] object that renders a view to the response. (Inherited from [Controller][4].)                                                                                                                     
[View(Object)][112]                                                              | Creates a [ViewResult][111] object by using the model that renders a view to the response. (Inherited from [Controller][4].)                                                                                                  
[View(String)][113]                                                              | Creates a [ViewResult][111] object by using the view name that renders a view. (Inherited from [Controller][4].)                                                                                                              
[View(IView)][114]                                                               | Creates a [ViewResult][111] object that renders the specified [IView][115] object. (Inherited from [Controller][4].)                                                                                                          
[View(String, String)][116]                                                      | Creates a [ViewResult][111] object using the view name and master-page name that renders a view to the response. (Inherited from [Controller][4].)                                                                            
[View(String, Object)][117]                                                      | Creates a [ViewResult][111] object by using the view name and model that renders a view to the response. (Inherited from [Controller][4].)                                                                                    
[View(IView, Object)][118]                                                       | Creates a [ViewResult][111] object that renders the specified [IView][115] object. (Inherited from [Controller][4].)                                                                                                          
[View(String, String, Object)][119]                                              | Creates a [ViewResult][111] object using the view name, master-page name, and model that renders a view. (Inherited from [Controller][4].)                                                                                    


Properties
----------

Name                     | Description                                                                                                                                       
------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------- 
[ActionInvoker][120]     | Gets the action invoker for the controller. (Inherited from [Controller][4].)                                                                     
[Binders][121]           | Gets or sets the binder. (Inherited from [Controller][4].)                                                                                        
[Configuration][122]     | The [AccountConfiguration][123] instance for the current request. (Inherited from [BaseController][5].)                                           
[ControllerContext][124] | Gets or sets the controller context. (Inherited from [ControllerBase][3].)                                                                        
[HttpContext][125]       | Gets HTTP-specific information about an individual HTTP request. (Inherited from [Controller][4].)                                                
[ModelState][126]        | Gets the model state dictionary object that contains the state of the model and of model-binding validation. (Inherited from [Controller][4].)    
[Request][127]           | Gets the [HttpRequestBase][128] object for the current HTTP request. (Inherited from [Controller][4].)                                            
[Response][129]          | Gets the [HttpResponseBase][130] object for the current HTTP response. (Inherited from [Controller][4].)                                          
[RouteData][131]         | Gets the route data for the current request. (Inherited from [Controller][4].)                                                                    
[Server][132]            | Gets the [HttpServerUtilityBase][133] object that provides methods that are used during Web request processing. (Inherited from [Controller][4].) 
[Session][134]           | Gets the [HttpSessionStateBase][135] object for the current HTTP request. (Inherited from [Controller][4].)                                       
[TempData][136]          | Gets or sets the dictionary for temporary data. (Inherited from [ControllerBase][3].)                                                             
[TempDataProvider][137]  | Gets the temporary-data provider object that is used to store data for the next request. (Inherited from [Controller][4].)                        
[Url][138]               | Gets the URL helper object that is used to generate URLs by using routing. (Inherited from [Controller][4].)                                      
[User][139]              | Gets the user security information for the current HTTP request. (Inherited from [Controller][4].)                                                
[ValidateRequest][140]   | Gets or sets a value that indicates whether request validation is enabled for this request. (Inherited from [ControllerBase][3].)                 
[ValueProvider][141]     | Gets or sets the value provider for the controller. (Inherited from [ControllerBase][3].)                                                         
[ViewBag][142]           | Gets the dynamic view data dictionary. (Inherited from [ControllerBase][3].)                                                                      
[ViewData][143]          | Gets or sets the dictionary for view data. (Inherited from [ControllerBase][3].)                                                                  


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
[8]: http://msdn.microsoft.com/en-us/library/dd470588
[9]: http://msdn.microsoft.com/en-us/library/dd492713
[10]: http://msdn.microsoft.com/en-us/library/dd505216
[11]: http://msdn.microsoft.com/en-us/library/ee264001
[12]: http://msdn.microsoft.com/en-us/library/ee703613
[13]: http://msdn.microsoft.com/en-us/library/dd492966
[14]: http://msdn.microsoft.com/en-us/library/dd492699
[15]: http://msdn.microsoft.com/en-us/library/bsc2ak47
[16]: http://msdn.microsoft.com/en-us/library/dd460277
[17]: http://msdn.microsoft.com/en-us/library/dd505239
[18]: http://msdn.microsoft.com/en-us/library/dd460208
[19]: http://msdn.microsoft.com/en-us/library/dd492748
[20]: http://msdn.microsoft.com/en-us/library/dd493017
[21]: http://msdn.microsoft.com/en-us/library/dd505251
[22]: http://msdn.microsoft.com/en-us/library/8f86tw9e
[23]: http://msdn.microsoft.com/en-us/library/dd492492
[24]: http://msdn.microsoft.com/en-us/library/dd492762
[25]: http://msdn.microsoft.com/en-us/library/dd470835
[26]: http://msdn.microsoft.com/en-us/library/dd505200
[27]: http://msdn.microsoft.com/en-us/library/dd492593
[28]: http://msdn.microsoft.com/en-us/library/4k87zsw7
[29]: http://msdn.microsoft.com/en-us/library/zdee4b3y
[30]: http://msdn.microsoft.com/en-us/library/dfwy45w9
[31]: http://msdn.microsoft.com/en-us/library/42892f65
[32]: http://msdn.microsoft.com/en-us/library/dd492730
[33]: http://msdn.microsoft.com/en-us/library/gg453938
[34]: http://msdn.microsoft.com/en-us/library/gg402019
[35]: http://msdn.microsoft.com/en-us/library/gg402084
[36]: Index.md
[37]: ../../MvcAccount.Shared/BaseController/Initialize.md
[38]: http://msdn.microsoft.com/en-us/library/dd505087
[39]: http://msdn.microsoft.com/en-us/library/dd492253
[40]: http://msdn.microsoft.com/en-us/library/dd504936
[41]: http://msdn.microsoft.com/en-us/library/dd470569
[42]: http://msdn.microsoft.com/en-us/library/dd470169
[43]: http://msdn.microsoft.com/en-us/library/ee430920
[44]: http://msdn.microsoft.com/en-us/library/dd470587
[45]: http://msdn.microsoft.com/en-us/library/ee430918
[46]: http://msdn.microsoft.com/en-us/library/ee430908
[47]: http://msdn.microsoft.com/en-us/library/57ctke0a
[48]: http://msdn.microsoft.com/en-us/library/dd460283
[49]: http://msdn.microsoft.com/en-us/library/dd493080
[50]: http://msdn.microsoft.com/en-us/library/dd470545
[51]: http://msdn.microsoft.com/en-us/library/dd460532
[52]: http://msdn.microsoft.com/en-us/library/dd470615
[53]: http://msdn.microsoft.com/en-us/library/dd504998
[54]: http://msdn.microsoft.com/en-us/library/dd460345
[55]: http://msdn.microsoft.com/en-us/library/dd470537
[56]: http://msdn.microsoft.com/en-us/library/dd470145
[57]: http://msdn.microsoft.com/en-us/library/dd505247
[58]: http://msdn.microsoft.com/en-us/library/dd460161
[59]: http://msdn.microsoft.com/en-us/library/dd492671
[60]: http://msdn.microsoft.com/en-us/library/dd492890
[61]: http://msdn.microsoft.com/en-us/library/gg401950
[62]: http://msdn.microsoft.com/en-us/library/gg401978
[63]: http://msdn.microsoft.com/en-us/library/dd460241
[64]: http://msdn.microsoft.com/en-us/library/dd460291
[65]: http://msdn.microsoft.com/en-us/library/dd492939
[66]: http://msdn.microsoft.com/en-us/library/dd470594
[67]: http://msdn.microsoft.com/en-us/library/dd460311
[68]: http://msdn.microsoft.com/en-us/library/dd505283
[69]: http://msdn.microsoft.com/en-us/library/gg453902
[70]: http://msdn.microsoft.com/en-us/library/gg453883
[71]: http://msdn.microsoft.com/en-us/library/gg453920
[72]: http://msdn.microsoft.com/en-us/library/gg453904
[73]: http://msdn.microsoft.com/en-us/library/gg401893
[74]: http://msdn.microsoft.com/en-us/library/gg453864
[75]: http://msdn.microsoft.com/en-us/library/dd470174
[76]: http://msdn.microsoft.com/en-us/library/dd470199
[77]: http://msdn.microsoft.com/en-us/library/dd492497
[78]: http://msdn.microsoft.com/en-us/library/dd470522
[79]: http://msdn.microsoft.com/en-us/library/dd505024
[80]: http://msdn.microsoft.com/en-us/library/gg453870
[81]: http://msdn.microsoft.com/en-us/library/gg453933
[82]: http://msdn.microsoft.com/en-us/library/gg453941
[83]: http://msdn.microsoft.com/en-us/library/gg416644
[84]: http://msdn.microsoft.com/en-us/library/gg453955
[85]: http://msdn.microsoft.com/en-us/library/7bxwbwt2
[86]: http://msdn.microsoft.com/en-us/library/dd460189
[87]: http://msdn.microsoft.com/en-us/library/dd493137
[88]: http://msdn.microsoft.com/en-us/library/dd470377
[89]: http://msdn.microsoft.com/en-us/library/ee728634
[90]: http://msdn.microsoft.com/en-us/library/dd470908
[91]: http://msdn.microsoft.com/en-us/library/ee721265
[92]: http://msdn.microsoft.com/en-us/library/ee703530
[93]: http://msdn.microsoft.com/en-us/library/dd492957
[94]: http://msdn.microsoft.com/en-us/library/ee703635
[95]: http://msdn.microsoft.com/en-us/library/ee703452
[96]: http://msdn.microsoft.com/en-us/library/ff356143
[97]: http://msdn.microsoft.com/en-us/library/ff356144
[98]: http://msdn.microsoft.com/en-us/library/dd470933
[99]: http://msdn.microsoft.com/en-us/library/dd470808
[100]: http://msdn.microsoft.com/en-us/library/dd492193
[101]: http://msdn.microsoft.com/en-us/library/ee703656
[102]: http://msdn.microsoft.com/en-us/library/dd505127
[103]: http://msdn.microsoft.com/en-us/library/ee728613
[104]: http://msdn.microsoft.com/en-us/library/ee703486
[105]: http://msdn.microsoft.com/en-us/library/dd470388
[106]: http://msdn.microsoft.com/en-us/library/ee703664
[107]: http://msdn.microsoft.com/en-us/library/ee703509
[108]: http://msdn.microsoft.com/en-us/library/ff356131
[109]: http://msdn.microsoft.com/en-us/library/ff356138
[110]: http://msdn.microsoft.com/en-us/library/dd460331
[111]: http://msdn.microsoft.com/en-us/library/dd505228
[112]: http://msdn.microsoft.com/en-us/library/dd492930
[113]: http://msdn.microsoft.com/en-us/library/dd460352
[114]: http://msdn.microsoft.com/en-us/library/dd460327
[115]: http://msdn.microsoft.com/en-us/library/dd470357
[116]: http://msdn.microsoft.com/en-us/library/dd470743
[117]: http://msdn.microsoft.com/en-us/library/dd460310
[118]: http://msdn.microsoft.com/en-us/library/dd470544
[119]: http://msdn.microsoft.com/en-us/library/dd492244
[120]: http://msdn.microsoft.com/en-us/library/dd505131
[121]: http://msdn.microsoft.com/en-us/library/dd492975
[122]: ../../MvcAccount.Shared/BaseController/Configuration.md
[123]: ../../MvcAccount/AccountConfiguration/README.md
[124]: http://msdn.microsoft.com/en-us/library/dd505205
[125]: http://msdn.microsoft.com/en-us/library/dd470552
[126]: http://msdn.microsoft.com/en-us/library/dd504944
[127]: http://msdn.microsoft.com/en-us/library/dd492753
[128]: http://msdn.microsoft.com/en-us/library/cc680816
[129]: http://msdn.microsoft.com/en-us/library/dd470578
[130]: http://msdn.microsoft.com/en-us/library/cc680930
[131]: http://msdn.microsoft.com/en-us/library/dd492210
[132]: http://msdn.microsoft.com/en-us/library/dd505016
[133]: http://msdn.microsoft.com/en-us/library/cc679943
[134]: http://msdn.microsoft.com/en-us/library/dd492995
[135]: http://msdn.microsoft.com/en-us/library/cc679805
[136]: http://msdn.microsoft.com/en-us/library/dd470383
[137]: http://msdn.microsoft.com/en-us/library/dd460181
[138]: http://msdn.microsoft.com/en-us/library/dd492973
[139]: http://msdn.microsoft.com/en-us/library/dd493019
[140]: http://msdn.microsoft.com/en-us/library/dd460533
[141]: http://msdn.microsoft.com/en-us/library/dd470838
[142]: http://msdn.microsoft.com/en-us/library/gg480763
[143]: http://msdn.microsoft.com/en-us/library/dd493086