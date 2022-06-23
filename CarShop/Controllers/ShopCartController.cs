using CarShop.Interfaces;
using CarShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CarShop.Controllers
{
    public class ShopCartController : Controller
    {
        private IAllCars carRepository;
        private readonly ShopCart shopCart;
        public ShopCartController(IAllCars carRepository, ShopCart shopCart)
        {
            this.carRepository = carRepository;
            this.shopCart = shopCart;
        }
        public ViewResult Index()
        {
            var items = shopCart.GetShopCartItems();
            shopCart.ListShopItems = items;
            var obj = new ShopCartViewModel { shopCart = shopCart };
            return View(obj);
        }
        public RedirectToActionResult AddToCart(int id)
        {
            var item = carRepository.Cars.FirstOrDefault(i => i.IdCar == id);
            if (item != null)
                shopCart.AddToCart(item);
            return RedirectToAction("Index");
        }
    }
}
