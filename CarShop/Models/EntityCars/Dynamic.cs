using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
namespace CarShop.Models
{
    public class Dynamic
    {
        [Key]
        public int DynamicId { get; set; }
        public uint RacingTime { get; set; }
        public uint MaxSpeed { get; set; }
        public virtual ICollection<Car> Cars { get; set; }
    }
}
