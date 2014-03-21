BaseViewModel Class
===================
Holds common view data.


Inheritance Hierarchy
---------------------
[System.Object][1]  
  **MvcAccount.ViewModels.BaseViewModel**  
    [MvcAccount.ViewModels.EmailChangeVerificationSentViewModel][2]  
    [MvcAccount.ViewModels.EmailSavedViewModel][3]  
    [MvcAccount.ViewModels.FormViewModel<TInputModel>][4]  
    [MvcAccount.ViewModels.IndexViewModel][5]  
    [MvcAccount.ViewModels.PasswordResetVerificationSentViewModel][6]  
    [MvcAccount.ViewModels.PasswordResetViewModel][7]  
    [MvcAccount.ViewModels.PasswordSavedViewModel][8]  

**Namespace:** [MvcAccount.ViewModels][9]  
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
------------------- | --------------------------------------------------------- 
[BaseViewModel][10] | Initializes a new instance of the **BaseViewModel** class 


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

Name        | Description                                      
----------- | ------------------------------------------------ 
[Title][18] | The view's title, used on h1 and title elements. 
[Url][19]   | A [UrlHelper][20] for creating URLs.             


See Also
--------
[MvcAccount.ViewModels Namespace][9]  

[1]: http://msdn.microsoft.com/en-us/library/e5kfa45b
[2]: ../EmailChangeVerificationSentViewModel/README.md
[3]: ../EmailSavedViewModel/README.md
[4]: ../FormViewModel_1/README.md
[5]: ../IndexViewModel/README.md
[6]: ../PasswordResetVerificationSentViewModel/README.md
[7]: ../PasswordResetViewModel/README.md
[8]: ../PasswordSavedViewModel/README.md
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