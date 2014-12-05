AccountConfiguration.DependencyResolver Property
================================================
A delegate for resoving dependencies. This setting can be used instead of [AccountRepositoryResolver][1] and [PasswordServiceResolver][2].

**Namespace:** [MvcAccount][3]  
**Assembly:** MvcAccount (in MvcAccount.dll)

Syntax
------

```csharp
public Func<Type, Object> DependencyResolver { get; set; }
```

#### Property Value
Type: [Func][4]&lt;[Type][5], [Object][6]>

See Also
--------

#### Reference
[AccountConfiguration Class][7]  
[MvcAccount Namespace][3]  

[1]: AccountRepositoryResolver.md
[2]: PasswordServiceResolver.md
[3]: ../README.md
[4]: http://msdn.microsoft.com/en-us/library/bb549151
[5]: http://msdn.microsoft.com/en-us/library/42892f65
[6]: http://msdn.microsoft.com/en-us/library/e5kfa45b
[7]: README.md