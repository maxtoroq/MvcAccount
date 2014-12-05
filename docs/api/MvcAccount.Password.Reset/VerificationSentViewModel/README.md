VerificationSentViewModel Class
===============================
Holds data for the PasswordResetVerificationSent view.


Inheritance Hierarchy
---------------------
[System.Object][1]  
  [MvcAccount.Shared.BaseViewModel][2]  
    **MvcAccount.Password.Reset.VerificationSentViewModel**  

**Namespace:** [MvcAccount.Password.Reset][3]  
**Assembly:** MvcAccount (in MvcAccount.dll)

Syntax
------

```csharp
public class VerificationSentViewModel : BaseViewModel
```

The **VerificationSentViewModel** type exposes the following members.


Constructors
------------

                 | Name                           | Description                                                            
---------------- | ------------------------------ | ---------------------------------------------------------------------- 
![Public method] | [VerificationSentViewModel][4] | Initializes a new instance of the **VerificationSentViewModel** class. 


Properties
----------

                      | Name              | Description                                                                                        
--------------------- | ----------------- | -------------------------------------------------------------------------------------------------- 
![Public property]    | [Message][5]      | A message for the user.                                                                            
![Public property]    | [Title][6]        | The view's title, used on h1 and title elements. (Inherited from [BaseViewModel][2].)              
![Protected property] | [Url][7]          | A [UrlHelper][8] for creating URLs. (Inherited from [BaseViewModel][2].)                           
![Public property]    | [ViewCssClass][9] | A space-separated list of CSS classes to be used in the view. (Inherited from [BaseViewModel][2].) 


See Also
--------

#### Reference
[MvcAccount.Password.Reset Namespace][3]  

[1]: http://msdn.microsoft.com/en-us/library/e5kfa45b
[2]: ../../MvcAccount.Shared/BaseViewModel/README.md
[3]: ../README.md
[4]: _ctor.md
[5]: Message.md
[6]: ../../MvcAccount.Shared/BaseViewModel/Title.md
[7]: ../../MvcAccount.Shared/BaseViewModel/Url.md
[8]: http://msdn.microsoft.com/en-us/library/dd492578
[9]: ../../MvcAccount.Shared/BaseViewModel/ViewCssClass.md
[Public method]: ../../_icons/pubmethod.gif "Public method"
[Public property]: ../../_icons/pubproperty.gif "Public property"
[Protected property]: ../../_icons/protproperty.gif "Protected property"