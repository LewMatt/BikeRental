using System.Runtime.Serialization;

namespace BikeRental.Service
{
    [DataContract]
    public class User
    {
        public int UserID { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }

        public string UserType { get; set; }

    }
}
