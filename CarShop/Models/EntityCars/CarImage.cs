using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CarShop.Models
{
    public class CarImage
    {
        [Key]
        public int IdCarImg { get; set; }
        public string RefFirstImg { get; set; }
        public string RefSecondImg { get; set; }
        public string RefThirdImg { get; set; }
        public virtual ICollection<Car> Cars { get; set; }
    }
}
