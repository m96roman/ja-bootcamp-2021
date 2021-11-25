using ConsoleApp6.Enums;

namespace ConsoleApp6.Abstracts
{
    public abstract class House
    {
        public Floors FloorAmount { get; set; }
        public TypeHouse Type { get; set; }

        public abstract void BuildHouse(string streetName);
    }
}
