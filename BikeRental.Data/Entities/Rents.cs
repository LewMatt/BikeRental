using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace BikeRental.Data.Entities
{
    [Table("Rents")]
    public class Rents
    {
        [Key]
        public int RentID { get; set; }

        [ForeignKey("Users")]
        public int UserID { get; set; }
        public Users Users { get; set; }

        [ForeignKey("Bikes")]
        public int BikeID { get; set; }
        public Bikes Bikes { get; set; }

        public int Price { get; set; }

        [StringLength(200)]
        public string ExpirationDate { get; set; }

        public int IsAvailable { get; set; }

    }
}
