AccountMembershipProvider.ValidateUser Method
=============================================
Verifies that the specified user name and password exist in the data source.

**Namespace:** [MvcAccount][1]  
**Assembly:** MvcAccount (in MvcAccount.dll)

Syntax
------

```csharp
public override bool ValidateUser(
	string username,
	string password
)
```

### Parameters

#### *username*
Type: [System.String][2]  
The name of the user to validate.

#### *password*
Type: [System.String][2]  
The password for the specified user.

### Return Value
Type: [Boolean][3]  
true if the specified username and password are valid; otherwise, false.

See Also
--------
[AccountMembershipProvider Class][4]  
[MvcAccount Namespace][1]  

[1]: ../README.md
[2]: http://msdn2.microsoft.com/en-us/library/s1wwdcbf
[3]: http://msdn2.microsoft.com/en-us/library/a28wyd50
[4]: README.md