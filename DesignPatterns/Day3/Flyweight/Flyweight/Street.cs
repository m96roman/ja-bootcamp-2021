using System.Collections.Generic;

namespace Flyweight
{
    class Street
    {
        public string Name { get; private set; }

        private List<IBuildingScheme> buildings = new List<IBuildingScheme>();

        public Street(List<IBuildingScheme> buildings, string name)
        {
            this.Buildings = buildings;
            Name = name;
        }

        internal List<IBuildingScheme> Buildings { get => buildings; private set => buildings = value; }

        public void Add(IBuildingScheme buildingScheme)
        {
            buildings.Add(buildingScheme);
        }
    }
}
