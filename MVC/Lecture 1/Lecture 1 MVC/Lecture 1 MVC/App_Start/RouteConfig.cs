using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Lecture_1_MVC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
             name: "EmptyUrl",
             url: "",
             defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
         );

            routes.MapRoute(
              name: "Value/Id",
              url: "{controller}/{id}",
              defaults: new { controller = "Value", action = "Show", id = UrlParameter.Optional }
          );

            routes.MapRoute(
            name: "Value/Show/Id",
            url: "{controller}/{action}/{id}",
            defaults: new { controller = "Value", action = "Show", id = UrlParameter.Optional }
        );
        }
    }
}
