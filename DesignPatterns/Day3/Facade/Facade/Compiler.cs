using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class Compiler
    {
        public void Compile() 
        {
            Console.WriteLine("Program was compiled");
        }

        public void Validate()
        {
            Console.WriteLine("Program was validated");
        }
    }
}
