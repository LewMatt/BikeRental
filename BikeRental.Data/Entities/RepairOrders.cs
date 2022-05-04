using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BikeRental.Data.Entities
{
    [Table("RepairOrders")]
    public class RepairOrders
    {
        [Key]
        public int RepairOrderID { get; set; }

        [ForeignKey("Bikes")]
        public int BikeID { get; set; }
        public Bikes Bikes { get; set; }

        [StringLength(200)]
        public string Description { get; set; }


    }
}
