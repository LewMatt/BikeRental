using BikeRental.Data.Entities;
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
        string AddRent(int userID, int bikeID);

        [OperationContract]
        int GetUserID(string login);

        [OperationContract]
        void ReturnBike(int bikeID);

        [OperationContract]
        void AddRepairOrder(int bikeID, string description);

        [OperationContract]
        void AddRepair(int repairOrderID, int userID, int bikeID, string details, string state, int overallPrice);

        [OperationContract]
        IEnumerable<Bikes> GetAllBikes();

        [OperationContract]
        IEnumerable<Rents> GetAllRents();

        [OperationContract]
        IEnumerable<RepairOrders> GetAllRepairOrders();

        [OperationContract]
        IEnumerable<Repairs> GetAllRepairs();

        [OperationContract]
        IEnumerable<Rents> GetRentsByUser(int userID);

        [OperationContract]
        IEnumerable<RepairOrders> GetRepairOrdersByBike(int bikeID);
    }
}
 