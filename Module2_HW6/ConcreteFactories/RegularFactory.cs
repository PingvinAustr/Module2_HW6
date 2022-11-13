using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module2_HW6.ConcreteVechicles.Bicycles;
using Module2_HW6.ConcreteVechicles.Motos;

namespace Module2_HW6.ConcreteFactories
{
    internal class RegularFactory : IAbstractFactory
    {
        public IAbstractCar CreateCar(
            string name,
            string manufacturer,
            int power,
            RegularCar.TransimssionTypeEnum transmission)
        {
            return new RegularCar(name, manufacturer, power, transmission);
        }

        public IAbstractMoto CreateMoto(
            string name,
            string manufacturer,
            int power,
            int bagVol)
        {
            return new RegularMoto(name, manufacturer, power, bagVol);
        }

        public IAbstractBicycle CreateBicycle(
          string name,
          string manufacturer,
          int power,
          bool isForChildren)
        {
            return new RegularBicycle(
                name,
                manufacturer,
                power,
                isForChildren);
        }
    }
}
