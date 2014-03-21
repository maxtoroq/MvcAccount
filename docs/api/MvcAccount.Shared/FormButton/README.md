FormButton Structure
====================
Represents a boolean value that indicates if a form submission was triggered by a particular button.

**Namespace:** [MvcAccount.Shared][1]  
**Assembly:** MvcAccount (in MvcAccount.dll)

Syntax
------

```csharp
public struct FormButton
```

The **FormButton** type exposes the following members.


Methods
-------

Name             | Description                                                                                        
---------------- | -------------------------------------------------------------------------------------------------- 
[Equals][2]      | Indicates whether this instance and a specified object are equal. (Inherited from [ValueType][3].) 
[GetHashCode][4] | Returns the hash code for this instance. (Inherited from [ValueType][3].)                          
[GetType][5]     | Gets the [Type][6] of the current instance. (Inherited from [Object][7].)                          
[ToString][8]    | Returns the fully qualified type name of this instance. (Inherited from [ValueType][3].)           


Operators
---------

Name                                 | Description                
------------------------------------ | -------------------------- 
[Implicit(FormButton to Boolean)][9] | Converts to [Boolean][10]. 


Properties
----------

Name             | Description                                                                 
---------------- | --------------------------------------------------------------------------- 
[Successful][11] | true if the form submission was triggered by this button; otherwise, false. 


See Also
--------
[MvcAccount.Shared Namespace][1]  

[1]: ../README.md
[2]: http://msdn.microsoft.com/en-us/library/2dts52z7
[3]: http://msdn.microsoft.com/en-us/library/aey3s293
[4]: http://msdn.microsoft.com/en-us/library/y3509fc2
[5]: http://msdn.microsoft.com/en-us/library/dfwy45w9
[6]: http://msdn.microsoft.com/en-us/library/42892f65
[7]: http://msdn.microsoft.com/en-us/library/e5kfa45b
[8]: http://msdn.microsoft.com/en-us/library/wb77sz3h
[9]: op_Implicit.md
[10]: http://msdn.microsoft.com/en-us/library/a28wyd50
[11]: Successful.md