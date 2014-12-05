PasswordLengthAttribute.GetClientValidationRules Method
=======================================================
Returns client validation rules.

**Namespace:** [MvcAccount][1]  
**Assembly:** MvcAccount (in MvcAccount.dll)

Syntax
------

```csharp
public IEnumerable<ModelClientValidationRule> GetClientValidationRules(
	ModelMetadata metadata,
	ControllerContext context
)
```

#### Parameters

##### *metadata*
Type: [System.Web.Mvc.ModelMetadata][2]  
The model metadata.

##### *context*
Type: [System.Web.Mvc.ControllerContext][3]  
The controller context.

#### Return Value
Type: [IEnumerable][4]&lt;[ModelClientValidationRule][5]>  
The client validation rules for this validator.
#### Implements
[IClientValidatable.GetClientValidationRules(ModelMetadata, ControllerContext)][6]  


See Also
--------

#### Reference
[PasswordLengthAttribute Class][7]  
[MvcAccount Namespace][1]  

[1]: ../README.md
[2]: http://msdn.microsoft.com/en-us/library/ee407408
[3]: http://msdn.microsoft.com/en-us/library/dd492673
[4]: http://msdn.microsoft.com/en-us/library/9eekhta0
[5]: http://msdn.microsoft.com/en-us/library/ee450611
[6]: http://msdn.microsoft.com/en-us/library/gg416550
[7]: README.md