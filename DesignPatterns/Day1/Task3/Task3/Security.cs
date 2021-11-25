using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Security : Person
    {
        public string Weapon { get; set; }

        public void Check(Person person, string weapon)
        {
            Console.WriteLine($"{person.GetFullName()} on duty has a {weapon}");
        }
    }
}
