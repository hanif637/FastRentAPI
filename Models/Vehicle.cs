using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FastRentAPI.Models
{
    [Table("vehicles")]
    public class Vehicle
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("vehicle_name")]
        public string VehicleName { get; set; }

        [Column("plate_number")]
        public string PlateNumber { get; set; }

        [Column("price_per_day")]
        public decimal PricePerDay { get; set; }
    }
}