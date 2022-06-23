using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
namespace CarShop.Models
{
    public class Dimension
    {
        [Key]
        public int DimensionId { get; set; }
        public uint Carrying { get; set; } // грузоподйомність
        public uint Height { get; set; }
        public uint Width { get; set; }
        public uint Length { get; set; }
        public double FuelTankVolume { get; set; } // обєм бака 
        public double Clearance { get; set; }
        public virtual ICollection<Car> Cars { get; set; }
    }
}
