using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace CarShop.Models
{
    public class BodyCar
    {
        [Key]
        public int BodyId { get; set; }
        public uint NumberDoors { get; set; } // кылькысть дверей
        public uint NumberSeats { get; set; } // кількість місць
        public virtual ICollection<Car> Cars { get; set; }
    }
}
