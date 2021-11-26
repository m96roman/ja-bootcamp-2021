using System;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            BuildingCompany startBuilding = new BuildingCompany();
         
            startBuilding.GetHouseType("Brick5").BuildHouse("Apple");
            startBuilding.GetHouseType("Panel6").BuildHouse("Orange");
            startBuilding.GetHouseType("Panel9").BuildHouse("Banana");
            startBuilding.GetHouseType("Monolit9").BuildHouse("Watermelone");
            startBuilding.GetHouseType("Monolit20").BuildHouse("Strawberry");
        }
    }
}
