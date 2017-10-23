using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace localization_Test
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "InternationalDefault",
                url: "{culture}/{controller}/{action}/{id}",
                defaults: new { culture = Helpers.CultureHelper.GetDefaultCulture(), controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

           //routes.MapRoute(
           //    name: "Default",
           //    url: "{controller}/{action}/{id}",
           //    defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
           //);
        }
    }
}
