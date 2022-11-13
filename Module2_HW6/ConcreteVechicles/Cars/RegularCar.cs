using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_HW6
{
    public class RegularCar : IAbstractCar
    {
        public RegularCar(
            string name,
            string manufacturer,
            int power,
            TransimssionTypeEnum transimssionType)
        {
            Name = name;
            Manufacturer = manufacturer;
            Power = power;
            TransmissionType = transimssionType;
        }

        public enum TransimssionTypeEnum
        {
            Auto,
            Mechanical
        }

        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public int Power { get; set; }
        public TransimssionTypeEnum TransmissionType { get; set; }
        public string CarFunction()
        {
            string output =
                $"Name:{Name}, Manufacturer:{Manufacturer}, Power:{Power}, " +
                $"TransmissionType:{TransmissionType}";
            return output;
        }
    }
}
