using Microsoft.AspNetCore.Identity;

namespace CarShop.Models.Identity
{
    public class User : IdentityUser
    {
        public int Year { get; set; }
    }
}
