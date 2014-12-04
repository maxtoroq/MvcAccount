FormButton Structure
====================
Represents a boolean value that indicates if a form submission was triggered by a particular button.

**Namespace:** [MvcAccount.Shared][1]  
**Assembly:** MvcAccount (in MvcAccount.dll)

Syntax
------

```csharp
public struct FormButton
```

The **FormButton** type exposes the following members.


Operators
---------

                                   | Name                                 | Description               
---------------------------------- | ------------------------------------ | ------------------------- 
![Public operator]![Static member] | [Implicit(FormButton to Boolean)][2] | Converts to [Boolean][3]. 


Properties
----------

                   | Name            | Description                                                                 
------------------ | --------------- | --------------------------------------------------------------------------- 
![Public property] | [Successful][4] | true if the form submission was triggered by this button; otherwise, false. 


See Also
--------
[MvcAccount.Shared Namespace][1]  

[1]: ../README.md
[2]: op_Implicit.md
[3]: http://msdn.microsoft.com/en-us/library/a28wyd50
[4]: Successful.md
[Public operator]: ../../_icons/puboperator.gif "Public operator"
[Static member]: ../../_icons/static.gif "Static member"
[Public property]: ../../_icons/pubproperty.gif "Public property"