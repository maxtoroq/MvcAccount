IndexViewModel Class
====================
Holds data for the Index view.


Inheritance Hierarchy
---------------------
[System.Object][1]  
  [MvcAccount.Shared.BaseViewModel][2]  
    **MvcAccount.Account.IndexViewModel**  

**Namespace:** [MvcAccount.Account][3]  
**Assembly:** MvcAccount (in MvcAccount.dll)

Syntax
------

```csharp
public class IndexViewModel : BaseViewModel
```

The **IndexViewModel** type exposes the following members.


Constructors
------------

                 | Name                | Description                                                 
---------------- | ------------------- | ----------------------------------------------------------- 
![Public method] | [IndexViewModel][4] | Initializes a new instance of the **IndexViewModel** class. 


Properties
----------

                      | Name              | Description                                                                                        
--------------------- | ----------------- | -------------------------------------------------------------------------------------------------- 
![Public property]    | [Links][5]        | A collection of links.                                                                             
![Public property]    | [Title][6]        | The view's title, used on h1 and title elements. (Inherited from [BaseViewModel][2].)              
![Protected property] | [Url][7]          | A [UrlHelper][8] for creating URLs. (Inherited from [BaseViewModel][2].)                           
![Public property]    | [ViewCssClass][9] | A space-separated list of CSS classes to be used in the view. (Inherited from [BaseViewModel][2].) 


See Also
--------

#### Reference
[MvcAccount.Account Namespace][3]  

[1]: http://msdn.microsoft.com/en-us/library/e5kfa45b
[2]: ../../MvcAccount.Shared/BaseViewModel/README.md
[3]: ../README.md
[4]: _ctor.md
[5]: Links.md
[6]: ../../MvcAccount.Shared/BaseViewModel/Title.md
[7]: ../../MvcAccount.Shared/BaseViewModel/Url.md
[8]: http://msdn.microsoft.com/en-us/library/dd492578
[9]: ../../MvcAccount.Shared/BaseViewModel/ViewCssClass.md
[Public method]: ../../_icons/pubmethod.gif "Public method"
[Public property]: ../../_icons/pubproperty.gif "Public property"
[Protected property]: ../../_icons/protproperty.gif "Protected property"