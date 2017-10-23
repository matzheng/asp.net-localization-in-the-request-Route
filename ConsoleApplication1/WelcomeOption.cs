using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    internal class WelcomeOption
    {
        public string HostName { get; set; }
        public string Welcome { get; set; }

        public WelcomeOption(string hostName, string welcome)
        {
            HostName = hostName;
            Welcome = welcome;
        }
    }
}
