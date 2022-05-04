using System.Collections.Generic;
using System.ServiceModel;

namespace BikeRental.Service
{
    [ServiceContract]
    public interface IBikeRentalService
    {
        [OperationContract]
        void AddUser(string login, string password, string name, string surname, string phone, string address);
    }
}
 