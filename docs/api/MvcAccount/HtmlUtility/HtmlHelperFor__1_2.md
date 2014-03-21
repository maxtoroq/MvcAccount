HtmlUtility.HtmlHelperFor&lt;TModel> Method (HtmlHelper, TModel, String)
========================================================================
Creates a strongly typed HTML helper.

**Namespace:** [MvcAccount][1]  
**Assembly:** MvcAccount (in MvcAccount.dll)

Syntax
------

```csharp
public static HtmlHelper<TModel> HtmlHelperFor<TModel>(
	HtmlHelper htmlHelper,
	TModel model,
	string htmlFieldPrefix
)
```

### Parameters

#### *htmlHelper*
Type: [System.Web.Mvc.HtmlHelper][2]  
The HTML helper of the view.

#### *model*
Type: **TModel**  
The model object.

#### *htmlFieldPrefix*
Type: [System.String][3]  
The HTML field prefix for the new HTML helper.


Type Parameters
---------------

#### *TModel*
The type of the model.

### Return Value
Type: [HtmlHelper][4]&lt;**TModel**>  
A new [HtmlHelper<TModel>][4] object.

See Also
--------
[HtmlUtility Class][5]  
[MvcAccount Namespace][1]  

[1]: ../README.md
[2]: http://msdn.microsoft.com/en-us/library/dd493095
[3]: http://msdn.microsoft.com/en-us/library/s1wwdcbf
[4]: http://msdn.microsoft.com/en-us/library/dd492619
[5]: README.md