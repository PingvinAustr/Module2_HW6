using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_HW6
{
    internal class RetroCar : IAbstractCar
    {
        public RetroCar(
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

        public string CarFunction()
        {
            string output =
                $"Name:{Name}, Manufacturer:{Manufacturer}, Power:{Power}, " +
                $"RetroClass:{RetroClass}";
            return output;
        }
    }
}
