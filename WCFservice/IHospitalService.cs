using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace WCFservice
{
    [ServiceContract]
    public interface IHospitalService
    {
        [OperationContract]
        User GetUser(string phone, string password);

        [OperationContract]
        void SetUser(User user);

        [OperationContract]
        Slot GetSlot(String phone);

        [OperationContract]
        void SetSlot(Slot slot);
    }
}
