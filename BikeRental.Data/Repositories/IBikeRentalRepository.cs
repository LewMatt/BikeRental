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
        void AddBike(string brand, string model, string type, string color);
        int GetNumberOfRents();
        void AddRent(int userID, int bikeID, int price, string expirationDate);

    }
}
