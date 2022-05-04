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

        public void AddBike(string brand, string model, string type, string color)
        {
            IBikeRentalRepository bikeRentalRepository = new BikeRentalRepository();

            bikeRentalRepository.AddBike(brand, model, type, color);
        }

        public void AddRent(int userID, int bikeID, int price)
        {
            IBikeRentalRepository bikeRentalRepository = new BikeRentalRepository();

            bikeRentalRepository.AddRent(userID, bikeID, price);
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
    }
}
