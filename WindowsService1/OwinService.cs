using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace WindowsService1
{
    partial class OwinService : ServiceBase
    {
        private IDisposable _server;

        public OwinService()
        {
            //InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            string hostUrl = "http://localhost:9000/windowsservice";
            _server = WebApp.Start<Startup>(hostUrl);
        }

        protected override void OnStop()
        {
            _server.Dispose();
        }
    }
}
