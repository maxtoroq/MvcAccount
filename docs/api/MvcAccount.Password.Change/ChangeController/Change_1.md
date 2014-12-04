ChangeController.Change Method (ChangeInput, FormButton)
========================================================
Attempts to change the password.

**Namespace:** [MvcAccount.Password.Change][1]  
**Assembly:** MvcAccount (in MvcAccount.dll)

Syntax
------

```csharp
public ActionResult Change(
	ChangeInput input,
	FormButton cancel
)
```

### Parameters

#### *input*
Type: [MvcAccount.Password.Change.ChangeInput][2]  
The input model.

#### *cancel*
Type: [MvcAccount.Shared.FormButton][3]  
A value that indicates if the operation was cancelled by the user.

### Return Value
Type: [ActionResult][4]  
The action result.

See Also
--------
[ChangeController Class][5]  
[MvcAccount.Password.Change Namespace][1]  

[1]: ../README.md
[2]: ../ChangeInput/README.md
[3]: ../../MvcAccount.Shared/FormButton/README.md
[4]: http://msdn.microsoft.com/en-us/library/dd493064
[5]: README.md