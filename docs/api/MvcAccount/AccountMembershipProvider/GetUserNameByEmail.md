AccountMembershipProvider.GetUserNameByEmail Method
===================================================
This method always throws a [NotImplementedException][1].

**Namespace:** [MvcAccount][2]  
**Assembly:** MvcAccount (in MvcAccount.dll)

Syntax
------

```csharp
public override string GetUserNameByEmail(
	string email
)
```

### Parameters

#### *email*
Type: [System.String][3]  
The e-mail address to search for.

### Return Value
Type: [String][3]  
 The user name associated with the specified e-mail address. If no match is found, return null. 

See Also
--------
[AccountMembershipProvider Class][4]  
[MvcAccount Namespace][2]  

[1]: http://msdn.microsoft.com/en-us/library/6byb74h9
[2]: ../README.md
[3]: http://msdn.microsoft.com/en-us/library/s1wwdcbf
[4]: README.md