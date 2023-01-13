using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module2_HW6.ConcreteVechicles.Bicycles;
using Module2_HW6.ConcreteVechicles.Motos;

namespace Module2_HW6.ConcreteFactories
{
    internal class SportsFactory : IAbstractFactory
    {
        public IAbstractCar CreateCar(
            string name,
            string manufacturer,
            int power,
            string racingTeam)
        {
            return new SportsCar(name, manufacturer, power, racingTeam);
        }

        public IAbstractMoto CreateMoto(
            string name,
            string manufacturer,
            int power,
            string racingTeam)
        {
            return new SportsMoto(name, manufacturer, power, racingTeam);
        }

        public IAbstractBicycle CreateBicycle(
            string name,
            string manufacturer,
            int power,
            string racingTeam)
        {
            return new SportsBicycle(name, manufacturer, power, racingTeam);
        }
    }
}
