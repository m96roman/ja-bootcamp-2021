using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopulationApp
{
    public class Person
    {
        public string Name;
        public Cities City;

        public Person(string name, Cities city)
        {
            this.Name = name;
            this.City = city;
        }
    }
}
