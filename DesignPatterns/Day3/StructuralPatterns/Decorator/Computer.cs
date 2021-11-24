using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    abstract class Computer
    {
        public string Name { get; set; }
        public Computer(string name)
        {
            Name = name;
        }
    }
}
