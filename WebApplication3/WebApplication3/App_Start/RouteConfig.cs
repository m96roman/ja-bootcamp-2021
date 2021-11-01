using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebApplication3
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
               name: "IncorrectValue",
               url: "Value",
               defaults: new { controller = "Value", action = "IncorrectValue" }
           );

            routes.MapRoute(
              name: "CorrectValue",
              url: "Value/{id}",
              defaults: new { controller = "Value", action = "Show", id = UrlParameter.Optional }
          );
            routes.MapRoute(
            name: "ValueAllRoute",
            url: "Value/Show/{id}",
            defaults: new { controller = "Value", action = "Show", id = UrlParameter.Optional }
        );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );


        }
    }
}
