using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal  class ComputerWithWiFi:ComputerDecorator
    {
        public ComputerWithWiFi( Computer computer) : base(computer.Name+" with WiFi", computer)
        {
        }
    }
}
