using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using BikeRental.Data.Entities;

namespace BikeRental.Data.Repositories
{
    public interface IBikeRentalRepository
    {
        int GetNumberOfUsers();
        string AddUser(string login, string password, string name, string surname, string phone, string address);
        string Login(string login, string password);
        int GetNumberOfBikes();
        void AddBike(string brand, string model, string type, string color, int price);
        int GetNumberOfRents();
        void AddRent(int userID, int bikeID);
        int GetUserID(string login);
        void ReturnBike(int bikeID);
        void AddRepairOrder(int bikeID, string description);
        void AddRepair(int repairOrderID, int userID, int bikeID, string details, string state, int overallPrice);

    }
}
