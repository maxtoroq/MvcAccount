AccountConfiguration.ConfigurationResolver Property
===================================================
A delegate that returns an [AccountConfiguration][1] instance. This setting is required only when using [AccountMembershipProvider][2].

**Namespace:** [MvcAccount][3]  
**Assembly:** MvcAccount (in MvcAccount.dll)

Syntax
------

```csharp
public static Func<AccountConfiguration> ConfigurationResolver { get; set; }
```

### Property Value
Type: [Func][4]&lt;[AccountConfiguration][1]>

See Also
--------
[AccountConfiguration Class][1]  
[MvcAccount Namespace][3]  

[1]: README.md
[2]: ../../MvcAccount.Web.Security/AccountMembershipProvider/README.md
[3]: ../README.md
[4]: http://msdn2.microsoft.com/en-us/library/bb534960