﻿using CarShop.Models;
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
    public class CarInfoController : Controller
    {
        ApplicationContext dbContext;
        public CarInfoController(ApplicationContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public IActionResult Index(int? id)
        {
            if (id == null)
                return RedirectToAction("/Home/Index");
            ViewBag.CarId = id;
            //IEnumerable<Car> cars = dbContext.Cars.Include(i => i.BodyCar);
            //ViewBag.Cars = cars;
            return View();
        }
        [HttpGet]
        public ActionResult GetInfo(int? id)
        {
            if (id == null)
                return RedirectToAction("/Home/Index");
            ViewBag.CarId = id;
            IEnumerable<Car> cars = dbContext.Cars.Include(i => i.BodyCar).Include(i=>i.EngineCharacteristic).Include(x => x.CarImage).Include(x=>x.Dimension).Include(x=>x.Transmission).Include(x=>x.Dynamic).Where(x => x.IdCar == id);
            ViewBag.Cars = cars;
            return View();
        }
    }
}
