using System;

namespace Countries_Prototype
{
    internal class Region : ICloneable
    {
        public Region(string name, double area)
        {
            Name = name;
            Area = area;
        }

        public string Name { get; internal set; }
        public double Area { get; internal set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public override string ToString()
        {
            return $"{Name} - {Area}";
        }
    }
}