MembershipProvider
==================

To use MvcAccount's MembershipProvider implementation set the following in Web.config:

```xml
<system.web>
   <membership defaultprovider="MvcAccount">
      <providers>
         <add name="MvcAccount" type="MvcAccount.Web.Security.AccountMembershipProvider, MvcAccount" />
      </providers>
   </membership>
</system.web>
```

Since MembershipProvider can be used on requests that are not handled by MvcAccount's controllers, it needs a way to locate the `AccountConfiguration` instance. For that use the [AccountConfiguration.ConfigurationResolver](api/MvcAccount/AccountConfiguration/ConfigurationResolver.md) static property:

```csharp
using MvcAccount;

static readonly AccountConfiguration MvcAccountConfig = ConfigureMvcAccount();

static AccountConfiguration ConfigureMvcAccount() {
   return new AccountConfiguration {
      // set configuration properties
   };
}

void RegisterRoutes(RouteCollection routes) {

   routes.MapCodeRoutes(
      baseRoute: "Account",
      rootController: typeof(MvcAccount.AccountController),
      settings: new CodeRoutingSettings {
         EnableEmbeddedViews = true,
         Configuration = MvcAccountConfig
      }
   );

   AccountConfiguration.ConfigurationResolver = () => MvcAccountConfig;
}
```

MvcAccount's MembershipProvider requires that you use the resolver properties for dependencies, see the [Installation Instructions](Installation-Instructions.md#dependencies) for more info.