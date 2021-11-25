using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Compiler
    {
        public void Validate()
        {
            Console.WriteLine("I am doing validation.");
        }

        public void Compile()
        {
            Console.WriteLine("I am doing compilation.");
        }
    }
}
