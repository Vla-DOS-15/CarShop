using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarShop.Models
{
    public class Car
    {
        [Key]
        public int IdCar { get; set; }
        //public string Img { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public uint YearManufacture { get; set; }
        public decimal? Price { get; set; }
        public int IdCarImage { get; set; }
        [ForeignKey("IdCarImage")]
        public CarImage CarImage { get; set; }
        public int IdEngine { get; set; }
        [ForeignKey("IdEngine")]
        public Engine EngineCharacteristic { get; set; }
        public int IdBody { get; set; }
        [ForeignKey("IdBody")]
        public BodyCar BodyCar { get; set; }
        public int IdTransmission { get; set; }
        [ForeignKey("IdTransmission")]
        public Transmission Transmission { get; set; }
        public int IdDynamic { get; set; }
        [ForeignKey("IdDynamic")]
        public Dynamic Dynamic { get; set; }
        public int IdDimension { get; set; }
        [ForeignKey("IdDimension")]
        public Dimension Dimension { get; set; }
        public virtual Order Order { get; set; }
    }
}
