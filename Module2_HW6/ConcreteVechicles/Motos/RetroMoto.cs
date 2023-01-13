using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_HW6.ConcreteVechicles.Motos
{
    internal class RetroMoto : IAbstractMoto
    {
        public RetroMoto(
            string name,
            string manufacturer,
            int power,
            string retroClass)
        {
            Name = name;
            Manufacturer = manufacturer;
            Power = power;
            RetroClass = retroClass;
        }

        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public int Power { get; set; }
        public string RetroClass { get; set; }
        public string MotoFunction()
        {
            string output =
                $"Name:{Name}, Manufacturer:{Manufacturer}, Power:{Power}, " +
                $"RetroClass:{RetroClass}";
            return output;
        }
    }
}
