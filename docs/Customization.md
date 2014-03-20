Customization
=============

Settings
--------
Use the [AccountConfiguration](api/MvcAccount/AccountConfiguration/README.md#properties) class to customize the behavior of MvcAccount. See the [Installation Instructions](Installation-Instructions.md#registration) for more info.

CSS
---
You can use the following CSS for a responsive horizontal form layout:

```css
.MvcAccount form > div { display: table-row; }
.MvcAccount form > div > div { display: table-cell; padding: 0 10px 15px 10px; }
.MvcAccount form > div > div:first-child { text-align: right; }
.MvcAccount form label[for]:after { content: ":"; }
.MvcAccount form .form-control { display: inline-block; width: auto; }
.MvcAccount form .btn-primary { margin-right: 5px; }

@media (max-width: 767px) {
   .MvcAccount form .form-group { margin-bottom: 15px; }
   .MvcAccount form > div { display: block; }
   .MvcAccount form > div > div { display: block; padding: 0; }
   .MvcAccount form > div > div:first-child { text-align: left; }
   .MvcAccount form > div.buttons > div:first-child { display: none; }
}
```

In LESS syntax:
```css
.MvcAccount {
   form {
      > div {
         display: table-row;

         > div {
            display: table-cell;
            padding: 0 10px 15px 10px;
         }

         > div:first-child {
            text-align: right;
         }
      }

      label[for]:after {
         content: ":";
      }

      .form-control {
         display: inline-block;
         width: auto;
      }

      .btn-primary {
         margin-right: 5px;
      }
   }
}

@media (max-width: 767px) {

   .MvcAccount {
      form {
         .form-group {
            margin-bottom: 15px;
         }

         > div {
            display: block;

            > div {
               display: block;
               padding: 0;
            }

            > div:first-child {
               text-align: left;
            }
         }

         > div.buttons {
            > div:first-child {
               display: none;
            }
         }
      }
   }
}
```

You can customize a specific view using a CSS class named like the view model, but hyphen-separated:

```css
.MvcAccount-Authentication-SignInViewModel h1 { }
```

Views
-----
MvcAccount includes all Razor views embedded as assembly resources. Embedded views can be individually overridden by files views in your project.

To extract all views use the [Extract-Views](https://mvccoderouting.codeplex.com/wikipage?title=Extract-Views) command, using the same value of `baseRoute` (used at [registration](Installation-Instructions.md#registration)) for the `-ViewsDirectory` parameter.

Resources
---------
You can override individual resources, like error messages, display names, text in HTML elements like `<h1>` and `<title>`, for any particular culture, by using [global resource files](http://msdn.microsoft.com/library/ms227427). Here's how it works:

1. Create a resource file in `~/App_GlobalResources`.
2. Set [AccountConfiguration.ResourceClassKey](api/MvcAccount/AccountConfiguration/ResourceClassKey.md) to the name of the resource file, minus the culture and extension.

For a list of resource names see [this](api/MvcAccount/AccountResources/README.md#properties).
