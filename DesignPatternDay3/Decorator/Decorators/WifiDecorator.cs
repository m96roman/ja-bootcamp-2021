using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class WifiDecorator : ComputerDecorator
    {
        public WifiDecorator(Computer computer)
            : base(computer, $"Computer ot type {computer._type} with Wi-Fi.")
        { }

        public override int Price()
        {
            return computer.Price() + 8;
        }
    }
}
