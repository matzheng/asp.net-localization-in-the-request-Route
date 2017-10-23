using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.OData.Builder;
using System.Web.OData.Extensions;

namespace ODataAPITest
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            var builder = new ODataConventionModelBuilder();

            builder.EntitySet<Models.Product>("Products");
            builder.EntitySet<Models.Customer>("Customers");
            //config.EnableCaseInsensitive();
            config.MapODataServiceRoute("ODataRoute", "api", builder.GetEdmModel());

            //config.Routes.MapHttpRoute(
            //    name: "DefaultApi",
            //    routeTemplate: "api/{controller}/{id}",
            //    defaults: new { id = RouteParameter.Optional }
            //);
        }
    }
}
