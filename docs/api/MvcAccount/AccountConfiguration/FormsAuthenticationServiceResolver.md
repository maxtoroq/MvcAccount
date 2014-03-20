AccountConfiguration.FormsAuthenticationServiceResolver Property
================================================================
A delegate that returns a [FormsAuthenticationService][1] instance. This setting is always optional since [FormsAuthenticationService][1] is a concrete type, but can be used to provide a specialized implementation.

**Namespace:** [MvcAccount][2]  
**Assembly:** MvcAccount (in MvcAccount.dll)

Syntax
------

```csharp
public Func<FormsAuthenticationService> FormsAuthenticationServiceResolver { get; set; }
```

### Property Value
Type: [Func][3]&lt;[FormsAuthenticationService][1]>

See Also
--------
[AccountConfiguration Class][4]  
[MvcAccount Namespace][2]  

[1]: ../FormsAuthenticationService/README.md
[2]: ../README.md
[3]: http://msdn2.microsoft.com/en-us/library/bb534960
[4]: README.md