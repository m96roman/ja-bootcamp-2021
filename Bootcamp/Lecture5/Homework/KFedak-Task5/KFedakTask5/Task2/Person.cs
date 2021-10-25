using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFedakTask5
{
    public class Person
    {
        public string Name { get; set; }
        public string City { get; set; }

        public Person(string name, string city)
        {
            this.Name = name;
            this.City = city;
        }
    }
}
