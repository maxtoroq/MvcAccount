AccountConfiguration.SignInAttemptWindow Property
=================================================
The amount of time that must pass before a new sign in attempt, if user exceeded the [MaxInvalidSignInAttempts][1]. Not used if [DisableOnMaxInvalidSignInAttempts][2] is true. The default is 10 minutes.

**Namespace:** [MvcAccount][3]  
**Assembly:** MvcAccount (in MvcAccount.dll)

Syntax
------

```csharp
public TimeSpan SignInAttemptWindow { get; set; }
```

### Property Value
Type: [TimeSpan][4]

See Also
--------
[AccountConfiguration Class][5]  
[MvcAccount Namespace][3]  

[1]: MaxInvalidSignInAttempts.md
[2]: DisableOnMaxInvalidSignInAttempts.md
[3]: ../README.md
[4]: http://msdn.microsoft.com/en-us/library/269ew577
[5]: README.md