using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
namespace CarShop.Models
{
    public class Dimension
    {
        [Key]
        public int DimensionId { get; set; }
        public string Carrying { get; set; } // грузоподйомність
        public string Height { get; set; }
        public string Width { get; set; }
        public string Length { get; set; }
        public string FuelTankVolume { get; set; } // обєм бака 
        public string Clearance { get; set; }
        public virtual ICollection<Car> Cars { get; set; }
    }
}
