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
public abstract class FormViewModel<TInputModel> : BaseViewModel

```

#### Type Parameters

##### *TInputModel*
The form's input type.

The **FormViewModel<TInputModel>** type exposes the following members.


Constructors
------------

                    | Name                               | Description                                                                                           
------------------- | ---------------------------------- | ----------------------------------------------------------------------------------------------------- 
![Protected method] | [FormViewModel&lt;TInputModel>][9] | Initializes a new instance of the FormViewModel&lt;TInputModel> class using the provided input model. 


Methods
-------

                 | Name                     | Description                                                                                        
---------------- | ------------------------ | -------------------------------------------------------------------------------------------------- 
![Public method] | [HtmlHelperForInput][10] | Returns a [HtmlHelper&lt;TModel>][11] to be used to render form controls for the [InputModel][12]. 


Properties
----------

                      | Name               | Description                                                                                        
--------------------- | ------------------ | -------------------------------------------------------------------------------------------------- 
![Public property]    | [CancelText][13]   | Text for the cancel button.                                                                        
![Public property]    | [InputModel][12]   | The form's input model.                                                                            
![Public property]    | [SubmitText][14]   | Text for the submit button.                                                                        
![Public property]    | [Title][15]        | The view's title, used on h1 and title elements. (Inherited from [BaseViewModel][2].)              
![Protected property] | [Url][16]          | A [UrlHelper][17] for creating URLs. (Inherited from [BaseViewModel][2].)                          
![Public property]    | [ViewCssClass][18] | A space-separated list of CSS classes to be used in the view. (Inherited from [BaseViewModel][2].) 


See Also
--------

#### Reference
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
[10]: HtmlHelperForInput.md
[11]: http://msdn.microsoft.com/en-us/library/dd492619
[12]: InputModel.md
[13]: CancelText.md
[14]: SubmitText.md
[15]: ../BaseViewModel/Title.md
[16]: ../BaseViewModel/Url.md
[17]: http://msdn.microsoft.com/en-us/library/dd492578
[18]: ../BaseViewModel/ViewCssClass.md
[Protected method]: ../../_icons/protmethod.gif "Protected method"
[Public method]: ../../_icons/pubmethod.gif "Public method"
[Public property]: ../../_icons/pubproperty.gif "Public property"
[Protected property]: ../../_icons/protproperty.gif "Protected property"