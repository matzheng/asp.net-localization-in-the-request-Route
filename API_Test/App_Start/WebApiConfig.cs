using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.OData.Builder;
using System.Web.OData.Extensions;

namespace API_Test
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API routes
            config.MapHttpAttributeRoutes();
            config.AddODataQueryFilter();
            // Web API configuration and services
            var builder = new ODataConventionModelBuilder();
            builder.EntitySet<Product>("Products");
            config.MapODataServiceRoute("ODataRoute", null, builder.GetEdmModel());
            

            //config.Routes.MapHttpRoute(
            //    name: "DefaultApi",
            //    routeTemplate: "api/{controller}/{id}",
            //    defaults: new { id = RouteParameter.Optional }
            //);
        }
    }
}
