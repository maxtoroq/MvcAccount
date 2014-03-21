AccountMembershipProvider.CreateUser Method
===========================================
This method always throws a [NotImplementedException][1].

**Namespace:** [MvcAccount][2]  
**Assembly:** MvcAccount (in MvcAccount.dll)

Syntax
------

```csharp
public override MembershipUser CreateUser(
	string username,
	string password,
	string email,
	string passwordQuestion,
	string passwordAnswer,
	bool isApproved,
	Object providerUserKey,
	out MembershipCreateStatus status
)
```

### Parameters

#### *username*
Type: [System.String][3]  
The user name for the new user.

#### *password*
Type: [System.String][3]  
The password for the new user.

#### *email*
Type: [System.String][3]  
The e-mail address for the new user.

#### *passwordQuestion*
Type: [System.String][3]  
The password question for the new user.

#### *passwordAnswer*
Type: [System.String][3]  
The password answer for the new user

#### *isApproved*
Type: [System.Boolean][4]  
Whether or not the new user is approved to be validated.

#### *providerUserKey*
Type: [System.Object][5]  
The unique identifier from the membership data source for the user.

#### *status*
Type: [System.Web.Security.MembershipCreateStatus][6]  
A [MembershipCreateStatus][6] enumeration value indicating whether the user was created successfully.

### Return Value
Type: [MembershipUser][7]  
 A [MembershipUser][7] object populated with the information for the newly created user. 

See Also
--------
[AccountMembershipProvider Class][8]  
[MvcAccount Namespace][2]  

[1]: http://msdn.microsoft.com/en-us/library/6byb74h9
[2]: ../README.md
[3]: http://msdn.microsoft.com/en-us/library/s1wwdcbf
[4]: http://msdn.microsoft.com/en-us/library/a28wyd50
[5]: http://msdn.microsoft.com/en-us/library/e5kfa45b
[6]: http://msdn.microsoft.com/en-us/library/czcfs330
[7]: http://msdn.microsoft.com/en-us/library/d1b506ez
[8]: README.md