ResetController.Finish Method (String, FinishInput)
===================================================
Attempts to reset the password.

**Namespace:** [MvcAccount.Password.Reset][1]  
**Assembly:** MvcAccount (in MvcAccount.dll)

Syntax
------

```csharp
public ActionResult Finish(
	string id,
	FinishInput input
)
```

### Parameters

#### *id*
Type: [System.String][2]  
The verification ticket.

#### *input*
Type: [MvcAccount.Password.Reset.FinishInput][3]  
The input model.

### Return Value
Type: [ActionResult][4]  
The action result.

See Also
--------
[ResetController Class][5]  
[MvcAccount.Password.Reset Namespace][1]  

[1]: ../README.md
[2]: http://msdn.microsoft.com/en-us/library/s1wwdcbf
[3]: ../FinishInput/README.md
[4]: http://msdn.microsoft.com/en-us/library/dd493064
[5]: README.md