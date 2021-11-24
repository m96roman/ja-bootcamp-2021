using System;
using System.Collections.Generic;
using System.Linq;

namespace Flyweight
{
    class Program
    {
        static MaterialsFactory MaterialsFactory = new MaterialsFactory(new Dictionary<string, FlyweightMaterialType>()
        {
            { "bricks_red", new FlyweightMaterialType(new MaterialType{MaterialColor="red",MaterialName="bricks" }) },
            { "monolith_optimisticgrey", new FlyweightMaterialType(new MaterialType{MaterialColor="optimisticgrey",MaterialName="monolith" }) },
            { "bricks_yellow", new FlyweightMaterialType(new MaterialType{MaterialColor="yellow",MaterialName="bricks" }) },
        });

        static void Main(string[] args)
        {
            Street street = new Street(new List<IBuildingScheme>(), "404");

            street.Add(CreateBuilding("123", "bricks", "red", 5));
            street.Add(CreateBuilding("1234", "stone", "blue", 6));
            street.Add(CreateBuilding("12345", "stone", "blue", 6));

            Console.WriteLine(string.Join('\n', street.Buildings));
        }

        private static IBuildingScheme CreateBuilding(string name, string materialName, string materialColor, int floors)
        {
            BuildingScheme buildingScheme = new BuildingScheme();

            var smth = MaterialsFactory.GetMaterial(materialName, materialColor);

            smth.SetMaterial(buildingScheme);

            buildingScheme.Floors = floors;
            buildingScheme.BuildingAddress = name;

            return buildingScheme;
        }
    }
}
