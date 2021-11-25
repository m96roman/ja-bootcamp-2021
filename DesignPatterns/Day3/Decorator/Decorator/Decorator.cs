using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Decorator : IComputer
    {   
        private ComputerConfig ComputerConfig { get; set; }

        private IComputer Computer { get; set; }

        public Decorator(IComputer computer, ComputerConfig computerConfig) 
        {
            this.Computer = computer;

            this.ComputerConfig = computerConfig;
        }

        public void Info()
        {
            Console.WriteLine();
            Computer.Info();

            Console.WriteLine($"Computer has Wifi : {ComputerConfig.WifiAdapter}\nComputer has Keyboard Backlight : {ComputerConfig.KeyboardBacklight}");
        }
    }
}
