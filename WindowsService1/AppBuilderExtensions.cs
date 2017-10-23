using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsService1
{
    internal static class AppBuilderExtensions
    {
        public static IAppBuilder UseWelcome(this IAppBuilder appBuilder)
        {
            return appBuilder.UseWelcome(new WelcomeOption("Peter", "Welcome to this site"));
        }

        public static IAppBuilder UseWelcome(this IAppBuilder appBuilder, WelcomeOption option)
        {
            return appBuilder
              .Use(typeof(WelcomeMiddleware), option);
        }
    }
}
