using System.Linq;
using CarShop.Models;
namespace CarShop
{
    public class SampleData
    {
        public static void Initialize(ApplicationContext context)
        {
            if (!context.Cars.Any())
            {
                var engine = new Engine
                {
                    ToxicityStandardEuro = "5",
                    NumberCylindersValves = "5/7",
                    Volume = "5",
                    Fuel = "Бензин",
                    FuelConsumption = "4",
                    EnginePower = "Бензин",
                    MaxTorque = "Бензин",
                    CylinderArrangement = "Бензин",
                };
                context.Engines.Add(engine);

                var bodyCar = new BodyCar { 
                    NumberDoors = 5,
                    NumberSeats = 4
                };
                context.BodyCars.AddRange(bodyCar);
                context.SaveChanges();
                context.Cars.AddRange(
                    new Car
                    {
                        Brand = "BMW",
                        Model = "X5",
                        YearManufacture = 2015,
                        Img = "https://motor.ru/imgs/2021/12/11/19/5092583/6a1512b9edcb70e917536471e427f73cbdf9ca26.jpg",
                        IdBody = bodyCar.BodyId
                    },
                    new Car
                    {
                        Brand = "BMW",
                        Model = "X5",
                        YearManufacture = 2015,
                        Img = "https://motor.ru/imgs/2021/12/11/19/5092583/6a1512b9edcb70e917536471e427f73cbdf9ca26.jpg",
                        IdBody = bodyCar.BodyId
                    },
                    new Car
                    {
                        Brand = "BMW",
                        Model = "X5",
                        YearManufacture = 2015,
                        Img = "https://motor.ru/imgs/2021/12/11/19/5092583/6a1512b9edcb70e917536471e427f73cbdf9ca26.jpg",
                        IdBody = bodyCar.BodyId
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
