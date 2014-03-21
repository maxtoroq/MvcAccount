SqlMembershipProviderPasswordService.ProcessPasswordForStorage Method
=====================================================================
Converts the *clearTextPassword* to one that is suitable for storage.

**Namespace:** [MvcAccount.Web.Security][1]  
**Assembly:** MvcAccount (in MvcAccount.dll)

Syntax
------

```csharp
public override string ProcessPasswordForStorage(
	string clearTextPassword
)
```

### Parameters

#### *clearTextPassword*
Type: [System.String][2]  
The password in clear text.

### Return Value
Type: [String][2]  
The password suitable for storage.

See Also
--------
[SqlMembershipProviderPasswordService Class][3]  
[MvcAccount.Web.Security Namespace][1]  

[1]: ../README.md
[2]: http://msdn.microsoft.com/en-us/library/s1wwdcbf
[3]: README.md