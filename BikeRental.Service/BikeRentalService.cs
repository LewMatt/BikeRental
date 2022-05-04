using System;
using System.Collections.Generic;
using System.Linq;
using BikeRental.Data.Entities;
using BikeRental.Data.Repositories;


namespace BikeRental.Service
{
    public class BikeRentalService : IBikeRentalService
    {
        public void AddUser(string login, string password, string name, string surname, string phone, string address)
        {
            IBikeRentalRepository bikeRentalRepository = new BikeRentalRepository();

            bikeRentalRepository.AddUser(login, password, name, surname, phone, address);

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
    }
}
