using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module2_HW6.ConcreteFactories;
using Module2_HW6.ConcreteVechicles.Bicycles;

namespace Module2_HW6
{
    internal static class Starter
    {
        public static void Run()
        {
            Console.WriteLine("\n\n---------------------");
            IAbstractFactory factoryRegular = new RegularFactory();
            var regularCar = (factoryRegular as RegularFactory)
                .CreateCar(
                "Honda Accord",
                "Honda",
                200,
                RegularCar.TransimssionTypeEnum.Auto);
            var regularMoto = (factoryRegular as RegularFactory)
                .CreateMoto(
                "Pioneer",
                "ZAZ",
                100,
                10);
            var regularBike = (factoryRegular as RegularFactory)
                .CreateBicycle(
                "Ukraine",
                "Velozavod",
                10,
                true);

            IAbstractFactory factorySports = new SportsFactory();
            var sportsCar = (factorySports as SportsFactory)
                .CreateCar(
                "Ferrari x9",
                "Ferrari",
                400,
                "FerrariTeam");
            var sportsMoto = (factorySports as SportsFactory)
                .CreateMoto(
                "Suzukix100",
                "Suzuki",
                300,
                "SuzukiTeam");
            var sportsBike = (factorySports as SportsFactory)
                .CreateBicycle(
                "BMX19",
                "BikeRaceInc",
                50,
                "BikeRaceTeam");

            IAbstractFactory factoryRetro = new RetroFactory();
            var retroCar = (factoryRetro as RetroFactory)
                .CreateCar(
                   "Cadillac",
                   "Cadillac",
                   100,
                   "Very old car");
            var retroMoto = (factoryRetro as RetroFactory)
                .CreateMoto(
                "OldMoto",
                "Motozavod",
                40,
                "Very old moto");
            var retroBike = (factoryRetro as RetroFactory)
                .CreateBicycle(
                "OldBike",
                "Velozavod",
                15,
                3);

            IAbstractBicycle[] myBikes = new IAbstractBicycle[3]
            {
                regularBike,
                sportsBike,
                retroBike
            };

            IAbstractCar[] myCars = new IAbstractCar[3]
            {
                regularCar,
                sportsCar,
                retroCar
            };
            IAbstractMoto[] myMotos = new IAbstractMoto[3]
            {
                regularMoto,
                sportsMoto,
                retroMoto
            };
            MyGarage myGarage = new MyGarage(myBikes, myCars, myMotos);
            GarageProvider.PrintAllGarageInfo(myGarage);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\nSorting all groups per power ascending:");
            Console.ForegroundColor = ConsoleColor.White;
            GarageProvider.SortGarageItemsPerPowerAsc(myGarage);
            GarageProvider.PrintAllGarageInfo(myGarage);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\nSearching vechicles with " +
                "lowest powers across all 3 groups:");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Cars:" +
                myGarage.FindLowestPowerCar(
                    myGarage.ReturnCars()).CarFunction());
            Console.WriteLine("Motos:" +
                myGarage.FindLowestPowerMoto(
                    myGarage.ReturnMotos()).MotoFunction());
            Console.WriteLine("Bikes:" +
                myGarage.FindLowestPowerBike(
                    myGarage.ReturnBikes()).BicycleFunction());
        }
    }
}
