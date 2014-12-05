AccountMembershipProvider.ChangePassword Method
===============================================
This method always throws a [NotImplementedException][1].

**Namespace:** [MvcAccount.Web.Security][2]  
**Assembly:** MvcAccount (in MvcAccount.dll)

Syntax
------

```csharp
public override bool ChangePassword(
	string username,
	string oldPassword,
	string newPassword
)
```

#### Parameters

##### *username*
Type: [System.String][3]  
The user to update the password for.

##### *oldPassword*
Type: [System.String][3]  
The current password for the specified user.

##### *newPassword*
Type: [System.String][3]  
The new password for the specified user.

#### Return Value
Type: [Boolean][4]  
true if the password was updated successfully; otherwise, false.

See Also
--------

#### Reference
[AccountMembershipProvider Class][5]  
[MvcAccount.Web.Security Namespace][2]  

[1]: http://msdn.microsoft.com/en-us/library/6byb74h9
[2]: ../README.md
[3]: http://msdn.microsoft.com/en-us/library/s1wwdcbf
[4]: http://msdn.microsoft.com/en-us/library/a28wyd50
[5]: README.md