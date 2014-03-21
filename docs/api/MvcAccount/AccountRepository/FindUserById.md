AccountRepository.FindUserById Method
=====================================
Gets the user that matches the provided unique identifier. Note to Implementers: *id* can be provided as a [String][1], make sure to convert the value if needed. e.g. `int intId = Convert.ToInt32(id);`

**Namespace:** [MvcAccount][2]  
**Assembly:** MvcAccount (in MvcAccount.dll)

Syntax
------

```csharp
public abstract Object FindUserById(
	Object id
)
```

### Parameters

#### *id*
Type: [System.Object][3]  
The user unique identifier.

### Return Value
Type: [Object][3]  
The user object whose unique identifier matches *id*, or null if not found.

See Also
--------
[AccountRepository Class][4]  
[MvcAccount Namespace][2]  

[1]: http://msdn.microsoft.com/en-us/library/s1wwdcbf
[2]: ../README.md
[3]: http://msdn.microsoft.com/en-us/library/e5kfa45b
[4]: README.md