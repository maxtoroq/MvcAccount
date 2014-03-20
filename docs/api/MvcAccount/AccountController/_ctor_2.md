AccountController Constructor (AccountRepository, PasswordService, FormsAuthenticationService)
==============================================================================================
Initializes a new instance of the [AccountController][1] class using the provided repository, password service and forms authentication service.

**Namespace:** [MvcAccount][2]  
**Assembly:** MvcAccount (in MvcAccount.dll)

Syntax
------

```csharp
public AccountController(
	AccountRepository repository,
	PasswordService passwordService,
	FormsAuthenticationService formsAuthService
)
```

### Parameters

#### *repository*
Type: [MvcAccount.AccountRepository][3]  
The account repository.

#### *passwordService*
Type: [MvcAccount.PasswordService][4]  
The passsword service.

#### *formsAuthService*
Type: [MvcAccount.FormsAuthenticationService][5]  
The forms authentication service.


See Also
--------
[AccountController Class][1]  
[MvcAccount Namespace][2]  

[1]: README.md
[2]: ../README.md
[3]: ../AccountRepository/README.md
[4]: ../PasswordService/README.md
[5]: ../FormsAuthenticationService/README.md