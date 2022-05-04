using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BikeRental.Data.Entities
{
    [Table("Repairs")]
    public class Repairs
    {
        [Key]
        public int RepairID { get; set; }

        [ForeignKey("RepairOrders")]
        public int RepairOrderID { get; set; }
        public RepairOrders RepairOrders { get; set; }

        [ForeignKey("Users")]
        public int UserID { get; set; }
        public Users Users { get; set; }

        [ForeignKey("Bikes")]
        public int BikeID { get; set; }
        public Bikes Bikes { get; set; }

        [StringLength(200)]
        public string Details { get; set; }

        [StringLength(200)]
        public string State { get; set; }

        public int OverallPrice { get; set; }
    }
}
