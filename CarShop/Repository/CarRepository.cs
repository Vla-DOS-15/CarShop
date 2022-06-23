using CarShop.Interfaces;
using CarShop.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace CarShop.Repository
{
    public class CarRepository : IAllCars
    {
        private readonly ApplicationContext carContext;
        public CarRepository(ApplicationContext carContext)
        {
            this.carContext = carContext;
        }
        public IEnumerable<Car> Cars => carContext.Cars.Include(c => c.BodyCar);

        public Car GetObjectCar(int carId) => carContext.Cars.FirstOrDefault(p => p.IdCar == carId);
    }
}
