using System;
using System.Collections.Generic;
using System.Linq;
using BikeRental.Data.Entities;
using BikeRental.Data.Repositories;


namespace BikeRental.Service
{
    public class BikeRentalService : IBikeRentalService
    {
        public string AddUser(string login, string password, string name, string surname, string phone, string address)
        {
            IBikeRentalRepository bikeRentalRepository = new BikeRentalRepository();

            return bikeRentalRepository.AddUser(login, password, name, surname, phone, address);

        }

        public string Login(string login, string password)
        {
            IBikeRentalRepository bikeRentalRepository = new BikeRentalRepository();

            return bikeRentalRepository.Login(login, password);
        }

        public void AddBike(string brand, string model, string type, string color, int price)
        {
            IBikeRentalRepository bikeRentalRepository = new BikeRentalRepository();

            bikeRentalRepository.AddBike(brand, model, type, color, price);
        }

        public string AddRent(int userID, int bikeID)
        {
            IBikeRentalRepository bikeRentalRepository = new BikeRentalRepository();

            return bikeRentalRepository.AddRent(userID, bikeID);
        }

        public int GetUserID(string login)
        {
            IBikeRentalRepository bikeRentalRepository = new BikeRentalRepository();

            return bikeRentalRepository.GetUserID(login);
        }

        public void ReturnBike(int bikeID)
        {
            IBikeRentalRepository bikeRentalRepository = new BikeRentalRepository();

            bikeRentalRepository.ReturnBike(bikeID);
        }

        public void AddRepairOrder(int bikeID, string description)
        {
            IBikeRentalRepository bikeRentalRepository = new BikeRentalRepository();

            bikeRentalRepository.AddRepairOrder(bikeID, description);
        }

        public void AddRepair(int repairOrderID, int userID, int bikeID, string details, string state, int overallPrice)
        {
            IBikeRentalRepository bikeRentalRepository = new BikeRentalRepository();

            bikeRentalRepository.AddRepair(repairOrderID, userID, bikeID, details, state, overallPrice);
        }

        public IEnumerable<Bikes> GetAllBikes()
        {
            IBikeRentalRepository bikeRentalRepository = new BikeRentalRepository();

            return bikeRentalRepository.GetAllBikes();
        }

        public IEnumerable<Rents> GetAllRents()
        {
            IBikeRentalRepository bikeRentalRepository = new BikeRentalRepository();

            return bikeRentalRepository.GetAllRents();
        }

        public IEnumerable<RepairOrders> GetAllRepairOrders()
        {
            IBikeRentalRepository bikeRentalRepository = new BikeRentalRepository();

            return bikeRentalRepository.GetAllRepairOrders();
        }

        public IEnumerable<Repairs> GetAllRepairs()
        {
            IBikeRentalRepository bikeRentalRepository = new BikeRentalRepository();

            return bikeRentalRepository.GetAllRepairs();
        }

        public IEnumerable<Rents> GetRentsByUser(int userID)
        {
            IBikeRentalRepository bikeRentalRepository = new BikeRentalRepository();

            return bikeRentalRepository.GetRentsByUser(userID);
        }

        public IEnumerable<RepairOrders> GetRepairOrdersByBike(int bikeID)
        {
            IBikeRentalRepository bikeRentalRepository = new BikeRentalRepository();

            return bikeRentalRepository.GetRepairOrdersByBike(bikeID);
        }

        public string GetUserTypeByLogin(string login)
        {
            IBikeRentalRepository bikeRentalRepository = new BikeRentalRepository();

            return bikeRentalRepository.GetUserTypeByLogin(login);
        }

        
    }
}
