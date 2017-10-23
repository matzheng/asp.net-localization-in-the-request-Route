using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using System.Web.Http;
using ConsoleApplication1.Middlewares;

[assembly: OwinStartup(typeof(ConsoleApplication1.Startup))]

namespace ConsoleApplication1
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=316888
            var webApiConfiguration = ConfigureWebApi();
            app.Use(typeof(WelcomeMiddleware), new WelcomeOption("Peter", "Welcome to this site."));
            app.UseWebApi(webApiConfiguration);
        }

        private HttpConfiguration ConfigureWebApi()
        {
            var config = new HttpConfiguration();
            config.Routes.MapHttpRoute(
                    "DefaultApi",
                    "api/{controller}/{id}",
                    new { id = RouteParameter.Optional}
                );
            return config;
        }
    }
}
