Installation Instructions
=========================

Controllers
-----------
Just reference the MvcAccount assembly from your project and the ASP.NET MVC runtime will be able to locate its controllers. If you are using a dependency injection container that requires explicit registration of concrete types make sure you register MvcAccount's controllers.

Routes
------
MvcAccount does not require special or custom routes, it can use the default `{controller}/{action}/{id}` route. If you do not use a default route you can use this one:

```csharp
routes.MapRoutes(null, "Account/{action}/{id}",
   new { controller = "Account", action = "Index", id = UrlParameter.Optional },
   new[] { "MvcAccount" });
```

Some verification URLs that MvcAccount creates can be longer than the default [maxUrlLength](http://msdn.microsoft.com/library/e1f13641) setting. To fix that you can either add the following to Web.config, or simply remove the `{id}` token from the route:

```xml
<location path="Account">
   <system.web>
      <httpRuntime maxUrlLength="1300"/>
   </system.web>
</location>
```

The last thing you need to do in Web.config is change the [loginUrl](http://msdn.microsoft.com/library/1d3t3c61):

```xml
<system.web>
   <authentication mode="Forms">
      <forms loginUrl="~/Account/SignIn" />
   </authentication>
</system.web>
```

Views
-----
MvcAccount includes all Razor views embedded as assembly resources, see the _Plugin mode_ topic for more information.

A layout is not included, you have provide it. Most views require a `head` section to render the page `title`.

```xml
<!DOCTYPE html>
<html>
<head>
    @RenderSection("head", required: false)
</head>
<body>
    @RenderBody()
</body>
</html>
```

Plugin mode (Routes and Views)
------------------------------
You can use [MvcCodeRouting](http://mvccoderouting.codeplex.com/) which can create the routes for you, and use the embedded views:

```csharp
void RegisterRoutes(RouteCollection routes) {
         
   routes.MapCodeRoutes(
      baseRoute: "Account",
      rootController: typeof(MvcAccount.AccountController),
      settings: new CodeRoutingSettings { 
         EnableEmbeddedViews = true,
         UseImplicitIdToken = true
      }
   );
}

void RegisterViewEngines(ViewEngineCollection engines) {
   engines.EnableCodeRouting();
}
```

Embedded views can be individually overridden by files views in your project. 

If you want you can copy all views to your project using the [Extract-Views](http://mvccoderouting.codeplex.com/wikipage?title=Extract-Views) command. Once you do that the use of MvcCodeRouting is completely optional.

Dependencies
------------
Before you can start using MvcAccount you must provide its dependencies. There are three ways to do this, you can use constructor injection for MvcAccount's controllers, you can set various resolver settings on [AccountConfiguration](http://maxtoroq.users.sourceforge.net/mvcaccount/library/0.8/?topic=html/Properties_T_MvcAccount_AccountConfiguration.htm) for each dependency, or you can just set [AccountConfiguration.DependencyResolver](http://maxtoroq.users.sourceforge.net/mvcaccount/library/0.8/?topic=html/P_MvcAccount_AccountConfiguration_DependencyResolver.htm).

### Option 1: Constructor injection for MvcAccount's controllers
If you are not familiar with dependency injection see Option 2.

### Option 2: Set the various resolver settings for each dependency
This option is the easiest one to setup.

```csharp
void Application_Start() {
   ConfigureMvcAccount(AccountConfiguration.Instance);
}

void ConfigureMvcAccount(AccountConfiguration config) {
   config.AccountRepositoryResolver = () => new MyAccountRepository();
   config.PasswordServiceResolver => () => new SqlMembershipProviderPasswordService(MembershipPasswordFormat.Hashed);
}
```

### Option 3: Set AccountConfiguration.DependencyResolver
Use this one if you are already using a dependency injection container.

```csharp
void Application_Start() {
   ConfigureMvcAccount(AccountConfiguration.Instance);
}

void ConfigureMvcAccount(AccountConfiguration config) {
   config.DependencyResolver = (type) => MyContainer.Resolve(type);
}
```

### MvcAccount.AccountRepository
Responsible for querying account information and persisting changes. The Find methods must return an instance of a public class with the following public properties:

| Name	                             | Type
| ---------------------------------- | -------------------
| Disabled	                     | Boolean
| Email	                             | String
| EmailChangeTicketExpiration	     | Nullable&lt;DateTime>
| EmailVerificationTicketExpiration  | Nullable&lt;DateTime>
| EmailVerified	                     | Boolean
| FailedSignInAttempts	             | Int32
| FailedSignInAttemptWindowStart     | Nullable&lt;DateTime>
| Id                                 | Any type is allowed
| LastSignIn                         | Nullable&lt;DateTime>
| Password                           | String
| PasswordResetTicketExpiration      | Nullable&lt;DateTime>
| Username                           | String

### MvcAccount.PasswordService
Responsible for encrypting and comparing passwords. MvcAccount includes several implementations you can choose from:

* [ClearTextPasswordService](http://maxtoroq.users.sourceforge.net/mvcaccount/library/0.8/?topic=html/T_MvcAccount_ClearTextPasswordService.htm): Use if passwords are stored in clear text.
* [SqlMembershipProviderPasswordService](http://maxtoroq.users.sourceforge.net/mvcaccount/library/0.8/?topic=html/T_MvcAccount_SqlMembershipProviderPasswordService.htm): Provides SHA1 and MachineKey-based encryption, as implemented by [SqlMembershipProvider](http://msdn.microsoft.com/library/system.web.security.sqlmembershipprovider).

MembershipProvider
------------------
To use MvcAccount's MembershipProvider implementation set the following in Web.config:

```xml
<system.web>
   <membership defaultProvider="MvcAccount">
      <providers>
         <add name="MvcAccount" type="MvcAccount.AccountMembershipProvider, MvcAccount" />
      </providers>
   </membership>
</system.web>
```

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
MvcAccount is fully localized in several languages. The easiest way to view the pages using the preferred language setting of the user's browser is to set `uiCulture="auto"` on Web.config:

```xml
<system.web>
   <globalization uiCulture="auto" />
</system.web>
```

English (en) is the fallback language.

Custom error pages and status codes
-----------------------------------
MvcAccount uses various 4xx status codes when an operation cannot be completed, while at the same time returning a view with a description of the error and possibly a form to retry the request. To prevent custom error pages from replacing the original response you need to set `existingResponse="PassThrough"` on Web.config:

```xml
<system.webServer>
   <httpErrors existingResponse="PassThrough" />
</system.webServer>
```

### Next: [Customization →](Customization.md)