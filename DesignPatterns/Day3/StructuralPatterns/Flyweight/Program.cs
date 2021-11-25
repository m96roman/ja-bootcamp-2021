using System;
using System.Collections.Generic;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            HouseFactory houseFactory = new HouseFactory();

            Street streetOne = new Street("Avenue");

            Console.WriteLine("Building.................");

            var housePanel6= houseFactory.GetHouse("Panel 6");
            housePanel6.BuildHouse(streetOne);

            var houseMono20 = houseFactory.GetHouse("Monolothic 20");
            houseMono20.BuildHouse(streetOne);

            Street streetTwo = new Street("Oliver");


            var housePanel9 = houseFactory.GetHouse("Panel 9");
            housePanel9.BuildHouse(streetTwo);

            var houseBrick = houseFactory.GetHouse("Brick");
            houseMono20.BuildHouse(streetTwo);


            Console.WriteLine("***********List of streets and their houses***********");
            streetOne.Print();
            Console.WriteLine();
            streetTwo.Print();
        }
    }
}
