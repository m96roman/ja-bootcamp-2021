using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class ComputerWithWiFi:ComputerDecorator
    {
      public ComputerWithWiFi(AbstractComputer computer) : base(computer.Name+" wifi",computer)
        {

        }
    }
}
