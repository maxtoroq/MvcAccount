HtmlUtility.HtmlHelperFor&lt;TModel> Method (HtmlHelper, TModel)
================================================================
Creates a strongly typed HTML helper.

**Namespace:** [MvcAccount][1]  
**Assembly:** MvcAccount (in MvcAccount.dll)

Syntax
------

```csharp
public static HtmlHelper<TModel> HtmlHelperFor<TModel>(
	HtmlHelper htmlHelper,
	TModel model
)
```

### Parameters

#### *htmlHelper*
Type: [System.Web.Mvc.HtmlHelper][2]  
The HTML helper of the view.

#### *model*
Type: **TModel**  
The model object.


Type Parameters
---------------

#### *TModel*
The type of the model.

### Return Value
Type: [HtmlHelper][3]&lt;**TModel**>  
A new [HtmlHelper<TModel>][3] object.

See Also
--------
[HtmlUtility Class][4]  
[MvcAccount Namespace][1]  

[1]: ../README.md
[2]: http://msdn2.microsoft.com/en-us/library/dd493095
[3]: http://msdn2.microsoft.com/en-us/library/dd492619
[4]: README.md