using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_HW6
{
    internal class SportsCar : IAbstractCar
    {
        public SportsCar(
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
        public string CarFunction()
        {
            string output =
                $"Name:{Name}, Manufacturer:{Manufacturer}, Power:{Power}, " +
                $"RacingTeamName:{RacingTeamName}";
            return output;
        }
    }
}
