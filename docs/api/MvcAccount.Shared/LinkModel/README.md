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
public class LinkModel : IHtmlString
```

The **LinkModel** type exposes the following members.


Constructors
------------

                 | Name           | Description                                                                            
---------------- | -------------- | -------------------------------------------------------------------------------------- 
![Public method] | [LinkModel][3] | Initializes a new instance of the **LinkModel** class using the provided URL and text. 


Methods
-------

                 | Name              | Description                                                
---------------- | ----------------- | ---------------------------------------------------------- 
![Public method] | [ToHtmlString][4] | Returns an HTML-encoded string representation of the link. 


Properties
----------

                   | Name      | Description      
------------------ | --------- | ---------------- 
![Public property] | [Text][5] | The link's text. 
![Public property] | [Url][6]  | The link's URL.  


See Also
--------
[MvcAccount.Shared Namespace][2]  

[1]: http://msdn.microsoft.com/en-us/library/e5kfa45b
[2]: ../README.md
[3]: _ctor.md
[4]: ToHtmlString.md
[5]: Text.md
[6]: Url.md
[Public method]: ../../_icons/pubmethod.gif "Public method"
[Public property]: ../../_icons/pubproperty.gif "Public property"