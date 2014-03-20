AccountMembershipProvider.DeleteUser Method
===========================================
This method always throws a [NotImplementedException][1].

**Namespace:** [MvcAccount.Web.Security][2]  
**Assembly:** MvcAccount (in MvcAccount.dll)

Syntax
------

```csharp
public override bool DeleteUser(
	string username,
	bool deleteAllRelatedData
)
```

### Parameters

#### *username*
Type: [System.String][3]  
The name of the user to delete.

#### *deleteAllRelatedData*
Type: [System.Boolean][4]  
true to delete data related to the user from the database; false to leave data related to the user in the database.

### Return Value
Type: [Boolean][4]  
true if the user was successfully deleted; otherwise, false.

See Also
--------
[AccountMembershipProvider Class][5]  
[MvcAccount.Web.Security Namespace][2]  

[1]: http://msdn2.microsoft.com/en-us/library/6byb74h9
[2]: ../README.md
[3]: http://msdn2.microsoft.com/en-us/library/s1wwdcbf
[4]: http://msdn2.microsoft.com/en-us/library/a28wyd50
[5]: README.md