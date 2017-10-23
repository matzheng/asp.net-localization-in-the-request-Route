using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsService1
{
    internal class Startup
    {
        public void Configuration(IAppBuilder appBuilder)
        {
            appBuilder
              .UseWelcome();
        }
    }
}
