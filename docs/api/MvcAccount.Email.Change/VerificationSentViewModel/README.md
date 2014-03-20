VerificationSentViewModel Class
===============================
Holds data for the EmailChangeVerificationSent view.


Inheritance Hierarchy
---------------------
[System.Object][1]  
  [MvcAccount.Shared.BaseViewModel][2]  
    **MvcAccount.Email.Change.VerificationSentViewModel**  

**Namespace:** [MvcAccount.Email.Change][3]  
**Assembly:** MvcAccount (in MvcAccount.dll)

Syntax
------

```csharp
public class VerificationSentViewModel : BaseViewModel
```

The **VerificationSentViewModel** type exposes the following members.


Constructors
------------

Name                           | Description                                                            
------------------------------ | ---------------------------------------------------------------------- 
[VerificationSentViewModel][4] | Initializes a new instance of the **VerificationSentViewModel** class. 


Methods
-------

Name                  | Description                                                                                                                                                
--------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------- 
[Equals][5]           | Determines whether the specified [Object][1] is equal to the current [Object][1]. (Inherited from [Object][1].)                                            
[Finalize][6]         | Allows an object to try to free resources and perform other cleanup operations before it is reclaimed by garbage collection. (Inherited from [Object][1].) 
[GetHashCode][7]      | Serves as a hash function for a particular type. (Inherited from [Object][1].)                                                                             
[GetType][8]          | Gets the [Type][9] of the current instance. (Inherited from [Object][1].)                                                                                  
[MemberwiseClone][10] | Creates a shallow copy of the current [Object][1]. (Inherited from [Object][1].)                                                                           
[ToString][11]        | Returns a string that represents the current object. (Inherited from [Object][1].)                                                                         


Properties
----------

Name               | Description                                                                                        
------------------ | -------------------------------------------------------------------------------------------------- 
[Message][12]      | A message for the user.                                                                            
[Title][13]        | The view's title, used on h1 and title elements. (Inherited from [BaseViewModel][2].)              
[Url][14]          | A [UrlHelper][15] for creating URLs. (Inherited from [BaseViewModel][2].)                          
[ViewCssClass][16] | A space-separated list of CSS classes to be used in the view. (Inherited from [BaseViewModel][2].) 


See Also
--------
[MvcAccount.Email.Change Namespace][3]  

[1]: http://msdn2.microsoft.com/en-us/library/e5kfa45b
[2]: ../../MvcAccount.Shared/BaseViewModel/README.md
[3]: ../README.md
[4]: _ctor.md
[5]: http://msdn2.microsoft.com/en-us/library/bsc2ak47
[6]: http://msdn2.microsoft.com/en-us/library/4k87zsw7
[7]: http://msdn2.microsoft.com/en-us/library/zdee4b3y
[8]: http://msdn2.microsoft.com/en-us/library/dfwy45w9
[9]: http://msdn2.microsoft.com/en-us/library/42892f65
[10]: http://msdn2.microsoft.com/en-us/library/57ctke0a
[11]: http://msdn2.microsoft.com/en-us/library/7bxwbwt2
[12]: Message.md
[13]: ../../MvcAccount.Shared/BaseViewModel/Title.md
[14]: ../../MvcAccount.Shared/BaseViewModel/Url.md
[15]: http://msdn2.microsoft.com/en-us/library/dd492578
[16]: ../../MvcAccount.Shared/BaseViewModel/ViewCssClass.md