namespace ConsoleApp4.Models
{
    public class Region
    {
        public string Name { get; set; }
        public double Square { get; set; }

        public Region Clone()
        {
            return this.MemberwiseClone() as Region;
        }
    }
}
