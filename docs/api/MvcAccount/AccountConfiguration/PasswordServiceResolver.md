AccountConfiguration.PasswordServiceResolver Property
=====================================================
A delegate that returns the [PasswordService][1] implementation for this application. This setting is optional if using controller dependency injection, but required when using [AccountMembershipProvider][2].

**Namespace:** [MvcAccount][3]  
**Assembly:** MvcAccount (in MvcAccount.dll)

Syntax
------

```csharp
public Func<PasswordService> PasswordServiceResolver { get; set; }
```

### Property Value
Type: [Func][4]&lt;[PasswordService][1]>

See Also
--------
[AccountConfiguration Class][5]  
[MvcAccount Namespace][3]  

[1]: ../PasswordService/README.md
[2]: ../AccountMembershipProvider/README.md
[3]: ../README.md
[4]: http://msdn2.microsoft.com/en-us/library/bb534960
[5]: README.md