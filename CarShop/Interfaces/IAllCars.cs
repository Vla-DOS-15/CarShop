using CarShop.Models;
using System.Collections.Generic;

namespace CarShop.Interfaces
{
    public interface IAllCars
    {
        IEnumerable<Car> Cars { get; }
        Car GetObjectCar(int carId);
    }
}
