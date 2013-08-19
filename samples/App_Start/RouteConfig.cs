using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using MvcCodeRouting;

namespace Samples {
   
   public class RouteConfig {
      
      public static void RegisterRoutes(RouteCollection routes) {

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