﻿using System.Collections.Generic;
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
        void AddBike(string brand, string model, string type, string color);

        [OperationContract]
        void AddRent(int userID, int bikeID, int price, string expirationDate);
    }
}
 