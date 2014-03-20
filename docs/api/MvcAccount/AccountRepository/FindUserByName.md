AccountRepository.FindUserByName Method
=======================================
Gets the user that matches the provided *username*.

**Namespace:** [MvcAccount][1]  
**Assembly:** MvcAccount (in MvcAccount.dll)

Syntax
------

```csharp
public abstract Object FindUserByName(
	string username
)
```

### Parameters

#### *username*
Type: [System.String][2]  
The username.

### Return Value
Type: [Object][3]  
The user object whose username matches *username*, or null if not found.

See Also
--------
[AccountRepository Class][4]  
[MvcAccount Namespace][1]  

[1]: ../README.md
[2]: http://msdn2.microsoft.com/en-us/library/s1wwdcbf
[3]: http://msdn2.microsoft.com/en-us/library/e5kfa45b
[4]: README.md