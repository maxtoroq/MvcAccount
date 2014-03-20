AuthenticationController.SignIn Method (SignInInput, String)
============================================================
Attempts to sign in.

**Namespace:** [MvcAccount.Authentication][1]  
**Assembly:** MvcAccount (in MvcAccount.dll)

Syntax
------

```csharp
public ActionResult SignIn(
	SignInInput input,
	string returnUrl
)
```

### Parameters

#### *input*
Type: [MvcAccount.Authentication.SignInInput][2]  
The input model.

#### *returnUrl*
Type: [System.String][3]  
A URL to redirect to if the operation succeeds.

### Return Value
Type: [ActionResult][4]  
The action result.

See Also
--------
[AuthenticationController Class][5]  
[MvcAccount.Authentication Namespace][1]  

[1]: ../README.md
[2]: ../SignInInput/README.md
[3]: http://msdn2.microsoft.com/en-us/library/s1wwdcbf
[4]: http://msdn2.microsoft.com/en-us/library/dd493064
[5]: README.md