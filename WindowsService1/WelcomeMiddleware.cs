using Microsoft.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsService1
{
    internal class WelcomeMiddleware : OwinMiddleware
    {
        private readonly WelcomeOption _option;

        public WelcomeMiddleware(OwinMiddleware next, WelcomeOption option) : base(next)
        {
            _option = option;
        }

        public override async Task Invoke(IOwinContext context)
        {
            System.Console.WriteLine("Http request received at " + DateTime.UtcNow.ToString());
            await Next.Invoke(context);
            string welcome = string.Format("I am {0}. {1}{2}", _option.HostName, _option.Welcome, Environment.NewLine);
            await context.Response.WriteAsync(welcome).ConfigureAwait(false);
        }
    }
}
