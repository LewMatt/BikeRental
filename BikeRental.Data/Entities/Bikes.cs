using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BikeRental.Data.Entities
{
    [Table("Bikes")]
    public class Bikes
    {
        [Key]
        public int BikeID { get; set; }

        [Required]
        [StringLength(200)]
        public string Brand { get; set; }

        [Required]
        [StringLength(200)]
        public string Model { get; set; }

        [StringLength(200)]
        public string Type { get; set; }

        [StringLength(200)]
        public string Color { get; set; }

        public int IsAvailable { get; set; }
    }
}
