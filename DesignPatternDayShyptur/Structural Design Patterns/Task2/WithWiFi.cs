using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class WithWiFi : ComputerDecorator
    {
        public WithWiFi(Computer computer):base(computer.name+" + wifi", computer) { }
        public override void Display()
        {
             Computer.Display();
        }
    }
}
