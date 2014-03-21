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
    [MvcAccount.Shared.FormViewModel<TInputModel>][8]  

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


Methods
-------

Name                  | Description                                                                                                                                                
--------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------- 
[Equals][11]          | Determines whether the specified [Object][1] is equal to the current [Object][1]. (Inherited from [Object][1].)                                            
[Finalize][12]        | Allows an object to try to free resources and perform other cleanup operations before it is reclaimed by garbage collection. (Inherited from [Object][1].) 
[GetHashCode][13]     | Serves as a hash function for a particular type. (Inherited from [Object][1].)                                                                             
[GetType][14]         | Gets the [Type][15] of the current instance. (Inherited from [Object][1].)                                                                                 
[MemberwiseClone][16] | Creates a shallow copy of the current [Object][1]. (Inherited from [Object][1].)                                                                           
[ToString][17]        | Returns a string that represents the current object. (Inherited from [Object][1].)                                                                         


Properties
----------

Name               | Description                                                   
------------------ | ------------------------------------------------------------- 
[Title][18]        | The view's title, used on h1 and title elements.              
[Url][19]          | A [UrlHelper][20] for creating URLs.                          
[ViewCssClass][21] | A space-separated list of CSS classes to be used in the view. 


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
[11]: http://msdn.microsoft.com/en-us/library/bsc2ak47
[12]: http://msdn.microsoft.com/en-us/library/4k87zsw7
[13]: http://msdn.microsoft.com/en-us/library/zdee4b3y
[14]: http://msdn.microsoft.com/en-us/library/dfwy45w9
[15]: http://msdn.microsoft.com/en-us/library/42892f65
[16]: http://msdn.microsoft.com/en-us/library/57ctke0a
[17]: http://msdn.microsoft.com/en-us/library/7bxwbwt2
[18]: Title.md
[19]: Url.md
[20]: http://msdn.microsoft.com/en-us/library/dd492578
[21]: ViewCssClass.md