AccountMembershipProvider.ChangePasswordQuestionAndAnswer Method
================================================================
This method always throws a [NotImplementedException][1].

**Namespace:** [MvcAccount.Web.Security][2]  
**Assembly:** MvcAccount (in MvcAccount.dll)

Syntax
------

```csharp
public override bool ChangePasswordQuestionAndAnswer(
	string username,
	string password,
	string newPasswordQuestion,
	string newPasswordAnswer
)
```

### Parameters

#### *username*
Type: [System.String][3]  
The user to change the password question and answer for.

#### *password*
Type: [System.String][3]  
The password for the specified user.

#### *newPasswordQuestion*
Type: [System.String][3]  
The new password question for the specified user.

#### *newPasswordAnswer*
Type: [System.String][3]  
The new password answer for the specified user.

### Return Value
Type: [Boolean][4]  
true if the password question and answer are updated successfully; otherwise, false.

See Also
--------
[AccountMembershipProvider Class][5]  
[MvcAccount.Web.Security Namespace][2]  

[1]: http://msdn2.microsoft.com/en-us/library/6byb74h9
[2]: ../README.md
[3]: http://msdn2.microsoft.com/en-us/library/s1wwdcbf
[4]: http://msdn2.microsoft.com/en-us/library/a28wyd50
[5]: README.md