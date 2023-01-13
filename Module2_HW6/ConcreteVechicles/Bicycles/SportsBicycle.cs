using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_HW6.ConcreteVechicles.Bicycles
{
    internal class SportsBicycle : IAbstractBicycle
    {
        public SportsBicycle(
            string name,
            string manufacturer,
            int power,
            string racingTeamName)
        {
            Name = name;
            Manufacturer = manufacturer;
            Power = power;
            RacingTeamName = racingTeamName;
        }

        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public int Power { get; set; }
        public string RacingTeamName { get; set; }
        public string BicycleFunction()
        {
            string output =
                $"Name:{Name}, Manufacturer:{Manufacturer}, Power:{Power}, " +
                $"WheelsNumber:{RacingTeamName}";
            return output;
        }
    }
}
