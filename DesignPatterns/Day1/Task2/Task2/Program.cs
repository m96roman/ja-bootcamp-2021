using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    //Single responsibility principle was violated,
    //Interface segregation principle was violated,
    //Barbara Liskov substitution​ principle was violated,

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string marsLocation = "Mars";
                string sunLocation = "Sun";
                
                Console.WriteLine($"Lets navigate to {marsLocation}");
                AutoPilot autoPilot = new AutoPilot(new Car());
                autoPilot.Navigate(marsLocation);
                Console.WriteLine($"We are on {marsLocation} \r\n");

                Console.WriteLine($"Lets navigate to {sunLocation}");
                autoPilot = new AutoPilot(new Truck());
                autoPilot.Navigate(sunLocation);
                Console.WriteLine($"We are on {sunLocation} \r\n");

                Console.WriteLine($"Lets navigate to {sunLocation}");
                AutoPilotTrain autoPilottrain = new AutoPilotTrain(new Train());
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
