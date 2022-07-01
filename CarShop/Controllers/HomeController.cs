using CarShop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace CarShop.Controllers
{
    public class HomeController : Controller
    {
        ApplicationContext dbContext;
        //private IAllBooks allBooks;
        public HomeController(ApplicationContext dbContext)
        {
            this.dbContext = dbContext;
        }
        //[Authorize]
        //public IActionResult Index()
        //{
        //    return Content(User.Identity.Name);
        //}

        public ViewResult Index()
        {
            IEnumerable<Car> cars = dbContext.Cars.Include(i => i.BodyCar).Include(i=>i.EngineCharacteristic).Include(x=>x.CarImage);
            ViewBag.Cars = cars;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Contacts()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
