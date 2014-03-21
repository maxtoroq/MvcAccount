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
public class FormsAuthenticationService
```

The **FormsAuthenticationService** type exposes the following members.


Constructors
------------

Name                            | Description                                                            
------------------------------- | ---------------------------------------------------------------------- 
[FormsAuthenticationService][3] | Initializes a new instance of the **FormsAuthenticationService** class 


Methods
-------

Name                                         | Description                                                                                                                                                
-------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------- 
[Equals][4]                                  | Determines whether the specified [Object][1] is equal to the current [Object][1]. (Inherited from [Object][1].)                                            
[Finalize][5]                                | Allows an object to try to free resources and perform other cleanup operations before it is reclaimed by garbage collection. (Inherited from [Object][1].) 
[GetAuthCookie(String)][6]                   | Creates an authentication cookie for a given user name. This does not set the cookie as part of the outgoing response.                                     
[GetAuthCookie(String, Boolean)][7]          | Creates an authentication cookie for a given user name. This does not set the cookie as part of the outgoing response.                                     
[GetAuthCookie(String, Boolean, String)][8]  | Creates an authentication cookie for a given user name. This does not set the cookie as part of the outgoing response.                                     
[GetHashCode][9]                             | Serves as a hash function for a particular type. (Inherited from [Object][1].)                                                                             
[GetType][10]                                | Gets the [Type][11] of the current instance. (Inherited from [Object][1].)                                                                                 
[MemberwiseClone][12]                        | Creates a shallow copy of the current [Object][1]. (Inherited from [Object][1].)                                                                           
[SetAuthCookie(String)][13]                  | Creates an authentication ticket for the supplied user name and adds it to the cookies collection of the response.                                         
[SetAuthCookie(HttpCookie)][14]              | Adds the *cookie* to the cookies collection of the response.                                                                                               
[SetAuthCookie(String, Boolean)][15]         | Creates an authentication ticket for the supplied user name and adds it to the cookies collection of the response.                                         
[SetAuthCookie(String, Boolean, String)][16] | Creates an authentication ticket for the supplied user name and adds it to the cookies collection of the response, using the supplied cookie path.         
[SignOut][17]                                | Removes the forms-authentication ticket from the browser.                                                                                                  
[ToString][18]                               | Returns a string that represents the current object. (Inherited from [Object][1].)                                                                         


See Also
--------
[MvcAccount Namespace][2]  

[1]: http://msdn.microsoft.com/en-us/library/e5kfa45b
[2]: ../README.md
[3]: _ctor.md
[4]: http://msdn.microsoft.com/en-us/library/bsc2ak47
[5]: http://msdn.microsoft.com/en-us/library/4k87zsw7
[6]: GetAuthCookie.md
[7]: GetAuthCookie_1.md
[8]: GetAuthCookie_2.md
[9]: http://msdn.microsoft.com/en-us/library/zdee4b3y
[10]: http://msdn.microsoft.com/en-us/library/dfwy45w9
[11]: http://msdn.microsoft.com/en-us/library/42892f65
[12]: http://msdn.microsoft.com/en-us/library/57ctke0a
[13]: SetAuthCookie.md
[14]: SetAuthCookie_3.md
[15]: SetAuthCookie_1.md
[16]: SetAuthCookie_2.md
[17]: SignOut.md
[18]: http://msdn.microsoft.com/en-us/library/7bxwbwt2