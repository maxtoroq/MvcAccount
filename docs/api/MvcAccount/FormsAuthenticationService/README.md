FormsAuthenticationService Class
================================
Class responsible for creating authentication cookies and setting them as part of the outgoing HTTP response.


Inheritance Hierarchy
---------------------
[System.Object][1]  
  **MvcAccount.FormsAuthenticationService**  

**Namespace:** [MvcAccount][2]  
**Assembly:** MvcAccount (in MvcAccount.dll)

Syntax
------

```csharp
public class FormsAuthenticationService
```

The **FormsAuthenticationService** type exposes the following members.


Constructors
------------

                 | Name                            | Description                                                            
---------------- | ------------------------------- | ---------------------------------------------------------------------- 
![Public method] | [FormsAuthenticationService][3] | Initializes a new instance of the **FormsAuthenticationService** class 


Methods
-------

                    | Name                                         | Description                                                                                                                                        
------------------- | -------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------- 
![Protected method] | [CreateFormsAuthenticationTicket][4]         | Creates a [FormsAuthenticationTicket][5] instance.                                                                                                 
![Public method]    | [GetAuthCookie(String)][6]                   | Creates an authentication cookie for a given user name. This does not set the cookie as part of the outgoing response.                             
![Public method]    | [GetAuthCookie(String, Boolean)][7]          | Creates an authentication cookie for a given user name. This does not set the cookie as part of the outgoing response.                             
![Public method]    | [GetAuthCookie(String, Boolean, String)][8]  | Creates an authentication cookie for a given user name. This does not set the cookie as part of the outgoing response.                             
![Public method]    | [SetAuthCookie(String)][9]                   | Creates an authentication ticket for the supplied user name and adds it to the cookies collection of the response.                                 
![Public method]    | [SetAuthCookie(HttpCookie)][10]              | Adds the *cookie* to the cookies collection of the response.                                                                                       
![Public method]    | [SetAuthCookie(String, Boolean)][11]         | Creates an authentication ticket for the supplied user name and adds it to the cookies collection of the response.                                 
![Public method]    | [SetAuthCookie(String, Boolean, String)][12] | Creates an authentication ticket for the supplied user name and adds it to the cookies collection of the response, using the supplied cookie path. 
![Public method]    | [SignOut][13]                                | Removes the forms-authentication ticket from the browser.                                                                                          


Properties
----------

                   | Name                | Description                                                      
------------------ | ------------------- | ---------------------------------------------------------------- 
![Public property] | [Configuration][14] | The [AccountConfiguration][15] instance for the current request. 


See Also
--------

#### Reference
[MvcAccount Namespace][2]  

[1]: http://msdn.microsoft.com/en-us/library/e5kfa45b
[2]: ../README.md
[3]: _ctor.md
[4]: CreateFormsAuthenticationTicket.md
[5]: http://msdn.microsoft.com/en-us/library/se1843z2
[6]: GetAuthCookie.md
[7]: GetAuthCookie_1.md
[8]: GetAuthCookie_2.md
[9]: SetAuthCookie.md
[10]: SetAuthCookie_3.md
[11]: SetAuthCookie_1.md
[12]: SetAuthCookie_2.md
[13]: SignOut.md
[14]: Configuration.md
[15]: ../AccountConfiguration/README.md
[Public method]: ../../_icons/pubmethod.gif "Public method"
[Protected method]: ../../_icons/protmethod.gif "Protected method"
[Public property]: ../../_icons/pubproperty.gif "Public property"