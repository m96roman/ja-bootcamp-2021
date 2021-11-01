using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Lecture_1
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

   /*         routes.MapRoute(
             name: "Value",
             url: "{controller}/{action}/{id}",
             defaults: new { controller = "Value", action = "Show", id = UrlParameter.Optional }
         );*/

            routes.MapRoute(
               name: "Value1",
               url: "{controller}/{id}",
               defaults: new { controller = "Value", action = "Show1", id = UrlParameter.Optional }
           );


            routes.MapRoute(
            name: "Default",
            url: "{controller}/{action}/{id}",
            defaults: new { controller = "Value", action = "Show1", id = UrlParameter.Optional }
         );

        }
    }
}
