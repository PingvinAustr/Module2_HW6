using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module2_HW6.ConcreteVechicles.Bicycles;
using Module2_HW6.ConcreteVechicles.Motos;

namespace Module2_HW6.ConcreteFactories
{
    internal class RetroFactory : IAbstractFactory
    {
        public IAbstractCar CreateCar(
            string name,
            string manufacturer,
            int power,
            string retroClass)
        {
            return new RetroCar(name, manufacturer, power, retroClass);
        }

        public IAbstractMoto CreateMoto(
            string name,
            string manufacturer,
            int power,
            string retroClass)
        {
            return new RetroMoto(name, manufacturer, power, retroClass);
        }

        public IAbstractBicycle CreateBicycle(
            string name,
            string manufacturer,
            int power,
            int wheelsNum)
        {
            return new RetroBicycle(name, manufacturer, power, wheelsNum);
        }
    }
}
