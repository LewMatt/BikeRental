using System;
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

        public string AddUser(string login, string password, string name, string surname, string phone, string address)
        {
            int numberOfUsers = GetNumberOfUsers();
            int newUserID = numberOfUsers + 1;

            using (var context = _bikeRentalContext ?? new BikeRentalContext())
            {

                var isLoginAvailable = context.Users.Where(u => u.Login == login).FirstOrDefault();

                if(isLoginAvailable != null)
                {
                    return "";
                }
                else
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

                    return user.Login;
                }

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

        public void AddBike(string brand, string model, string type, string color, int price)
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
                    Color = color,
                    Price = price,
                    IsAvailable = 1
                };

                context.Bikes.Add(bike);

                context.SaveChanges();
            }
        }

        public int GetNumberOfRents()
        {
            int numberOfRents = 0;

            using (var context = _bikeRentalContext ?? new BikeRentalContext())
            {
                numberOfRents = context.Rents.Count();
            }

            return numberOfRents;
        }

        public void AddRent(int userID, int bikeID)
        {

            int numberOfRents = GetNumberOfRents();
            int newRentID = numberOfRents + 1;

            int czas_do_oddania = 1;

            var returnDate = DateTime.Today.AddMonths(czas_do_oddania);

            string returnDateStr = returnDate.ToString("dd MMMM, yyyy");

            using (var context = _bikeRentalContext ?? new BikeRentalContext())
            {
                Bikes bike = context.Bikes.Single(b => b.BikeID == bikeID);

                bike.IsAvailable = 0;

                var rent = new Rents
                {
                   RentID = numberOfRents,
                   UserID = userID,
                   BikeID = bikeID,
                   Price = bike.Price,
                   ExpirationDate = returnDateStr
                };


                context.Rents.Add(rent);


                context.SaveChanges();
            }
        }

        public int GetUserID(string login)
        {
            int userID = 0;

            using (var context = _bikeRentalContext ?? new BikeRentalContext())
            {
                userID = context.Users.Where(u => u.Login == login).FirstOrDefault().UserID;
            }

            return userID;
        }

        public void ReturnBike(int bikeID)
        {
            using (var context = _bikeRentalContext ?? new BikeRentalContext())
            {
                Bikes bike = context.Bikes.Single(b => b.BikeID == bikeID);

                bike.IsAvailable = 1;

                context.SaveChanges();
            }
        }

        public int GetNumberOfRepairOrders()
        {
            int numberOfRepairOrders = 0;

            using (var context = _bikeRentalContext ?? new BikeRentalContext())
            {
                numberOfRepairOrders = context.RepairOrders.Count();
            }

            return numberOfRepairOrders;
        }

        public void AddRepairOrder(int bikeID, string description)
        {
            int numberOfRepairOrders = GetNumberOfRepairOrders();
            int newRepairOrderID = numberOfRepairOrders + 1;

            using (var context = _bikeRentalContext ?? new BikeRentalContext())
            {
                var repairOrder = new RepairOrders
                {
                    RepairOrderID = newRepairOrderID,
                    BikeID = bikeID,
                    Description = description
                };

                context.RepairOrders.Add(repairOrder);

                context.SaveChanges();
            }
        }

        public int GetNumberOfRepairs()
        {
            int numberOfRepairs = 0;

            using (var context = _bikeRentalContext ?? new BikeRentalContext())
            {
                numberOfRepairs = context.Repairs.Count();
            }

            return numberOfRepairs;
        }

        public void AddRepair(int repairOrderID,int userID, int bikeID, string details, string state, int overallPrice)
        {
            int numberOfRepairs = GetNumberOfRepairs();
            int newRepairID = numberOfRepairs + 1;

            using (var context = _bikeRentalContext ?? new BikeRentalContext())
            {
                var repair = new Repairs
                {
                    RepairID = newRepairID,
                    RepairOrderID = repairOrderID,
                    UserID = userID,
                    BikeID = bikeID,
                    Details = details,
                    State = state,
                    OverallPrice = overallPrice
                };

                context.Repairs.Add(repair);

                context.SaveChanges();
            }
        }

    }
}
