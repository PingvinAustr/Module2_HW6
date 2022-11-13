using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_HW6
{
    public class MyGarage
    {
        private IAbstractBicycle[] _myBikes;
        private IAbstractCar[] _myCars;
        private IAbstractMoto[] _myMotos;
        public MyGarage(
            IAbstractBicycle[] bikes,
            IAbstractCar[] cars,
            IAbstractMoto[] motos)
        {
            _myBikes = bikes;
            _myCars = cars;
            _myMotos = motos;
        }

        public IAbstractBicycle[] ReturnBikes()
        {
            return _myBikes;
        }

        public IAbstractCar[] ReturnCars()
        {
            return _myCars;
        }

        public IAbstractMoto[] ReturnMotos()
        {
            return _myMotos;
        }

        public void SetGarageTransport(
            IAbstractBicycle[] bikes,
            IAbstractCar[] cars,
            IAbstractMoto[] motos)
        {
            _myBikes = bikes;
            _myCars = cars;
            _myMotos = motos;
        }

        public int ReturnTotalGroupPower(string type)
        {
            int powerSum = 0;
            switch (type)
            {
                case "moto":
                    {
                        foreach (var moto in _myMotos)
                        {
                            powerSum += moto.Power;
                        }

                        break;
                    }

                case "bicycle":
                    {
                        foreach (var bike in _myBikes)
                        {
                            powerSum += bike.Power;
                        }

                        break;
                    }

                case "car":
                    {
                        foreach (var car in _myCars)
                        {
                            powerSum += car.Power;
                        }

                        break;
                    }
            }

            return powerSum;
        }
    }
}
