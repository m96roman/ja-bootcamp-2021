using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class ComputerWithBackLight : ComputerDecorator
    {
        public ComputerWithBackLight(Computer computer) : base(computer.Name + " with backlight", computer)
        {
        }
    }
}
