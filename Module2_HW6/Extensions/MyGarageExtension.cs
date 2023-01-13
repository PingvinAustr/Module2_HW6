using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_HW6
{
    public static class MyGarageExtension
    {
        public static IAbstractBicycle FindLowestPowerBike(
            this MyGarage garage,
            IAbstractBicycle[] bikes)
        {
            int minPower = int.MaxValue;
            IAbstractBicycle slowestBike = null;

            foreach (IAbstractBicycle bikeLoc in bikes)
            {
                if (bikeLoc.Power < minPower)
                {
                    minPower = bikeLoc.Power;
                    slowestBike = bikeLoc;
                }
            }

            return slowestBike;
        }

        public static IAbstractCar FindLowestPowerCar(
            this MyGarage garage,
            IAbstractCar[] cars)
        {
            int minPower = int.MaxValue;
            IAbstractCar slowestCar = null;

            foreach (IAbstractCar carLoc in cars)
            {
                if (carLoc.Power < minPower)
                {
                    minPower = carLoc.Power;
                    slowestCar = carLoc;
                }
            }

            return slowestCar;
        }

        public static IAbstractMoto FindLowestPowerMoto(
            this MyGarage garage,
            IAbstractMoto[] motos)
        {
            int minPower = int.MaxValue;
            IAbstractMoto slowestMoto = null;

            foreach (IAbstractMoto motoLoc in motos)
            {
                if (motoLoc.Power < minPower)
                {
                    minPower = motoLoc.Power;
                    slowestMoto = motoLoc;
                }
            }

            return slowestMoto;
        }
    }
}
