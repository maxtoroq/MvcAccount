FormsAuthenticationService.GetAuthCookie Method (String, Boolean, String)
=========================================================================
Creates an authentication cookie for a given user name. This does not set the cookie as part of the outgoing response.

**Namespace:** [MvcAccount][1]  
**Assembly:** MvcAccount (in MvcAccount.dll)

Syntax
------

```csharp
public virtual HttpCookie GetAuthCookie(
	string userName,
	bool createPersistentCookie,
	string strCookiePath
)
```

#### Parameters

##### *userName*
Type: [System.String][2]  
The name of the authenticated user.

##### *createPersistentCookie*
Type: [System.Boolean][3]  
 true to create a durable cookie (one that is saved across browser sessions); otherwise, false.

##### *strCookiePath*
Type: [System.String][2]  
The [Path][4] of the authentication cookie.

#### Return Value
Type: [HttpCookie][5]  
 An [HttpCookie][5] that contains encrypted forms-authentication ticket information. 

See Also
--------

#### Reference
[FormsAuthenticationService Class][6]  
[MvcAccount Namespace][1]  

[1]: ../README.md
[2]: http://msdn.microsoft.com/en-us/library/s1wwdcbf
[3]: http://msdn.microsoft.com/en-us/library/a28wyd50
[4]: http://msdn.microsoft.com/en-us/library/6tc50289
[5]: http://msdn.microsoft.com/en-us/library/zw640823
[6]: README.md