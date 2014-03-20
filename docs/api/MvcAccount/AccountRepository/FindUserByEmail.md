AccountRepository.FindUserByEmail Method
========================================
Gets the user whose email matches the provided *email*.

**Namespace:** [MvcAccount][1]  
**Assembly:** MvcAccount (in MvcAccount.dll)

Syntax
------

```csharp
public abstract Object FindUserByEmail(
	string email
)
```

### Parameters

#### *email*
Type: [System.String][2]  
The user's email.

### Return Value
Type: [Object][3]  
The user object whose email matches the provided *email*, or null if not found.

See Also
--------
[AccountRepository Class][4]  
[MvcAccount Namespace][1]  

[1]: ../README.md
[2]: http://msdn2.microsoft.com/en-us/library/s1wwdcbf
[3]: http://msdn2.microsoft.com/en-us/library/e5kfa45b
[4]: README.md