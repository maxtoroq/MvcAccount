DoneViewModel Class
===================
Holds data for the PasswordReset view.


Inheritance Hierarchy
---------------------
[System.Object][1]  
  [MvcAccount.Shared.BaseViewModel][2]  
    **MvcAccount.Password.Reset.DoneViewModel**  

**Namespace:** [MvcAccount.Password.Reset][3]  
**Assembly:** MvcAccount (in MvcAccount.dll)

Syntax
------

```csharp
public class DoneViewModel : BaseViewModel
```

The **DoneViewModel** type exposes the following members.


Constructors
------------

                 | Name               | Description                                                
---------------- | ------------------ | ---------------------------------------------------------- 
![Public method] | [DoneViewModel][4] | Initializes a new instance of the **DoneViewModel** class. 


Properties
----------

                      | Name               | Description                                                                                        
--------------------- | ------------------ | -------------------------------------------------------------------------------------------------- 
![Public property]    | [Message][5]       | A message for the user.                                                                            
![Public property]    | [NextLink][6]      | The link for the next URL the user should navigate to.                                             
![Public property]    | [Title][7]         | The view's title, used on h1 and title elements. (Inherited from [BaseViewModel][2].)              
![Protected property] | [Url][8]           | A [UrlHelper][9] for creating URLs. (Inherited from [BaseViewModel][2].)                           
![Public property]    | [ViewCssClass][10] | A space-separated list of CSS classes to be used in the view. (Inherited from [BaseViewModel][2].) 


See Also
--------

#### Reference
[MvcAccount.Password.Reset Namespace][3]  

[1]: http://msdn.microsoft.com/en-us/library/e5kfa45b
[2]: ../../MvcAccount.Shared/BaseViewModel/README.md
[3]: ../README.md
[4]: _ctor.md
[5]: Message.md
[6]: NextLink.md
[7]: ../../MvcAccount.Shared/BaseViewModel/Title.md
[8]: ../../MvcAccount.Shared/BaseViewModel/Url.md
[9]: http://msdn.microsoft.com/en-us/library/dd492578
[10]: ../../MvcAccount.Shared/BaseViewModel/ViewCssClass.md
[Public method]: ../../_icons/pubmethod.gif "Public method"
[Public property]: ../../_icons/pubproperty.gif "Public property"
[Protected property]: ../../_icons/protproperty.gif "Protected property"