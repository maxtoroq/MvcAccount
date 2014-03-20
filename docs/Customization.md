Customization
=============

Configuration
-------------
Use the [AccountConfiguration](api/MvcAccount/AccountConfiguration/README.md#properties) class to customize the behavior of MvcAccount.

```csharp
void Application_Start() {
   ConfigureMvcAccount(AccountConfiguration.Instance);
}

void ConfigureMvcAccount(AccountConfiguration config) {
   // set properties on config
}
```

Style
-----
To use a 2 column tabular display for the forms use this CSS:

```css
.form { display: table; }
.form > div { display: table-row; }
.form > div > div { display: table-cell; padding: .2em .5em; }
```

To use a colon after the label text use this:

```css
.form label[for]:after { content: ":"; }
```

You can customize a specific view using a CSS class named like the view, but hyphen-separated:

```css
.sign-in .form > div > div:first-child { text-align: right; }
```