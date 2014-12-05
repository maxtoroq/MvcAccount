FormsAuthenticationService.CreateFormsAuthenticationTicket Method
=================================================================
Creates a [FormsAuthenticationTicket][1] instance.

**Namespace:** [MvcAccount][2]  
**Assembly:** MvcAccount (in MvcAccount.dll)

Syntax
------

```csharp
protected virtual FormsAuthenticationTicket CreateFormsAuthenticationTicket(
	int version,
	string name,
	DateTime issueDate,
	DateTime expiration,
	bool isPersistent,
	string cookiePath
)
```

#### Parameters

##### *version*
Type: [System.Int32][3]  
The version number of the ticket.

##### *name*
Type: [System.String][4]  
The user name associated with the ticket.

##### *issueDate*
Type: [System.DateTime][5]  
The local date and time at which the ticket was issued.

##### *expiration*
Type: [System.DateTime][5]  
The local date and time at which the ticket expires.

##### *isPersistent*
Type: [System.Boolean][6]  
true if the ticket will be stored in a persistent cookie (saved across browser sessions); otherwise, false. If the ticket is stored in the URL, this value is ignored.

##### *cookiePath*
Type: [System.String][4]  
The user-specific data to be stored with the ticket.

#### Return Value
Type: [FormsAuthenticationTicket][1]  
A new [FormsAuthenticationTicket][1] instance.

Remarks
-------
This method can be overriden to provide a value for the userData parameter.

See Also
--------

#### Reference
[FormsAuthenticationService Class][7]  
[MvcAccount Namespace][2]  

[1]: http://msdn.microsoft.com/en-us/library/se1843z2
[2]: ../README.md
[3]: http://msdn.microsoft.com/en-us/library/td2s409d
[4]: http://msdn.microsoft.com/en-us/library/s1wwdcbf
[5]: http://msdn.microsoft.com/en-us/library/03ybds8y
[6]: http://msdn.microsoft.com/en-us/library/a28wyd50
[7]: README.md