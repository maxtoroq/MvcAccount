Installation Instructions
=========================

Getting MvcAccount
------------------
The first step is to install the [MvcAccount](http://www.nuget.org/packages/MvcAccount) package using NuGet:

```powershell
Install-Package MvcAccount
```

Registration
------------
By installing the MvcAccount package it will also install [MvcCodeRouting](http://mvccoderouting.codeplex.com/), which you can use to register MvcAccount like this:

```csharp
using System;
using System.Web.Routing;
using System.Web.Mvc;
using MvcCodeRouting;

void Application_Start() {
   RegisterRoutes(RouteTable.Routes);
   RegisterViewEngines(ViewEngines.Engines);
}

void RegisterRoutes(RouteCollection routes) {

   routes.MapCodeRoutes(
      baseRoute: "Account",
      rootController: typeof(MvcAccount.AccountController),
      settings: new CodeRoutingSettings {
         EnableEmbeddedViews = true,
         Configuration = new MvcAccount.AccountConfiguration {
            // set configuration properties
         }
      }
   );
}

void RegisterViewEngines(ViewEngineCollection engines) {
   engines.EnableCodeRouting();
}
```

The `baseRoute` parameter can be anything you want, adjust the `loginUrl` accordingly:

```xml
<system.web>
   <authentication mode="Forms">
      <forms loginUrl="~/Account/SignIn" />
   </authentication>
</system.web>
```

Dependencies
------------
Before you can start using MvcAccount you must provide its dependencies. There are three ways to do this, you can use constructor injection for MvcAccount's controllers, you can set various resolver settings on [AccountConfiguration](api/MvcAccount/AccountConfiguration/README.md#properties) for each dependency, or you can just set [AccountConfiguration.DependencyResolver](api/MvcAccount/AccountConfiguration/DependencyResolver.md).

### Option 1: Constructor injection for MvcAccount's controllers
If you are not familiar with dependency injection see Option 2.

### Option 2: Set the various resolver settings for each dependency
This option is the easiest one to setup.

```csharp
routes.MapCodeRoutes(
   // ... code omitted for clarity
   settings: new CodeRoutingSettings {
      Configuration = new MvcAccount.AccountConfiguration {
         AccountRepositoryResolver = () => new MyAccountRepository(),
         PasswordServiceResolver => () => new MvcAccount.Web.Helpers.CryptoPasswordService()
      }
   }
);
```

### Option 3: Set AccountConfiguration.DependencyResolver
Use this one if you are already using a dependency injection container.

```csharp
routes.MapCodeRoutes(
   // ... code omitted for clarity
   settings: new CodeRoutingSettings {
      Configuration = new MvcAccount.AccountConfiguration {
         DependencyResolver = (type) => MyContainer.Resolve(type)
      }
   }
);
```

### MvcAccount.AccountRepository
Responsible for querying account information and persisting changes. The Find methods must return an instance of a public class with the following public properties:

| Name                               | Type
| ---------------------------------- | -------------------
| Disabled                           | Boolean
| Email                              | String
| EmailChangeTicketExpiration        | Nullable&lt;DateTime>
| EmailVerificationTicketExpiration  | Nullable&lt;DateTime>
| EmailVerified                      | Boolean
| FailedSignInAttempts               | Int32
| FailedSignInAttemptWindowStart     | Nullable&lt;DateTime>
| Id                                 | Any type is allowed
| LastSignIn                         | Nullable&lt;DateTime>
| Password                           | String
| PasswordResetTicketExpiration      | Nullable&lt;DateTime>
| Username                           | String

### MvcAccount.PasswordService
Responsible for encrypting and comparing passwords. MvcAccount includes three implementations you can choose from:

- [ClearTextPasswordService](api/MvcAccount/ClearTextPasswordService/README.md): Use if passwords are stored in clear text.
- [CryptoPasswordService](api/MvcAccount.Web.Helpers/CryptoPasswordService/README.md): PBKDF2 hashing ([Recommended](http://brockallen.com/2012/10/19/password-management-made-easy-in-asp-net-with-the-crypto-api/))
- [SqlMembershipProviderPasswordService](api/MvcAccount.Web.Security/SqlMembershipProviderPasswordService/README.md): Provides SHA1 and MachineKey-based encryption, as implemented by [SqlMembershipProvider](http://msdn.microsoft.com/library/system.web.security.sqlmembershipprovider).

Layout
------
MvcAccount does not include a layout, you have to provide it. The view title is passed via `Page.Title`.

SMTP
----
You need to [configure an SMTP server](http://msdn.microsoft.com/library/w355a94k) so MvcAccount can send notification and verification emails:

```xml
<system.net>
   <mailSettings>
      <smtp from="noreply@example.com">
         <network 
            host="mail.example.com" 
            userName="noreply@example.com" 
            password="ThisIsNotARealPassword"/>
      </smtp>
   </mailSettings>
</system.net>
```

Languages
---------
MvcAccount is fully localized in several languages. Localized resources are available as separate satellite packages:

- [Spanish (es)](http://www.nuget.org/packages/MvcAccount.es)
- [Finnish (fi)](http://www.nuget.org/packages/MvcAccount.fi)
- [Portuguese (pt)](http://www.nuget.org/packages/MvcAccount.pt)

The easiest way to view the pages using the preferred language setting of the user's browser is to set `uiCulture="auto"` in Web.config:

```xml
<system.web>
   <globalization uiCulture="auto" />
</system.web>
```

English (en) is the fallback language.

### Next: [Customization →](Customization.md)
