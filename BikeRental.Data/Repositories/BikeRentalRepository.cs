using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using BikeRental.Data.Entities;

namespace BikeRental.Data.Repositories
{
    public class BikeRentalRepository : IBikeRentalRepository
    {
        private readonly BikeRentalContext _bikeRentalContext;

        public BikeRentalRepository()
        {
            _bikeRentalContext = null;
        }

        public BikeRentalRepository(BikeRentalContext bikeRentalContext)
        {
            _bikeRentalContext = bikeRentalContext;
        }

        public int GetNumberOfUsers()
        {
            int numberOfUsers = 0;

            using (var context = _bikeRentalContext ?? new BikeRentalContext())
            {
                numberOfUsers = context.Users.Count();
            }

            return numberOfUsers;
        }

        public void AddUser(string login, string password, string name, string surname, string phone, string address)
        {
            int numberOfUsers = GetNumberOfUsers();
            int newUserID = numberOfUsers + 1;

            using (var context = _bikeRentalContext ?? new BikeRentalContext())
            {
                var user = new Users
                {
                    UserID = newUserID,
                    Login = login,
                    Password = password,
                    Name = name,
                    Surname = surname,
                    Phone = phone,
                    Address = address,
                    UserType = "user"
                };

                context.Users.Add(user);

                context.SaveChanges();
            }
        }

        public string Login(string login, string password)
        {
            string userLogged = "";
            using (var context = _bikeRentalContext ?? new BikeRentalContext())
            {
                var user = context.Users.Where(u => u.Login == login && u.Password == password).FirstOrDefault();
                if(user == null)
                {
                    userLogged = "";
                }
                else
                {
                    userLogged = user.Login;
                }
            }

            return userLogged;
        }

        public int GetNumberOfBikes()
        {
            int numberOfBikes = 0;

            using (var context = _bikeRentalContext ?? new BikeRentalContext())
            {
                numberOfBikes = context.Bikes.Count();
            }

            return numberOfBikes;
        }

        public void AddBike(string brand, string model, string type, string color)
        {
            int numberOfBikes = GetNumberOfBikes();
            int newBikeID = numberOfBikes + 1;

            using (var context = _bikeRentalContext ?? new BikeRentalContext())
            {
                var bike = new Bikes
                {
                    BikeID = newBikeID,
                    Brand = brand,
                    Model = model,
                    Type = type,
                    Color = color
                };

                context.Bikes.Add(bike);

                context.SaveChanges();
            }
        }

    }
}
