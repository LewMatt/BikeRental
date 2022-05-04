using System.Runtime.Serialization;

namespace BikeRental.Service
{
    [DataContract]
    public class User
    {
        [DataMember]
        public int UserID { get; set; }
        [DataMember]
        public string Login { get; set; }
        [DataMember]
        public string Password { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Surname { get; set; }
        [DataMember]
        public string Phone { get; set; }
        [DataMember]
        public string Address { get; set; }
        [DataMember]
        public string UserType { get; set; }

    }
}
