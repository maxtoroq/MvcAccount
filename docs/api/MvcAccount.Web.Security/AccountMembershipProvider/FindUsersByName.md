AccountMembershipProvider.FindUsersByName Method
================================================
This method always throws a [NotImplementedException][1].

**Namespace:** [MvcAccount.Web.Security][2]  
**Assembly:** MvcAccount (in MvcAccount.dll)

Syntax
------

```csharp
public override MembershipUserCollection FindUsersByName(
	string usernameToMatch,
	int pageIndex,
	int pageSize,
	out int totalRecords
)
```

#### Parameters

##### *usernameToMatch*
Type: [System.String][3]  
The user name to search for.

##### *pageIndex*
Type: [System.Int32][4]  
The index of the page of results to return. pageIndex is zero-based.

##### *pageSize*
Type: [System.Int32][4]  
The size of the page of results to return.

##### *totalRecords*
Type: [System.Int32][4]  
The total number of matched users.

#### Return Value
Type: [MembershipUserCollection][5]  
 A [MembershipUserCollection][5] collection that contains a page of pageSize [MembershipUser][6] objects beginning at the page specified by pageIndex. 

See Also
--------

#### Reference
[AccountMembershipProvider Class][7]  
[MvcAccount.Web.Security Namespace][2]  

[1]: http://msdn.microsoft.com/en-us/library/6byb74h9
[2]: ../README.md
[3]: http://msdn.microsoft.com/en-us/library/s1wwdcbf
[4]: http://msdn.microsoft.com/en-us/library/td2s409d
[5]: http://msdn.microsoft.com/en-us/library/3xe386wc
[6]: http://msdn.microsoft.com/en-us/library/d1b506ez
[7]: README.md