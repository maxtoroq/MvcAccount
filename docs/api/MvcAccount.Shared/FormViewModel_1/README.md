FormViewModel&lt;TInputModel> Class
===================================
Holds common data for views that have a form.


Inheritance Hierarchy
---------------------
[System.Object][1]  
  [MvcAccount.Shared.BaseViewModel][2]  
    **MvcAccount.Shared.FormViewModel<TInputModel>**  
      [MvcAccount.Authentication.SignInViewModel][3]  
      [MvcAccount.Email.Change.ChangeViewModel][4]  
      [MvcAccount.Password.Change.ChangeViewModel][5]  
      [MvcAccount.Password.Reset.FinishViewModel][6]  
      [MvcAccount.Password.Reset.ResetViewModel][7]  

**Namespace:** [MvcAccount.Shared][8]  
**Assembly:** MvcAccount (in MvcAccount.dll)

Syntax
------

```csharp
public abstract class FormViewModel<TInputModel> : BaseViewModel
```


Type Parameters
---------------

#### *TInputModel*
The form's input type.

The **FormViewModel<TInputModel>** type exposes the following members.


Constructors
------------

Name                            | Description                                                                                           
------------------------------- | ----------------------------------------------------------------------------------------------------- 
[FormViewModel<TInputModel>][9] | Initializes a new instance of the FormViewModel&lt;TInputModel> class using the provided input model. 


Methods
-------

Name                     | Description                                                                                                                                                
------------------------ | ---------------------------------------------------------------------------------------------------------------------------------------------------------- 
[Equals][10]             | Determines whether the specified [Object][1] is equal to the current [Object][1]. (Inherited from [Object][1].)                                            
[Finalize][11]           | Allows an object to try to free resources and perform other cleanup operations before it is reclaimed by garbage collection. (Inherited from [Object][1].) 
[GetHashCode][12]        | Serves as a hash function for a particular type. (Inherited from [Object][1].)                                                                             
[GetType][13]            | Gets the [Type][14] of the current instance. (Inherited from [Object][1].)                                                                                 
[HtmlHelperForInput][15] | Returns a [HtmlHelper<TModel>][16] to be used to render form controls for the [InputModel][17].                                                            
[MemberwiseClone][18]    | Creates a shallow copy of the current [Object][1]. (Inherited from [Object][1].)                                                                           
[ToString][19]           | Returns a string that represents the current object. (Inherited from [Object][1].)                                                                         


Properties
----------

Name               | Description                                                                                        
------------------ | -------------------------------------------------------------------------------------------------- 
[CancelText][20]   | Text for the cancel button.                                                                        
[InputModel][17]   | The form's input model.                                                                            
[SubmitText][21]   | Text for the submit button.                                                                        
[Title][22]        | The view's title, used on h1 and title elements. (Inherited from [BaseViewModel][2].)              
[Url][23]          | A [UrlHelper][24] for creating URLs. (Inherited from [BaseViewModel][2].)                          
[ViewCssClass][25] | A space-separated list of CSS classes to be used in the view. (Inherited from [BaseViewModel][2].) 


See Also
--------
[MvcAccount.Shared Namespace][8]  

[1]: http://msdn.microsoft.com/en-us/library/e5kfa45b
[2]: ../BaseViewModel/README.md
[3]: ../../MvcAccount.Authentication/SignInViewModel/README.md
[4]: ../../MvcAccount.Email.Change/ChangeViewModel/README.md
[5]: ../../MvcAccount.Password.Change/ChangeViewModel/README.md
[6]: ../../MvcAccount.Password.Reset/FinishViewModel/README.md
[7]: ../../MvcAccount.Password.Reset/ResetViewModel/README.md
[8]: ../README.md
[9]: _ctor.md
[10]: http://msdn.microsoft.com/en-us/library/bsc2ak47
[11]: http://msdn.microsoft.com/en-us/library/4k87zsw7
[12]: http://msdn.microsoft.com/en-us/library/zdee4b3y
[13]: http://msdn.microsoft.com/en-us/library/dfwy45w9
[14]: http://msdn.microsoft.com/en-us/library/42892f65
[15]: HtmlHelperForInput.md
[16]: http://msdn.microsoft.com/en-us/library/dd492619
[17]: InputModel.md
[18]: http://msdn.microsoft.com/en-us/library/57ctke0a
[19]: http://msdn.microsoft.com/en-us/library/7bxwbwt2
[20]: CancelText.md
[21]: SubmitText.md
[22]: ../BaseViewModel/Title.md
[23]: ../BaseViewModel/Url.md
[24]: http://msdn.microsoft.com/en-us/library/dd492578
[25]: ../BaseViewModel/ViewCssClass.md