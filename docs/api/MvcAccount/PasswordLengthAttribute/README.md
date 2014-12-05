PasswordLengthAttribute Class
=============================
Validates the length of new passwords. Settings are taken from [MinPasswordLength][1] and [MaxPasswordLength][2].


Inheritance Hierarchy
---------------------
[System.Object][3]  
  [System.Attribute][4]  
    [System.ComponentModel.DataAnnotations.ValidationAttribute][5]  
      [System.ComponentModel.DataAnnotations.StringLengthAttribute][6]  
        **MvcAccount.PasswordLengthAttribute**  

**Namespace:** [MvcAccount][7]  
**Assembly:** MvcAccount (in MvcAccount.dll)

Syntax
------

```csharp
public class PasswordLengthAttribute : StringLengthAttribute, 
	IClientValidatable
```

The **PasswordLengthAttribute** type exposes the following members.


Constructors
------------

                 | Name                         | Description                                                          
---------------- | ---------------------------- | -------------------------------------------------------------------- 
![Public method] | [PasswordLengthAttribute][8] | Initializes a new instance of the **PasswordLengthAttribute** class. 


Methods
-------

                 | Name                          | Description                      
---------------- | ----------------------------- | -------------------------------- 
![Public method] | [GetClientValidationRules][9] | Returns client validation rules. 


See Also
--------

#### Reference
[MvcAccount Namespace][7]  
[AccountConfiguration.MinPasswordLength][1]  
[AccountConfiguration.MaxPasswordLength][2]  

[1]: ../AccountConfiguration/MinPasswordLength.md
[2]: ../AccountConfiguration/MaxPasswordLength.md
[3]: http://msdn.microsoft.com/en-us/library/e5kfa45b
[4]: http://msdn.microsoft.com/en-us/library/e8kc3626
[5]: http://msdn.microsoft.com/en-us/library/cc679227
[6]: http://msdn.microsoft.com/en-us/library/cc679251
[7]: ../README.md
[8]: _ctor.md
[9]: GetClientValidationRules.md
[Public method]: ../../_icons/pubmethod.gif "Public method"