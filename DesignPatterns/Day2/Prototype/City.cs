using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    [Serializable]
    public class City
    {
        public string Name { get; set; }
        public int Population { get; set; }

        public City(string name,int population)
        {
            Name = name;
            Population = population;
        }
    }
}
