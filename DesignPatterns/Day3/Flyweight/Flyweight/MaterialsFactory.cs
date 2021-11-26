using System;
using System.Collections.Generic;

namespace Flyweight
{
    public class MaterialsFactory
    {
        private Dictionary<string, FlyweightMaterialType> types = new Dictionary<string, FlyweightMaterialType>();

        public MaterialsFactory(Dictionary<string, FlyweightMaterialType> types)
        {
            this.types = types;
        }

        public FlyweightMaterialType GetMaterial(string MaterialName, string MaterialColor)
        {
            var hash = HashMaterials(MaterialName, MaterialColor);

            if (!types.ContainsKey(hash))
            {
                Console.WriteLine($"Creating flyweight {hash}");

                FlyweightMaterialType flyweightBuildingScheme = new FlyweightMaterialType(
                    new MaterialType
                    { MaterialName = MaterialName, MaterialColor = MaterialColor });

                types.Add(hash, flyweightBuildingScheme);
            }
            else
            {
                Console.WriteLine($"Reusing flyweight {hash}");
            }

            return types[hash];
        }

        private static string HashMaterials(string MaterialName, string MaterialColor)
        {
            return MaterialName + "_" + MaterialColor;
        }
    }
}
