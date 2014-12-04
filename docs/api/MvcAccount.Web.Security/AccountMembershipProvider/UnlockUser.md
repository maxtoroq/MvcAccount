AccountMembershipProvider.UnlockUser Method
===========================================
This method always throws a [NotImplementedException][1].

**Namespace:** [MvcAccount.Web.Security][2]  
**Assembly:** MvcAccount (in MvcAccount.dll)

Syntax
------

```csharp
public override bool UnlockUser(
	string userName
)
```

### Parameters

#### *userName*
Type: [System.String][3]  
The user whose lock status you want to clear.

### Return Value
Type: [Boolean][4]  
true if the user was successfully unlocked; otherwise, false.

See Also
--------
[AccountMembershipProvider Class][5]  
[MvcAccount.Web.Security Namespace][2]  

[1]: http://msdn.microsoft.com/en-us/library/6byb74h9
[2]: ../README.md
[3]: http://msdn.microsoft.com/en-us/library/s1wwdcbf
[4]: http://msdn.microsoft.com/en-us/library/a28wyd50
[5]: README.md