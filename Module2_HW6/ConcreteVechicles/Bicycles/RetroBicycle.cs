using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_HW6.ConcreteVechicles.Bicycles
{
    internal class RetroBicycle : IAbstractBicycle
    {
        public RetroBicycle(
            string name,
            string manufacturer,
            int power,
            int wheelsNumber)
        {
            Name = name;
            Manufacturer = manufacturer;
            Power = power;
            WheelsNumber = wheelsNumber;
        }

        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public int Power { get; set; }
        public int WheelsNumber { get; set; }

        public string BicycleFunction()
        {
            string output =
                $"Name:{Name}, Manufacturer:{Manufacturer}, Power:{Power}, " +
                $"WheelsNumber:{WheelsNumber}";
            return output;
        }
    }
}
