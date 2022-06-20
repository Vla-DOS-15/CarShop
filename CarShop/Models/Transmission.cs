using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CarShop.Models
{
    public class Transmission
    {
        [Key]
        public int TransmissionId { get; set; }
        public string GearBox { get; set; } // Коробка передач
        public string NumberGear { get; set; } // кількість передач
        public string TypeDrive { get; set; } // тип привода
        public virtual ICollection<Car> Cars { get; set; }
    }
}
