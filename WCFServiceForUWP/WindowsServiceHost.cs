using System;
using System.Collections.Generic;
using System.Configuration.Install;
using System.Linq;
using System.Reflection;
using System.ServiceModel;
using System.ServiceProcess;
using System.Web;

namespace WCFServiceForUWP
{
    public class WindowsServiceHost : ServiceBase
    {
        public ServiceHost serviceHost = null;
        public WindowsServiceHost()
        {
            // Name the Windows Service
            ServiceName = "WCFHostWindowsService";
        }

        public static void Main(string[] args)
        {

                Run(new WindowsServiceHost());
        }

        // Start the Windows service.
        protected override void OnStart(string[] args)
        {
            if (serviceHost != null)
            {
                serviceHost.Close();
            }

            serviceHost = new ServiceHost(typeof(LocalServiceWrapper));

            // Open the ServiceHostBase to create listeners and start 
            // listening for messages.
            serviceHost.Open();
        }

        protected override void OnStop()
        {
            if (serviceHost != null)
            {
                serviceHost.Close();
                serviceHost = null;
            }
        }
    }
}