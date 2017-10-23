using Microsoft.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Middlewares
{
    internal class WelcomeMiddleware : OwinMiddleware
    {
        private WelcomeOption _option;
        public WelcomeMiddleware(OwinMiddleware next, WelcomeOption option) : base(next)
        {
            _option = option;
        }
        public override Task Invoke(IOwinContext context)
        {
            System.Console.WriteLine("Http request received at " + DateTime.UtcNow.ToString());
            return Next.Invoke(context);
            //string welcome = string.Format("I am {0}, {1}{2}", _option.HostName, _option.Welcome, Environment.NewLine);
            //await context.Response.WriteAsync(welcome).ConfigureAwait(false);
        }
    }
}
