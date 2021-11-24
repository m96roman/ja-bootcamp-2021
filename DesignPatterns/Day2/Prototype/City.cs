using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class City :Prototype
    {
        public string Name { get; set; }
        public int Population { get; set; }

        public City(string name,int population)
        {
            Name = name;
            Population = population;
        }

        public override Prototype Copy()
        {
            var clone = (City)this.MemberwiseClone();
            clone.Name = string.Copy(Name);
            return clone;
        }
    }
}
