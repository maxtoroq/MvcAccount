BaseViewModel Class
===================
Holds common view data.


Inheritance Hierarchy
---------------------
[System.Object][1]  
  **MvcAccount.Shared.BaseViewModel**  
    
**Namespace:** [MvcAccount.Shared][2]  
**Assembly:** MvcAccount (in MvcAccount.dll)

Syntax
------

```csharp
public abstract class BaseViewModel
```

The **BaseViewModel** type exposes the following members.


Constructors
------------

                    | Name               | Description                                                
------------------- | ------------------ | ---------------------------------------------------------- 
![Protected method] | [BaseViewModel][3] | Initializes a new instance of the **BaseViewModel** class. 


Properties
----------

                      | Name              | Description                                                   
--------------------- | ----------------- | ------------------------------------------------------------- 
![Public property]    | [Title][4]        | The view's title, used on h1 and title elements.              
![Protected property] | [Url][5]          | A [UrlHelper][6] for creating URLs.                           
![Public property]    | [ViewCssClass][7] | A space-separated list of CSS classes to be used in the view. 


See Also
--------
[MvcAccount.Shared Namespace][2]  


Inheritance Hierarchy
---------------------
[System.Object][1]  
  **MvcAccount.Shared.BaseViewModel**  
    [MvcAccount.Account.IndexViewModel][8]  
    [MvcAccount.Email.Change.SavedViewModel][9]  
    [MvcAccount.Email.Change.VerificationSentViewModel][10]  
    [MvcAccount.Password.Change.SavedViewModel][11]  
    [MvcAccount.Password.Reset.DoneViewModel][12]  
    [MvcAccount.Password.Reset.VerificationSentViewModel][13]  
    [MvcAccount.Shared.FormViewModel&lt;TInputModel>][14]  

[1]: http://msdn.microsoft.com/en-us/library/e5kfa45b
[2]: ../README.md
[3]: _ctor.md
[4]: Title.md
[5]: Url.md
[6]: http://msdn.microsoft.com/en-us/library/dd492578
[7]: ViewCssClass.md
[8]: ../../MvcAccount.Account/IndexViewModel/README.md
[9]: ../../MvcAccount.Email.Change/SavedViewModel/README.md
[10]: ../../MvcAccount.Email.Change/VerificationSentViewModel/README.md
[11]: ../../MvcAccount.Password.Change/SavedViewModel/README.md
[12]: ../../MvcAccount.Password.Reset/DoneViewModel/README.md
[13]: ../../MvcAccount.Password.Reset/VerificationSentViewModel/README.md
[14]: ../FormViewModel_1/README.md
[Protected method]: ../../_icons/protmethod.gif "Protected method"
[Public property]: ../../_icons/pubproperty.gif "Public property"
[Protected property]: ../../_icons/protproperty.gif "Protected property"