using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_HW6.ConcreteVechicles.Bicycles
{
    internal class RegularBicycle : IAbstractBicycle
    {
        public RegularBicycle(
            string name,
            string manufacturer,
            int power,
            bool isForChildren)
        {
            Name = name;
            Manufacturer = manufacturer;
            Power = power;
            IsForChildren = isForChildren;
        }

        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public int Power { get; set; }
        public bool IsForChildren { get; set; }

        public string BicycleFunction()
        {
            string output =
                $"Name:{Name}, Manufacturer:{Manufacturer}, Power:{Power}, " +
                $"IsForChildren:{IsForChildren}";
            return output;
        }
    }
}
