BaseViewModel Class
===================
Holds common view data.


Inheritance Hierarchy
---------------------
[System.Object][1]  
  **MvcAccount.Shared.BaseViewModel**  
    [MvcAccount.Account.IndexViewModel][2]  
    [MvcAccount.Email.Change.SavedViewModel][3]  
    [MvcAccount.Email.Change.VerificationSentViewModel][4]  
    [MvcAccount.Password.Change.SavedViewModel][5]  
    [MvcAccount.Password.Reset.DoneViewModel][6]  
    [MvcAccount.Password.Reset.VerificationSentViewModel][7]  
    [MvcAccount.Shared.FormViewModel&lt;TInputModel>][8]  

**Namespace:** [MvcAccount.Shared][9]  
**Assembly:** MvcAccount (in MvcAccount.dll)

Syntax
------

```csharp
public abstract class BaseViewModel
```

The **BaseViewModel** type exposes the following members.


Constructors
------------

Name                | Description                                                
------------------- | ---------------------------------------------------------- 
[BaseViewModel][10] | Initializes a new instance of the **BaseViewModel** class. 


Properties
----------

Name               | Description                                                   
------------------ | ------------------------------------------------------------- 
[Title][11]        | The view's title, used on h1 and title elements.              
[Url][12]          | A [UrlHelper][13] for creating URLs.                          
[ViewCssClass][14] | A space-separated list of CSS classes to be used in the view. 


See Also
--------
[MvcAccount.Shared Namespace][9]  

[1]: http://msdn.microsoft.com/en-us/library/e5kfa45b
[2]: ../../MvcAccount.Account/IndexViewModel/README.md
[3]: ../../MvcAccount.Email.Change/SavedViewModel/README.md
[4]: ../../MvcAccount.Email.Change/VerificationSentViewModel/README.md
[5]: ../../MvcAccount.Password.Change/SavedViewModel/README.md
[6]: ../../MvcAccount.Password.Reset/DoneViewModel/README.md
[7]: ../../MvcAccount.Password.Reset/VerificationSentViewModel/README.md
[8]: ../FormViewModel_1/README.md
[9]: ../README.md
[10]: _ctor.md
[11]: Title.md
[12]: Url.md
[13]: http://msdn.microsoft.com/en-us/library/dd492578
[14]: ViewCssClass.md