FormsAuthenticationService.SetAuthCookie Method (String, Boolean, String)
=========================================================================
Creates an authentication ticket for the supplied user name and adds it to the cookies collection of the response, using the supplied cookie path.

**Namespace:** [MvcAccount][1]  
**Assembly:** MvcAccount (in MvcAccount.dll)

Syntax
------

```csharp
public void SetAuthCookie(
	string userName,
	bool createPersistentCookie,
	string strCookiePath
)
```

#### Parameters

##### *userName*
Type: [System.String][2]  
The name of an authenticated user.

##### *createPersistentCookie*
Type: [System.Boolean][3]  
 true to create a durable cookie (one that is saved across browser sessions); otherwise, false.

##### *strCookiePath*
Type: [System.String][2]  
The cookie path for the forms-authentication ticket.


See Also
--------

#### Reference
[FormsAuthenticationService Class][4]  
[MvcAccount Namespace][1]  

[1]: ../README.md
[2]: http://msdn.microsoft.com/en-us/library/s1wwdcbf
[3]: http://msdn.microsoft.com/en-us/library/a28wyd50
[4]: README.md