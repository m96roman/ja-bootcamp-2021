using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    class Panel9Stages: House
    {
        private int stages = 9;
   
        public override void BuildHouse(string streetName)
        {
            Console.WriteLine($"Building a {stages}-stage brick house on {streetName} street.");
        }
    }
}
