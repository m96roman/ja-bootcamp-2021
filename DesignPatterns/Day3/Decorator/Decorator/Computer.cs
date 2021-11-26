using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Computer : IComputer
    {
        private string ComputerType { get; set; }

        public Computer(string computerType) 
        {
            this.ComputerType = computerType;
        }

        public void Info() 
        {
            Console.WriteLine($"Type of computer : {ComputerType}");
        }
    }
}
