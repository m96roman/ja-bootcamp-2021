using ConsoleApp4.Interfaces;

namespace ConsoleApp4.Models
{
    public class Region : IClonable
    {
        public string Name { get; set; }
        public double Square { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
