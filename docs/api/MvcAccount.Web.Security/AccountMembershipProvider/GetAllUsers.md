AccountMembershipProvider.GetAllUsers Method
============================================
This method always throws a [NotImplementedException][1].

**Namespace:** [MvcAccount.Web.Security][2]  
**Assembly:** MvcAccount (in MvcAccount.dll)

Syntax
------

```csharp
public override MembershipUserCollection GetAllUsers(
	int pageIndex,
	int pageSize,
	out int totalRecords
)
```

#### Parameters

##### *pageIndex*
Type: [System.Int32][3]  
The index of the page of results to return. pageIndex is zero-based.

##### *pageSize*
Type: [System.Int32][3]  
The size of the page of results to return.

##### *totalRecords*
Type: [System.Int32][3]  
The total number of matched users.

#### Return Value
Type: [MembershipUserCollection][4]  
 A [MembershipUserCollection][4] collection that contains a page of pageSize [MembershipUser][5] objects beginning at the page specified by pageIndex. 

See Also
--------

#### Reference
[AccountMembershipProvider Class][6]  
[MvcAccount.Web.Security Namespace][2]  

[1]: http://msdn.microsoft.com/en-us/library/6byb74h9
[2]: ../README.md
[3]: http://msdn.microsoft.com/en-us/library/td2s409d
[4]: http://msdn.microsoft.com/en-us/library/3xe386wc
[5]: http://msdn.microsoft.com/en-us/library/d1b506ez
[6]: README.md