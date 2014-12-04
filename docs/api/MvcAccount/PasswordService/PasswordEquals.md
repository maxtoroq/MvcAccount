PasswordService.PasswordEquals Method
=====================================
Compares a password provided by a user to one that is stored.

**Namespace:** [MvcAccount][1]  
**Assembly:** MvcAccount (in MvcAccount.dll)

Syntax
------

```csharp
public abstract bool PasswordEquals(
	string clearTextPassword,
	string storedPassword
)
```

### Parameters

#### *clearTextPassword*
Type: [System.String][2]  
The password in clear text provided by a user.

#### *storedPassword*
Type: [System.String][2]  
The stored password.

### Return Value
Type: [Boolean][3]  
true if the passwords are equal; otherwise false.

See Also
--------
[PasswordService Class][4]  
[MvcAccount Namespace][1]  

[1]: ../README.md
[2]: http://msdn.microsoft.com/en-us/library/s1wwdcbf
[3]: http://msdn.microsoft.com/en-us/library/a28wyd50
[4]: README.md