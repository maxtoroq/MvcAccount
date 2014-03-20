SignInViewModel Class
=====================
Holds data for the SignIn view.


Inheritance Hierarchy
---------------------
[System.Object][1]  
  [MvcAccount.Shared.BaseViewModel][2]  
    [MvcAccount.Shared.FormViewModel][3]&lt;[SignInInput][4]>  
      **MvcAccount.Authentication.SignInViewModel**  

**Namespace:** [MvcAccount.Authentication][5]  
**Assembly:** MvcAccount (in MvcAccount.dll)

Syntax
------

```csharp
public class SignInViewModel : FormViewModel<SignInInput>
```

The **SignInViewModel** type exposes the following members.


Constructors
------------

Name                 | Description                                                                           
-------------------- | ------------------------------------------------------------------------------------- 
[SignInViewModel][6] | Initializes a new instance of the **SignInViewModel** using the provided input model. 


Methods
-------

Name                     | Description                                                                                                                                                
------------------------ | ---------------------------------------------------------------------------------------------------------------------------------------------------------- 
[Equals][7]              | Determines whether the specified [Object][1] is equal to the current [Object][1]. (Inherited from [Object][1].)                                            
[Finalize][8]            | Allows an object to try to free resources and perform other cleanup operations before it is reclaimed by garbage collection. (Inherited from [Object][1].) 
[GetHashCode][9]         | Serves as a hash function for a particular type. (Inherited from [Object][1].)                                                                             
[GetType][10]            | Gets the [Type][11] of the current instance. (Inherited from [Object][1].)                                                                                 
[HtmlHelperForInput][12] | Returns a [HtmlHelper<TModel>][13] to be used to render form controls for the [InputModel][14]. (Inherited from [FormViewModel<TInputModel>][3].)          
[MemberwiseClone][15]    | Creates a shallow copy of the current [Object][1]. (Inherited from [Object][1].)                                                                           
[ToString][16]           | Returns a string that represents the current object. (Inherited from [Object][1].)                                                                         


Properties
----------

Name                      | Description                                                                                        
------------------------- | -------------------------------------------------------------------------------------------------- 
[AccountRecoveryLink][17] | A link for account recovery.                                                                       
[CancelText][18]          | Text for the cancel button. (Inherited from [FormViewModel<TInputModel>][3].)                      
[InputModel][14]          | The form's input model. (Inherited from [FormViewModel<TInputModel>][3].)                          
[SubmitText][19]          | Text for the submit button. (Inherited from [FormViewModel<TInputModel>][3].)                      
[Title][20]               | The view's title, used on h1 and title elements. (Inherited from [BaseViewModel][2].)              
[Url][21]                 | A [UrlHelper][22] for creating URLs. (Inherited from [BaseViewModel][2].)                          
[ViewCssClass][23]        | A space-separated list of CSS classes to be used in the view. (Inherited from [BaseViewModel][2].) 


See Also
--------
[MvcAccount.Authentication Namespace][5]  

[1]: http://msdn2.microsoft.com/en-us/library/e5kfa45b
[2]: ../../MvcAccount.Shared/BaseViewModel/README.md
[3]: ../../MvcAccount.Shared/FormViewModel_1/README.md
[4]: ../SignInInput/README.md
[5]: ../README.md
[6]: _ctor.md
[7]: http://msdn2.microsoft.com/en-us/library/bsc2ak47
[8]: http://msdn2.microsoft.com/en-us/library/4k87zsw7
[9]: http://msdn2.microsoft.com/en-us/library/zdee4b3y
[10]: http://msdn2.microsoft.com/en-us/library/dfwy45w9
[11]: http://msdn2.microsoft.com/en-us/library/42892f65
[12]: ../../MvcAccount.Shared/FormViewModel_1/HtmlHelperForInput.md
[13]: http://msdn2.microsoft.com/en-us/library/dd492619
[14]: ../../MvcAccount.Shared/FormViewModel_1/InputModel.md
[15]: http://msdn2.microsoft.com/en-us/library/57ctke0a
[16]: http://msdn2.microsoft.com/en-us/library/7bxwbwt2
[17]: AccountRecoveryLink.md
[18]: ../../MvcAccount.Shared/FormViewModel_1/CancelText.md
[19]: ../../MvcAccount.Shared/FormViewModel_1/SubmitText.md
[20]: ../../MvcAccount.Shared/BaseViewModel/Title.md
[21]: ../../MvcAccount.Shared/BaseViewModel/Url.md
[22]: http://msdn2.microsoft.com/en-us/library/dd492578
[23]: ../../MvcAccount.Shared/BaseViewModel/ViewCssClass.md