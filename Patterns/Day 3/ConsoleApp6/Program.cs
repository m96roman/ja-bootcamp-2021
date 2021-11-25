using System;
using ConsoleApp6.Streets;
using ConsoleApp6.Abstracts;
using ConsoleApp6.Enums;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Flyweight */

            // create factory
            HouseFactory houseFactory = new HouseFactory();

            // create streets
            FirstStreet street1 = new FirstStreet() { Name = "First"};
            FirstStreet street2 = new FirstStreet() { Name = "Second" };

            // building houses for first street
            for (int i = 0; i < 1; i++)
            {
                House brickHouse = houseFactory.GetHouse(new Tuple<Floors, TypeHouse>(Floors.Five, TypeHouse.Brick));
                House monolitHouse = houseFactory.GetHouse(new Tuple<Floors, TypeHouse>(Floors.Nine, TypeHouse.Monolit));
                House panelHouse = houseFactory.GetHouse(new Tuple<Floors, TypeHouse>(Floors.Six, TypeHouse.Panel));

                BuildAndAddHouse(brickHouse, street1);
                BuildAndAddHouse(monolitHouse, street1);
                BuildAndAddHouse(panelHouse, street1);
            }

            // building houses for second street
            Console.WriteLine();
            for (int i = 0; i < 1; i++)
            {
                House brickHouse = houseFactory.GetHouse(new Tuple<Floors, TypeHouse>(Floors.Five, TypeHouse.Brick));
                House monolitHouse = houseFactory.GetHouse(new Tuple<Floors, TypeHouse>(Floors.Twenty, TypeHouse.Monolit));
                House panelHouse = houseFactory.GetHouse(new Tuple<Floors, TypeHouse>(Floors.Nine, TypeHouse.Panel));

                BuildAndAddHouse(brickHouse, street2);
                BuildAndAddHouse(monolitHouse, street2);
                BuildAndAddHouse(panelHouse, street2);
            }

            Console.WriteLine();
            street1.ShowAllHouses();
            Console.WriteLine();
            street2.ShowAllHouses();
        }

        static void BuildAndAddHouse(House house, Street street)
        {
            if (house != null)
            {
                house.BuildHouse(street.Name);
                street.AddHouse(house);
            }
        }
    }
}
