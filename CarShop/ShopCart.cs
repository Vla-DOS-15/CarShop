using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using CarShop.Models;

namespace CarShop
{
    public class ShopCart
    {
        private readonly ApplicationContext carContext;
        public ShopCart(ApplicationContext carContext)
        {
            this.carContext = carContext;
        }
        [System.ComponentModel.DataAnnotations.Key]
        public string ShopCartId { get; set; }
        public List<ShopCartItem> ListShopItems { get; set; }
        public static ShopCart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = services.GetService<ApplicationContext>();
            string shopCartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();
            session.SetString("CartId", shopCartId);
            return new ShopCart(context) { ShopCartId = shopCartId };
        }

        public void AddToCart(Car car)
        {
            carContext.ShopCartItems.Add(new ShopCartItem
            {
                ShopCartId = ShopCartId,
                Car = car
            });
            carContext.SaveChanges();
        }
        public List<ShopCartItem> GetShopCartItems()
        {
            return carContext.ShopCartItems.Where(w => w.ShopCartId == ShopCartId).Include(i => i.Car).ToList();
        }
    }
}
