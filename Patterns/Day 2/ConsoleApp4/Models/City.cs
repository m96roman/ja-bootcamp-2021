namespace ConsoleApp4.Models
{
    public class City
    {
        public string Name { get; set; }
        public int AmountCitizens { get; set; }

        public City Clone()
        {
            return this.MemberwiseClone() as City;
        }
    }
}
