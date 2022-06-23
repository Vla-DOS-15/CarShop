namespace CarShop.Models
{
    public class Engine
    {
        public int EngineId { get; set; }
        public string ToxicityStandardEuro { get; set; }
        public string NumberCylindersValves { get; set; } // Количество цилиндров/клапанов
        public string Volume { get; set; } // Рабочий объем, куб. см
        public string Fuel { get; set; } // топливo
        public string FuelConsumption { get; set; } // Расход топлива
        public string EnginePower { get; set; } // Мощность двигателя кВт (л.с.) в 1/мин
        public string MaxTorque { get; set; } // Макс. крутящий момент, Нм при об./мин
        public string CylinderArrangement { get; set; } // Расположение цилиндров

    }
}
