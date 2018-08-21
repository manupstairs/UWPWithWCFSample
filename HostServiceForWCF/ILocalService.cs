using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceProcess;
using System.Text;

namespace HostServiceForWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface ILocalService
    {

        [OperationContract]
        ServiceControllerStatus StartService(string name);

    }
}
