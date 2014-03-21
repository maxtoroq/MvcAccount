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
[CreateFormsAuthenticationTicket][4]         | Creates a [FormsAuthenticationTicket][5] instance.                                                                                                         
[Equals][6]                                  | Determines whether the specified [Object][1] is equal to the current [Object][1]. (Inherited from [Object][1].)                                            
[Finalize][7]                                | Allows an object to try to free resources and perform other cleanup operations before it is reclaimed by garbage collection. (Inherited from [Object][1].) 
[GetAuthCookie(String)][8]                   | Creates an authentication cookie for a given user name. This does not set the cookie as part of the outgoing response.                                     
[GetAuthCookie(String, Boolean)][9]          | Creates an authentication cookie for a given user name. This does not set the cookie as part of the outgoing response.                                     
[GetAuthCookie(String, Boolean, String)][10] | Creates an authentication cookie for a given user name. This does not set the cookie as part of the outgoing response.                                     
[GetHashCode][11]                            | Serves as a hash function for a particular type. (Inherited from [Object][1].)                                                                             
[GetType][12]                                | Gets the [Type][13] of the current instance. (Inherited from [Object][1].)                                                                                 
[MemberwiseClone][14]                        | Creates a shallow copy of the current [Object][1]. (Inherited from [Object][1].)                                                                           
[SetAuthCookie(String)][15]                  | Creates an authentication ticket for the supplied user name and adds it to the cookies collection of the response.                                         
[SetAuthCookie(HttpCookie)][16]              | Adds the *cookie* to the cookies collection of the response.                                                                                               
[SetAuthCookie(String, Boolean)][17]         | Creates an authentication ticket for the supplied user name and adds it to the cookies collection of the response.                                         
[SetAuthCookie(String, Boolean, String)][18] | Creates an authentication ticket for the supplied user name and adds it to the cookies collection of the response, using the supplied cookie path.         
[SignOut][19]                                | Removes the forms-authentication ticket from the browser.                                                                                                  
[ToString][20]                               | Returns a string that represents the current object. (Inherited from [Object][1].)                                                                         


Properties
----------

Name                | Description                                                      
------------------- | ---------------------------------------------------------------- 
[Configuration][21] | The [AccountConfiguration][22] instance for the current request. 


See Also
--------
[MvcAccount Namespace][2]  

[1]: http://msdn.microsoft.com/en-us/library/e5kfa45b
[2]: ../README.md
[3]: _ctor.md
[4]: CreateFormsAuthenticationTicket.md
[5]: http://msdn.microsoft.com/en-us/library/se1843z2
[6]: http://msdn.microsoft.com/en-us/library/bsc2ak47
[7]: http://msdn.microsoft.com/en-us/library/4k87zsw7
[8]: GetAuthCookie.md
[9]: GetAuthCookie_1.md
[10]: GetAuthCookie_2.md
[11]: http://msdn.microsoft.com/en-us/library/zdee4b3y
[12]: http://msdn.microsoft.com/en-us/library/dfwy45w9
[13]: http://msdn.microsoft.com/en-us/library/42892f65
[14]: http://msdn.microsoft.com/en-us/library/57ctke0a
[15]: SetAuthCookie.md
[16]: SetAuthCookie_3.md
[17]: SetAuthCookie_1.md
[18]: SetAuthCookie_2.md
[19]: SignOut.md
[20]: http://msdn.microsoft.com/en-us/library/7bxwbwt2
[21]: Configuration.md
[22]: ../AccountConfiguration/README.md