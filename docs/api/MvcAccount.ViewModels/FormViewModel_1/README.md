FormViewModel&lt;TInputModel> Class
===================================
Holds common data for views that have a form.


Inheritance Hierarchy
---------------------
[System.Object][1]  
  [MvcAccount.ViewModels.BaseViewModel][2]  
    **MvcAccount.ViewModels.FormViewModel<TInputModel>**  
      [MvcAccount.ViewModels.ChangeEmailViewModel][3]  
      [MvcAccount.ViewModels.ChangePasswordViewModel][4]  
      [MvcAccount.ViewModels.ResetPasswordViewModel][5]  
      [MvcAccount.ViewModels.RPViewModel][6]  
      [MvcAccount.ViewModels.SignInViewModel][7]  

**Namespace:** [MvcAccount.ViewModels][8]  
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

Name                  | Description                                                                                                                                                
--------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------- 
[Equals][10]          | Determines whether the specified [Object][1] is equal to the current [Object][1]. (Inherited from [Object][1].)                                            
[Finalize][11]        | Allows an object to try to free resources and perform other cleanup operations before it is reclaimed by garbage collection. (Inherited from [Object][1].) 
[GetHashCode][12]     | Serves as a hash function for a particular type. (Inherited from [Object][1].)                                                                             
[GetType][13]         | Gets the [Type][14] of the current instance. (Inherited from [Object][1].)                                                                                 
[MemberwiseClone][15] | Creates a shallow copy of the current [Object][1]. (Inherited from [Object][1].)                                                                           
[ToString][16]        | Returns a string that represents the current object. (Inherited from [Object][1].)                                                                         


Properties
----------

Name             | Description                                                                           
---------------- | ------------------------------------------------------------------------------------- 
[InputModel][17] | The form's input model.                                                               
[SubmitText][18] | Text for the submit button.                                                           
[Title][19]      | The view's title, used on h1 and title elements. (Inherited from [BaseViewModel][2].) 
[Url][20]        | A [UrlHelper][21] for creating URLs. (Inherited from [BaseViewModel][2].)             


See Also
--------
[MvcAccount.ViewModels Namespace][8]  

[1]: http://msdn2.microsoft.com/en-us/library/e5kfa45b
[2]: ../BaseViewModel/README.md
[3]: ../ChangeEmailViewModel/README.md
[4]: ../ChangePasswordViewModel/README.md
[5]: ../ResetPasswordViewModel/README.md
[6]: ../RPViewModel/README.md
[7]: ../SignInViewModel/README.md
[8]: ../README.md
[9]: _ctor.md
[10]: http://msdn2.microsoft.com/en-us/library/bsc2ak47
[11]: http://msdn2.microsoft.com/en-us/library/4k87zsw7
[12]: http://msdn2.microsoft.com/en-us/library/zdee4b3y
[13]: http://msdn2.microsoft.com/en-us/library/dfwy45w9
[14]: http://msdn2.microsoft.com/en-us/library/42892f65
[15]: http://msdn2.microsoft.com/en-us/library/57ctke0a
[16]: http://msdn2.microsoft.com/en-us/library/7bxwbwt2
[17]: InputModel.md
[18]: SubmitText.md
[19]: ../BaseViewModel/Title.md
[20]: ../BaseViewModel/Url.md
[21]: http://msdn2.microsoft.com/en-us/library/dd492578