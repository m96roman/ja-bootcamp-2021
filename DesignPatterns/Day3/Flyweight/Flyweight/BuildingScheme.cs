namespace Flyweight
{
    public class BuildingScheme : IBuildingScheme
    {
        public int Floors { get; set; }

        public MaterialType Material { get; set; }

        public string BuildingAddress { get; set; }

        public override string ToString()
        {
            return BuildingAddress + " " + Material + " " + Floors;
        }
    }
}
