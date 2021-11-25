using System;
using ConsoleApp6.Abstracts;

namespace ConsoleApp6.Streets
{
    public class SecondStreet : Street
    {
        public override void AddHouse(House house)
        {
            houses.Add(house);
        }

        public override void ShowAllHouses()
        {
            Console.WriteLine($"Houses on {Name} street");

            foreach (var house in houses)
            {
                Console.WriteLine($"{house.Type} house with {house.FloorAmount} floors on street {Name}");
            }
        }
    }
}
