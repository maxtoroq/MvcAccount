using System;
using System.Web.Mvc;
using System.Web.Routing;
using MvcCodeRouting;

namespace SampleWebsite {

   public class MvcApplication : System.Web.HttpApplication {

      void Application_Start() {

         RegisterGlobalFilters(GlobalFilters.Filters);
         RegisterRoutes(RouteTable.Routes);
         RegisterViewEngines(ViewEngines.Engines);

         ConfigureMvcAccount(MvcAccount.AccountConfiguration.Instance);
      }

      void RegisterGlobalFilters(GlobalFilterCollection filters) {
         filters.Add(new HandleErrorAttribute());
      }

      void RegisterRoutes(RouteCollection routes) {
         
         routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

         routes.MapCodeRoutes(
            rootController: typeof(Controllers.HomeController)
         );

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

      void ConfigureMvcAccount(MvcAccount.AccountConfiguration config) {

         config.AccountRepositoryResolver = () => new Models.TestAccountRepository();
         config.PasswordServiceResolver = () => new MvcAccount.ClearTextPasswordService();
         config.ResourceClassKey = "AccountResources";
      }
   }
}