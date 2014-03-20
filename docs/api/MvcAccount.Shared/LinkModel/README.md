LinkModel Class
===============
Holds link data.


Inheritance Hierarchy
---------------------
[System.Object][1]  
  **MvcAccount.Shared.LinkModel**  

**Namespace:** [MvcAccount.Shared][2]  
**Assembly:** MvcAccount (in MvcAccount.dll)

Syntax
------

```csharp
public class LinkModel : IHtmlString
```

The **LinkModel** type exposes the following members.


Constructors
------------

Name           | Description                                                                            
-------------- | -------------------------------------------------------------------------------------- 
[LinkModel][3] | Initializes a new instance of the **LinkModel** class using the provided URL and text. 


Methods
-------

Name                 | Description                                                                                                                                                
-------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------- 
[Equals][4]          | Determines whether the specified [Object][1] is equal to the current [Object][1]. (Inherited from [Object][1].)                                            
[Finalize][5]        | Allows an object to try to free resources and perform other cleanup operations before it is reclaimed by garbage collection. (Inherited from [Object][1].) 
[GetHashCode][6]     | Serves as a hash function for a particular type. (Inherited from [Object][1].)                                                                             
[GetType][7]         | Gets the [Type][8] of the current instance. (Inherited from [Object][1].)                                                                                  
[MemberwiseClone][9] | Creates a shallow copy of the current [Object][1]. (Inherited from [Object][1].)                                                                           
[ToHtmlString][10]   | Returns an HTML-encoded string representation of the link.                                                                                                 
[ToString][11]       | Returns a string that represents the current object. (Inherited from [Object][1].)                                                                         


Properties
----------

Name       | Description      
---------- | ---------------- 
[Text][12] | The link's text. 
[Url][13]  | The link's URL.  


See Also
--------
[MvcAccount.Shared Namespace][2]  

[1]: http://msdn2.microsoft.com/en-us/library/e5kfa45b
[2]: ../README.md
[3]: _ctor.md
[4]: http://msdn2.microsoft.com/en-us/library/bsc2ak47
[5]: http://msdn2.microsoft.com/en-us/library/4k87zsw7
[6]: http://msdn2.microsoft.com/en-us/library/zdee4b3y
[7]: http://msdn2.microsoft.com/en-us/library/dfwy45w9
[8]: http://msdn2.microsoft.com/en-us/library/42892f65
[9]: http://msdn2.microsoft.com/en-us/library/57ctke0a
[10]: ToHtmlString.md
[11]: http://msdn2.microsoft.com/en-us/library/7bxwbwt2
[12]: Text.md
[13]: Url.md