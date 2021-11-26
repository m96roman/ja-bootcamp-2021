using ConsoleApp4.Interfaces;

namespace ConsoleApp4.Models
{
    public class City : IClonable
    {
        public string Name { get; set; }
        public int AmountCitizens { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
