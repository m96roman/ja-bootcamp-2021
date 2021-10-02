using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPlyskaLect5
{
    public class Person
    {
        public string City { get; }
        public string Name { get; }

        public Person(string city, string name)
        {
            City = city;
            Name = name;
        }

    }
}
