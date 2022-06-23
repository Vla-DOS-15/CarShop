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
                var transmission = new Transmission
                {
                    GearBox = "Автомат",
                    NumberGear = "6",
                    TypeDrive = "Передній"
                };
                context.Transmissions.Add(transmission);
                var dynamic = new Dynamic
                {
                    RacingTime = 3,
                    MaxSpeed = 180
                };
                context.Dynamics.Add(dynamic);
                                
                var dimension = new Dimension
                {
                    Carrying = 1,
                    Height = 2,
                    Width = 4,
                    Length = 5,
                    FuelTankVolume = 6,
                    Clearance = 7                   
                };
                context.Dimensions.Add(dimension);

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
                        IdBody = bodyCar.BodyId,
                        IdDimension = dimension.DimensionId,
                        IdDynamic = dynamic.DynamicId,
                        IdEngine = engine.EngineId,
                        IdTransmission = transmission.TransmissionId
                    },
                    new Car
                    {
                        Brand = "BMW",
                        Model = "X5",
                        YearManufacture = 2015,
                        Img = "https://motor.ru/imgs/2021/12/11/19/5092583/6a1512b9edcb70e917536471e427f73cbdf9ca26.jpg",
                        IdBody = bodyCar.BodyId,
                        IdDimension = dimension.DimensionId,
                        IdDynamic = dynamic.DynamicId,
                        IdEngine = engine.EngineId,
                        IdTransmission = transmission.TransmissionId
                    },
                    new Car
                    {
                        Brand = "BMW",
                        Model = "X5",
                        YearManufacture = 2015,
                        Img = "https://motor.ru/imgs/2021/12/11/19/5092583/6a1512b9edcb70e917536471e427f73cbdf9ca26.jpg",
                        IdBody = bodyCar.BodyId,
                        IdDimension = dimension.DimensionId,
                        IdDynamic = dynamic.DynamicId,
                        IdEngine = engine.EngineId,
                        IdTransmission = transmission.TransmissionId
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
