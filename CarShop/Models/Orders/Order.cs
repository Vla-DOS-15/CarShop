using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarShop.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public string FullName { get; set; } // имя фамилия покупателя
        public string ContactPhone { get; set; } // контактный телефон покупателя
        public DateTime DateBuy { get; set; }
        public int CarId { get; set; } // ссылка на связанную модель Phone
        [ForeignKey("CarId")]
        public Car Car { get; set; }
    }
}
