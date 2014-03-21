PasswordService.ValidatePassword Method
=======================================
Validates a new password provided by a user. This method can be used to check if the new password has the length required by the encryption method. Returns null by default, which means all passwords are valid.

**Namespace:** [MvcAccount][1]  
**Assembly:** MvcAccount (in MvcAccount.dll)

Syntax
------

```csharp
public virtual string ValidatePassword(
	string clearTextPassword
)
```

### Parameters

#### *clearTextPassword*
Type: [System.String][2]  
The new password in clear text.

### Return Value
Type: [String][2]  
An error message if the password is not valid; otherwise null.

Remarks
-------
 To customize password length requirements use [MinPasswordLength][3] and [MaxPasswordLength][4] instead. Override this method if you need to check for additional strength requirements, and make sure to call the base class method first. 

See Also
--------
[PasswordService Class][5]  
[MvcAccount Namespace][1]  

[1]: ../README.md
[2]: http://msdn.microsoft.com/en-us/library/s1wwdcbf
[3]: ../AccountConfiguration/MinPasswordLength.md
[4]: ../AccountConfiguration/MaxPasswordLength.md
[5]: README.md