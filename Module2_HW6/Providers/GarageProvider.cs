using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_HW6
{
    public static class GarageProvider
    {
        public static void PrintAllGarageInfo(MyGarage garage)
        {
            IAbstractMoto[] motos = garage.ReturnMotos();
            IAbstractCar[] cars = garage.ReturnCars();
            IAbstractBicycle[] bikes = garage.ReturnBikes();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Info about current garage items:\nCars:");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (var car in cars)
            {
                Console.WriteLine(car.CarFunction());
            }

            Console.WriteLine("Sum power of cars:"
                + garage.ReturnTotalGroupPower("car"));

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nMotos:");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (var moto in motos)
            {
                Console.WriteLine(moto.MotoFunction());
            }

            Console.WriteLine("Sum power of motos:"
                + garage.ReturnTotalGroupPower("moto"));

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nBikes:");
            Console.ForegroundColor = ConsoleColor.White;

            foreach (var bike in bikes)
            {
                Console.WriteLine(bike.BicycleFunction());
            }

            Console.WriteLine("Sum power of bikes:"
                + garage.ReturnTotalGroupPower("bicycle"));
        }

        public static void SortGarageItemsPerPowerAsc(MyGarage garage)
        {
            IAbstractBicycle[] bikes =
                new IAbstractBicycle[garage.ReturnBikes().Length];
            IAbstractBicycle[] bikesFilled = garage.ReturnBikes();
            int[] bikesPowers = new int[garage.ReturnBikes().Length];

            IAbstractCar[] cars =
                new IAbstractCar[garage.ReturnCars().Length];
            IAbstractCar[] carsFilled = garage.ReturnCars();
            int[] carsPowers = new int[garage.ReturnCars().Length];

            IAbstractMoto[] motos =
                new IAbstractMoto[garage.ReturnMotos().Length];
            IAbstractMoto[] motosFilled = garage.ReturnMotos();
            int[] motosPowers = new int[garage.ReturnMotos().Length];

            for (int i = 0; i < bikesFilled.Length; i++)
            {
                bikesPowers[i] = bikesFilled[i].Power;
            }

            int len = bikesFilled.Length;
            for (int i = 1; i < len; i++)
            {
                for (int j = 0; j < len - i; j++)
                {
                    if (bikesPowers[j] > bikesPowers[j + 1])
                    {
                        Swap<int>(
                            ref bikesPowers[j],
                            ref bikesPowers[j + 1]);
                        Swap<IAbstractBicycle>(
                            ref bikesFilled[j],
                            ref bikesFilled[j + 1]);
                    }
                }
            }

            for (int i = 0; i < carsFilled.Length; i++)
            {
                carsPowers[i] = carsFilled[i].Power;
            }

            int len1 = carsFilled.Length;
            for (int i = 1; i < len1; i++)
            {
                for (int j = 0; j < len1 - i; j++)
                {
                    if (carsPowers[j] > carsPowers[j + 1])
                    {
                        Swap<int>(
                            ref carsPowers[j],
                            ref carsPowers[j + 1]);
                        Swap<IAbstractCar>(
                            ref carsFilled[j],
                            ref carsFilled[j + 1]);
                    }
                }
            }

            for (int i = 0; i < motosFilled.Length; i++)
            {
                motosPowers[i] = motosFilled[i].Power;
            }

            int len2 = motosFilled.Length;
            for (int i = 1; i < len2; i++)
            {
                for (int j = 0; j < len2 - i; j++)
                {
                    if (motosPowers[j] > motosPowers[j + 1])
                    {
                        Swap<int>(
                            ref motosPowers[j],
                            ref motosPowers[j + 1]);
                        Swap<IAbstractMoto>(
                            ref motosFilled[j],
                            ref motosFilled[j + 1]);
                    }
                }
            }

            garage.SetGarageTransport(bikesFilled, carsFilled, motosFilled);
        }

        // To swap items while sorting
        internal static void Swap<T>(ref T e1, ref T e2)
        {
            var temp = e1;
            e1 = e2;
            e2 = temp;
        }
    }
}
