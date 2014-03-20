AccountMembershipProvider.ResetPassword Method
==============================================
This method always throws a [NotImplementedException][1].

**Namespace:** [MvcAccount.Web.Security][2]  
**Assembly:** MvcAccount (in MvcAccount.dll)

Syntax
------

```csharp
public override string ResetPassword(
	string username,
	string answer
)
```

### Parameters

#### *username*
Type: [System.String][3]  
The user to reset the password for.

#### *answer*
Type: [System.String][3]  
The password answer for the specified user.

### Return Value
Type: [String][3]  
The new password for the specified user.

See Also
--------
[AccountMembershipProvider Class][4]  
[MvcAccount.Web.Security Namespace][2]  

[1]: http://msdn2.microsoft.com/en-us/library/6byb74h9
[2]: ../README.md
[3]: http://msdn2.microsoft.com/en-us/library/s1wwdcbf
[4]: README.md