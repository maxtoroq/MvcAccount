HtmlUtility.Link Method (LinkModel, RouteValueDictionary)
=========================================================
Returns an anchor element (a element) created using the provided link model.

**Namespace:** [MvcAccount][1]  
**Assembly:** MvcAccount (in MvcAccount.dll)

Syntax
------

```csharp
public static MvcHtmlString Link(
	LinkModel linkModel,
	RouteValueDictionary htmlAttributes
)
```

### Parameters

#### *linkModel*
Type: [MvcAccount.ViewModels.LinkModel][2]  
The link model.

#### *htmlAttributes*
Type: [System.Web.Routing.RouteValueDictionary][3]  
An object that contains the HTML attributes to set for the element.

### Return Value
Type: [MvcHtmlString][4]  
An anchor element (a element).

See Also
--------
[HtmlUtility Class][5]  
[MvcAccount Namespace][1]  

[1]: ../README.md
[2]: ../../MvcAccount.ViewModels/LinkModel/README.md
[3]: http://msdn2.microsoft.com/en-us/library/cc679915
[4]: http://msdn2.microsoft.com/en-us/library/ee461471
[5]: README.md