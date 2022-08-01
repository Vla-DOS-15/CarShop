using CarShop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CarShop.Controllers
{
    public class OrderController : Controller
    {
        ApplicationContext dbContext;
        public OrderController(ApplicationContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public IActionResult Index()
        {
            var orderId = dbContext.Orders.Include(i => i.Car).Select(x=>x.OrderId).ToList().Last();
            IEnumerable<Order> orders = dbContext.Orders.Include(i => i.Car).Where(x=>x.OrderId == orderId).ToList();

            ViewBag.Orders = orders;
            return View();
        }
        [HttpGet]
        public ActionResult Buy(int? id)
        {
            if (id == null)
                return RedirectToAction("/Home/Index");
            ViewBag.CarId = id;
            return View();
        }
        [HttpPost]
        public ActionResult Buy(Order order)
        {
            order.DateBuy = DateTime.Now;
            dbContext.Orders.Add(order);
            // сохраняем в бд все изменения
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
