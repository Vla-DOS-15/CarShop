using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace CarShop.Models.Identity
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
