﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problem is with interface segregation
            //which i belive think i fixed
            try
            {
                string marsLocation = "Mars";
                string sunLocation = "Sun";

                Console.WriteLine($"Lets navigate to {marsLocation}");
                IPilot autoPilot = new MasterAutoPilot(new Car());
                autoPilot.Navigate(marsLocation);
                Console.WriteLine($"We are on {marsLocation} \r\n");

                Console.WriteLine($"Lets navigate to {sunLocation}");
                autoPilot = new CommonAutoPilot(new Train());
                autoPilot.Navigate(sunLocation);
                Console.WriteLine($"We are on {sunLocation} \r\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Navigation failed, because {ex}");
            }

            Console.ReadLine();
        }
    }
}
