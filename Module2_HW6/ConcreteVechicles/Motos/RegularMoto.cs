using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_HW6.ConcreteVechicles.Motos
{
    public class RegularMoto : IAbstractMoto
    {
        public RegularMoto(
            string name,
            string manufacturer,
            int power,
            int bagVolume)
        {
            Name = name;
            Manufacturer = manufacturer;
            Power = power;
            BagVolume = bagVolume;
        }

        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public int Power { get; set; }
        public int BagVolume { get; set; }

        public string MotoFunction()
        {
            string output =
                $"Name:{Name}, Manufacturer:{Manufacturer}, Power:{Power}, " +
                $"BagVolume:{BagVolume}";
            return output;
        }
    }
}
