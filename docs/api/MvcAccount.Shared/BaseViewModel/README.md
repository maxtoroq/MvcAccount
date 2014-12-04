BaseViewModel Class
===================
Holds common view data.


Inheritance Hierarchy
---------------------
[System.Object][1]  
  **MvcAccount.Shared.BaseViewModel**  
    [More...][2]

**Namespace:** [MvcAccount.Shared][3]  
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
![Protected method] | [BaseViewModel][4] | Initializes a new instance of the **BaseViewModel** class. 


Properties
----------

                      | Name              | Description                                                   
--------------------- | ----------------- | ------------------------------------------------------------- 
![Public property]    | [Title][5]        | The view's title, used on h1 and title elements.              
![Protected property] | [Url][6]          | A [UrlHelper][7] for creating URLs.                           
![Public property]    | [ViewCssClass][8] | A space-separated list of CSS classes to be used in the view. 


See Also
--------
[MvcAccount.Shared Namespace][3]  


Inheritance Hierarchy (Continued)
---------------------------------
[System.Object][1]  
  **MvcAccount.Shared.BaseViewModel**  
    [MvcAccount.Account.IndexViewModel][9]  
    [MvcAccount.Email.Change.SavedViewModel][10]  
    [MvcAccount.Email.Change.VerificationSentViewModel][11]  
    [MvcAccount.Password.Change.SavedViewModel][12]  
    [MvcAccount.Password.Reset.DoneViewModel][13]  
    [MvcAccount.Password.Reset.VerificationSentViewModel][14]  
    [MvcAccount.Shared.FormViewModel&lt;TInputModel>][15]  

[1]: http://msdn.microsoft.com/en-us/library/e5kfa45b
[2]: #inheritance-hierarchy-continued
[3]: ../README.md
[4]: _ctor.md
[5]: Title.md
[6]: Url.md
[7]: http://msdn.microsoft.com/en-us/library/dd492578
[8]: ViewCssClass.md
[9]: ../../MvcAccount.Account/IndexViewModel/README.md
[10]: ../../MvcAccount.Email.Change/SavedViewModel/README.md
[11]: ../../MvcAccount.Email.Change/VerificationSentViewModel/README.md
[12]: ../../MvcAccount.Password.Change/SavedViewModel/README.md
[13]: ../../MvcAccount.Password.Reset/DoneViewModel/README.md
[14]: ../../MvcAccount.Password.Reset/VerificationSentViewModel/README.md
[15]: ../FormViewModel_1/README.md
[Protected method]: ../../_icons/protmethod.gif "Protected method"
[Public property]: ../../_icons/pubproperty.gif "Public property"
[Protected property]: ../../_icons/protproperty.gif "Protected property"