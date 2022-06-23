using System.ComponentModel.DataAnnotations;

namespace CarShop.Models
{
    public class ShopCartItem
    {
        [Key]
        public int ItemId { get; set; }
        public Car Car { get; set; }
        public string ShopCartId { get; set; }
    }
}
