AccountMembershipProvider.GetUser Method (String, Boolean)
==========================================================
Gets information from the data source for a user.

**Namespace:** [MvcAccount][1]  
**Assembly:** MvcAccount (in MvcAccount.dll)

Syntax
------

```csharp
public override MembershipUser GetUser(
	string username,
	bool userIsOnline
)
```

### Parameters

#### *username*
Type: [System.String][2]  
The name of the user to get information for.

#### *userIsOnline*
Type: [System.Boolean][3]  
This parameter is ignored.

### Return Value
Type: [MembershipUser][4]  
 A [MembershipUser][4] object populated with the specified user's information from the data source. 

See Also
--------
[AccountMembershipProvider Class][5]  
[MvcAccount Namespace][1]  

[1]: ../README.md
[2]: http://msdn2.microsoft.com/en-us/library/s1wwdcbf
[3]: http://msdn2.microsoft.com/en-us/library/a28wyd50
[4]: http://msdn2.microsoft.com/en-us/library/d1b506ez
[5]: README.md