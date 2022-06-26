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
                var refCarImg1 = new CarImage
                {
                    RefFirstImg = "https://cdn2.riastatic.com/photosnew/auto/photo/bmw_x3__449587812hd.webp",
                    RefSecondImg = "https://cdn0.riastatic.com/photosnew/auto/photo/bmw_x3__449587825hd.webp",
                    RefThirdImg = "https://cdn4.riastatic.com/photosnew/auto/photo/bmw_x3__449587844hd.webp"
                };
                var refCarImg2 = new CarImage
                {
                    RefFirstImg = "https://cdn2.riastatic.com/photosnew/auto/photo/bmw_x3__449587812hd.webp",
                    RefSecondImg = "https://cdn0.riastatic.com/photosnew/auto/photo/bmw_x3__449587825hd.webp",
                    RefThirdImg = "https://cdn4.riastatic.com/photosnew/auto/photo/bmw_x3__449587844hd.webp"
                };
                var refCarImg3 = new CarImage
                {
                    RefFirstImg = "https://cdn2.riastatic.com/photosnew/auto/photo/bmw_x3__449587812hd.webp",
                    RefSecondImg = "https://cdn0.riastatic.com/photosnew/auto/photo/bmw_x3__449587825hd.webp",
                    RefThirdImg = "https://cdn4.riastatic.com/photosnew/auto/photo/bmw_x3__449587844hd.webp"
                };
                context.CarImages.AddRange(refCarImg1, refCarImg2, refCarImg3);
                context.SaveChanges();
                context.Cars.AddRange(
                    new Car
                    {
                        Brand = "BMW",
                        Model = "X3",
                        YearManufacture = 2014,
                        Price = 900000,
                        IdCarImage = refCarImg1.IdCarImg,
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
                        YearManufacture = 2020,
                        Price = 900000,
                        IdCarImage = refCarImg2.IdCarImg,
                        IdBody = bodyCar.BodyId,
                        IdDimension = dimension.DimensionId,
                        IdDynamic = dynamic.DynamicId,
                        IdEngine = engine.EngineId,
                        IdTransmission = transmission.TransmissionId
                    },
                    new Car
                    {
                        Brand = "BMW",
                        Model = "X6",
                        YearManufacture = 2021,
                        Price = 900000,
                        IdCarImage = refCarImg3.IdCarImg,
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
