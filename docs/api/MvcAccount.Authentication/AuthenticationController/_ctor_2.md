AuthenticationController Constructor (AccountRepository, PasswordService, FormsAuthenticationService)
=====================================================================================================
Initializes a new instance of the [AuthenticationController][1] class, with the provided *repo*, *passwordService* and *formsAuthService*.

**Namespace:** [MvcAccount.Authentication][2]  
**Assembly:** MvcAccount (in MvcAccount.dll)

Syntax
------

```csharp
public AuthenticationController(
	AccountRepository repo,
	PasswordService passwordService,
	FormsAuthenticationService formsAuthService
)
```

#### Parameters

##### *repo*
Type: [MvcAccount.AccountRepository][3]  
The account repository.

##### *passwordService*
Type: [MvcAccount.PasswordService][4]  
The password service.

##### *formsAuthService*
Type: [MvcAccount.FormsAuthenticationService][5]  
The forms authentication service.


See Also
--------

#### Reference
[AuthenticationController Class][1]  
[MvcAccount.Authentication Namespace][2]  

[1]: README.md
[2]: ../README.md
[3]: ../../MvcAccount/AccountRepository/README.md
[4]: ../../MvcAccount/PasswordService/README.md
[5]: ../../MvcAccount/FormsAuthenticationService/README.md