AccountMembershipProvider.GetUser Method (Object, Boolean)
==========================================================
Gets user information from the data source based on the unique identifier for the user.

**Namespace:** [MvcAccount.Web.Security][1]  
**Assembly:** MvcAccount (in MvcAccount.dll)

Syntax
------

```csharp
public override MembershipUser GetUser(
	Object providerUserKey,
	bool userIsOnline
)
```

### Parameters

#### *providerUserKey*
Type: [System.Object][2]  
The unique identifier for the user to get information for.

#### *userIsOnline*
Type: [System.Boolean][3]  
This parameter is ignored.

### Return Value
Type: [MembershipUser][4]  
 A [MembershipUser][4] object populated with the specified user's information from the data source. 

See Also
--------
[AccountMembershipProvider Class][5]  
[MvcAccount.Web.Security Namespace][1]  

[1]: ../README.md
[2]: http://msdn.microsoft.com/en-us/library/e5kfa45b
[3]: http://msdn.microsoft.com/en-us/library/a28wyd50
[4]: http://msdn.microsoft.com/en-us/library/d1b506ez
[5]: README.md