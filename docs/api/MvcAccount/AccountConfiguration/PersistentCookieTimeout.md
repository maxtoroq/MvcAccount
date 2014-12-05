AccountConfiguration.PersistentCookieTimeout Property
=====================================================
Specifies the time after which persistent authentication cookies expire. The default is 7 days.

**Namespace:** [MvcAccount][1]  
**Assembly:** MvcAccount (in MvcAccount.dll)

Syntax
------

```csharp
public TimeSpan PersistentCookieTimeout { get; set; }
```

#### Property Value
Type: [TimeSpan][2]

Remarks
-------
 ASP.NET uses the same expiration for both persistent and non-persistent authentication cookies. This settings allows you to increase the expiration of persistent authentication cookies. 

See Also
--------

#### Reference
[AccountConfiguration Class][3]  
[MvcAccount Namespace][1]  

[1]: ../README.md
[2]: http://msdn.microsoft.com/en-us/library/269ew577
[3]: README.md