FormsAuthenticationService.GetAuthCookie Method (String)
========================================================
Creates an authentication cookie for a given user name. This does not set the cookie as part of the outgoing response.

**Namespace:** [MvcAccount][1]  
**Assembly:** MvcAccount (in MvcAccount.dll)

Syntax
------

```csharp
public HttpCookie GetAuthCookie(
	string userName
)
```

### Parameters

#### *userName*
Type: [System.String][2]  
The name of the authenticated user.

### Return Value
Type: [HttpCookie][3]  
 An [HttpCookie][3] that contains encrypted forms-authentication ticket information. 

See Also
--------
[FormsAuthenticationService Class][4]  
[MvcAccount Namespace][1]  

[1]: ../README.md
[2]: http://msdn.microsoft.com/en-us/library/s1wwdcbf
[3]: http://msdn.microsoft.com/en-us/library/zw640823
[4]: README.md