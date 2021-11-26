namespace Flyweight
{
    public class MaterialType
    {
        public string MaterialName { get; set; }

        public string MaterialColor { get; set; }

        public override string ToString()
        {
            return $"[ {MaterialName} { MaterialColor} ]";
        }
    }
}