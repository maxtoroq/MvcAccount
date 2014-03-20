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
public class PasswordLengthAttribute : StringLengthAttribute, 
	IClientValidatable
```

The **PasswordLengthAttribute** type exposes the following members.


Constructors
------------

Name                         | Description                                                          
---------------------------- | -------------------------------------------------------------------- 
[PasswordLengthAttribute][8] | Initializes a new instance of the **PasswordLengthAttribute** class. 


Methods
-------

Name                                      | Description                                                                                                                                                   
----------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------- 
[Equals][9]                               | Returns a value that indicates whether this instance is equal to a specified object. (Inherited from [Attribute][4].)                                         
[Finalize][10]                            | Allows an object to try to free resources and perform other cleanup operations before it is reclaimed by garbage collection. (Inherited from [Object][3].)    
[FormatErrorMessage][11]                  | Applies formatting to a specified error message. (Inherited from [StringLengthAttribute][6].)                                                                 
[GetClientValidationRules][12]            | Returns client validation rules.                                                                                                                              
[GetHashCode][13]                         | Returns the hash code for this instance. (Inherited from [Attribute][4].)                                                                                     
[GetType][14]                             | Gets the [Type][15] of the current instance. (Inherited from [Object][3].)                                                                                    
[GetValidationResult][16]                 | Checks whether the specified value is valid with respect to the current validation attribute. (Inherited from [ValidationAttribute][5].)                      
[IsDefaultAttribute][17]                  | When overridden in a derived class, indicates whether the value of this instance is the default value for the derived class. (Inherited from [Attribute][4].) 
[IsValid(Object)][18]                     | Determines whether a specified object is valid. (Inherited from [StringLengthAttribute][6].)                                                                  
[IsValid(Object, ValidationContext)][19]  | Validates the specified value with respect to the current validation attribute. (Inherited from [ValidationAttribute][5].)                                    
[Match][20]                               | When overridden in a derived class, returns a value that indicates whether this instance equals a specified object. (Inherited from [Attribute][4].)          
[MemberwiseClone][21]                     | Creates a shallow copy of the current [Object][3]. (Inherited from [Object][3].)                                                                              
[ToString][22]                            | Returns a string that represents the current object. (Inherited from [Object][3].)                                                                            
[Validate(Object, String)][23]            | Validates the specified object. (Inherited from [ValidationAttribute][5].)                                                                                    
[Validate(Object, ValidationContext)][24] | Validates the specified object. (Inherited from [ValidationAttribute][5].)                                                                                    


Properties
----------

Name                           | Description                                                                                                                                                                               
------------------------------ | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
[ErrorMessage][25]             | Gets or sets an error message to associate with a validation control if validation fails. (Inherited from [ValidationAttribute][5].)                                                      
[ErrorMessageResourceName][26] | Gets or sets the error message resource name to use in order to look up the [ErrorMessageResourceType][27] property value if validation fails. (Inherited from [ValidationAttribute][5].) 
[ErrorMessageResourceType][27] | Gets or sets the resource type to use for error-message lookup if validation fails. (Inherited from [ValidationAttribute][5].)                                                            
[ErrorMessageString][28]       | Gets the localized validation error message. (Inherited from [ValidationAttribute][5].)                                                                                                   
[MaximumLength][29]            | Gets or sets the maximum length of a string. (Inherited from [StringLengthAttribute][6].)                                                                                                 
[MinimumLength][30]            | Gets or sets the minimum length of a string. (Inherited from [StringLengthAttribute][6].)                                                                                                 
[TypeId][31]                   | When implemented in a derived class, gets a unique identifier for this [Attribute][4]. (Inherited from [Attribute][4].)                                                                   


See Also
--------
[MvcAccount Namespace][7]  
[AccountConfiguration.MinPasswordLength][1]  
[AccountConfiguration.MaxPasswordLength][2]  

[1]: ../AccountConfiguration/MinPasswordLength.md
[2]: ../AccountConfiguration/MaxPasswordLength.md
[3]: http://msdn2.microsoft.com/en-us/library/e5kfa45b
[4]: http://msdn2.microsoft.com/en-us/library/e8kc3626
[5]: http://msdn2.microsoft.com/en-us/library/cc679227
[6]: http://msdn2.microsoft.com/en-us/library/cc679251
[7]: ../README.md
[8]: _ctor.md
[9]: http://msdn2.microsoft.com/en-us/library/09ds241w
[10]: http://msdn2.microsoft.com/en-us/library/4k87zsw7
[11]: http://msdn2.microsoft.com/en-us/library/cc679186
[12]: GetClientValidationRules.md
[13]: http://msdn2.microsoft.com/en-us/library/365e1bxs
[14]: http://msdn2.microsoft.com/en-us/library/dfwy45w9
[15]: http://msdn2.microsoft.com/en-us/library/42892f65
[16]: http://msdn2.microsoft.com/en-us/library/dd733031
[17]: http://msdn2.microsoft.com/en-us/library/tbkb5x6t
[18]: http://msdn2.microsoft.com/en-us/library/cc679200
[19]: http://msdn2.microsoft.com/en-us/library/dd730022
[20]: http://msdn2.microsoft.com/en-us/library/wy7chz44
[21]: http://msdn2.microsoft.com/en-us/library/57ctke0a
[22]: http://msdn2.microsoft.com/en-us/library/7bxwbwt2
[23]: http://msdn2.microsoft.com/en-us/library/cc679256
[24]: http://msdn2.microsoft.com/en-us/library/dd411784
[25]: http://msdn2.microsoft.com/en-us/library/cc679194
[26]: http://msdn2.microsoft.com/en-us/library/cc679245
[27]: http://msdn2.microsoft.com/en-us/library/cc679257
[28]: http://msdn2.microsoft.com/en-us/library/cc679223
[29]: http://msdn2.microsoft.com/en-us/library/cc679230
[30]: http://msdn2.microsoft.com/en-us/library/dd382113
[31]: http://msdn2.microsoft.com/en-us/library/sa1bf03e