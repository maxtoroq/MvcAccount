ResetViewModel Class
====================
Holds data for the ResetPassword view.


Inheritance Hierarchy
---------------------
[System.Object][1]  
  [MvcAccount.Shared.BaseViewModel][2]  
    [MvcAccount.Shared.FormViewModel][3]&lt;[ResetInput][4]>  
      **MvcAccount.Password.Reset.ResetViewModel**  

**Namespace:** [MvcAccount.Password.Reset][5]  
**Assembly:** MvcAccount (in MvcAccount.dll)

Syntax
------

```csharp
public class ResetViewModel : FormViewModel<ResetInput>
```

The **ResetViewModel** type exposes the following members.


Constructors
------------

Name                | Description                                                                                
------------------- | ------------------------------------------------------------------------------------------ 
[ResetViewModel][6] | Initializes a new instance of the **ResetViewModel** class using the provided input model. 


Methods
-------

Name                    | Description                                                                                                                                           
----------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------- 
[HtmlHelperForInput][7] | Returns a [HtmlHelper&lt;TModel>][8] to be used to render form controls for the [InputModel][9]. (Inherited from [FormViewModel&lt;TInputModel>][3].) 


Properties
----------

Name               | Description                                                                                        
------------------ | -------------------------------------------------------------------------------------------------- 
[CancelText][10]   | Text for the cancel button. (Inherited from [FormViewModel&lt;TInputModel>][3].)                   
[InputModel][9]    | The form's input model. (Inherited from [FormViewModel&lt;TInputModel>][3].)                       
[Message][11]      | A message for the user.                                                                            
[SubmitText][12]   | Text for the submit button. (Inherited from [FormViewModel&lt;TInputModel>][3].)                   
[Title][13]        | The view's title, used on h1 and title elements. (Inherited from [BaseViewModel][2].)              
[Url][14]          | A [UrlHelper][15] for creating URLs. (Inherited from [BaseViewModel][2].)                          
[ViewCssClass][16] | A space-separated list of CSS classes to be used in the view. (Inherited from [BaseViewModel][2].) 


See Also
--------
[MvcAccount.Password.Reset Namespace][5]  

[1]: http://msdn.microsoft.com/en-us/library/e5kfa45b
[2]: ../../MvcAccount.Shared/BaseViewModel/README.md
[3]: ../../MvcAccount.Shared/FormViewModel_1/README.md
[4]: ../ResetInput/README.md
[5]: ../README.md
[6]: _ctor.md
[7]: ../../MvcAccount.Shared/FormViewModel_1/HtmlHelperForInput.md
[8]: http://msdn.microsoft.com/en-us/library/dd492619
[9]: ../../MvcAccount.Shared/FormViewModel_1/InputModel.md
[10]: ../../MvcAccount.Shared/FormViewModel_1/CancelText.md
[11]: Message.md
[12]: ../../MvcAccount.Shared/FormViewModel_1/SubmitText.md
[13]: ../../MvcAccount.Shared/BaseViewModel/Title.md
[14]: ../../MvcAccount.Shared/BaseViewModel/Url.md
[15]: http://msdn.microsoft.com/en-us/library/dd492578
[16]: ../../MvcAccount.Shared/BaseViewModel/ViewCssClass.md