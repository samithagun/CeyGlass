using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace CeyGlass.Services
{
    public interface ISupplierService
    {
        [OperationContract]
        void DoWork();
    }
}
