using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using MvcCodeRouting;

namespace Samples {

   public class MvcApplication : System.Web.HttpApplication {

      void Application_Start() {

         RegisterGlobalFilters(GlobalFilters.Filters);
         RegisterRoutes(RouteTable.Routes);

         ViewEngines.Engines.EnableCodeRouting();
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
               Configuration = new MvcAccount.AccountConfiguration {
                  AccountRepositoryResolver = () => new Models.TestAccountRepository(),
                  PasswordServiceResolver = () => new MvcAccount.ClearTextPasswordService()
               }
            }
         );
      }
   }
}
