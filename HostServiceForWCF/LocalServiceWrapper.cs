using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace HostServiceForWCF
{
    public class LocalServiceWrapper : ILocalService
    {
        public ServiceControllerStatus StartService(string name)
        {
            ServiceController controller = new ServiceController(name);

            if (controller.Status == ServiceControllerStatus.Stopped)
            { 
                controller.Start();
                controller.WaitForStatus(ServiceControllerStatus.Running, TimeSpan.FromSeconds(5));
            }
            return controller.Status;
        }
    }
}
