namespace Flyweight
{
    class BuildingOperation
    {
        private IBuildingScheme buildingScheme;

        public BuildingOperation(IBuildingScheme buildingScheme)
        {
            this.buildingScheme = buildingScheme;
        }

        public string BuildByScheme()
        {
            return $"Building with {buildingScheme.Floors} floors with {buildingScheme.Material}";
        }
    }
}
