using System.Collections.Generic;
using System.ServiceModel;

namespace BikeRental.Service
{
    [ServiceContract]
    public interface IBikeRentalService
    {
        [OperationContract]
        string AddUser(string login, string password, string name, string surname, string phone, string address);

        [OperationContract]
        string Login(string login, string password);

        [OperationContract]
        void AddBike(string brand, string model, string type, string color, int price);

        [OperationContract]
        void AddRent(int userID, int bikeID);

        [OperationContract]
        int GetUserID(string login);

        [OperationContract]
        void ReturnBike(int bikeID);

        [OperationContract]
        void AddRepairOrder(int bikeID, string description);

        [OperationContract]
        void AddRepair(int repairOrderID, int userID, int bikeID, string details, string state, int overallPrice);
    }
}
 