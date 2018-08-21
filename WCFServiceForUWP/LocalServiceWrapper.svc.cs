using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.ServiceProcess;
using System.Text;

namespace WCFServiceForUWP
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class LocalServiceWrapper : ILocalService
    {
        public ServiceControllerStatus StartService(string name)
        {
            ServiceController controller = new ServiceController(name);

            if (controller.Status == ServiceControllerStatus.Stopped)
                controller.Start();

            return controller.Status;
        }
    }
}
