using System;

namespace Countries_Prototype
{
    internal class City : ICloneable
    {
        public City(string name, int population)
        {
            Name = name;
            Population = population;
        }

        public string Name { get; internal set; }
        public int Population { get; internal set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public override string ToString()
        {
            return $"{Name} - {Population}";
        }
    }
}