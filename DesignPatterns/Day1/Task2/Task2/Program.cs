using System;
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
            //Liskov substitute principle is violated, so we need to use code segregation principle
            try
            {
                string marsLocation = "Mars";
                string sunLocation = "Sun";
                
                Console.WriteLine($"Lets navigate to {marsLocation}");
                AutoPilotBase autoPilotBase = new AutoPilotBase(new Train());
                autoPilotBase.Navigate(marsLocation);
                Console.WriteLine($"We are on {marsLocation} \r\n");



                Console.WriteLine($"Lets navigate to {marsLocation}");
                AutoPilot autoPilot = new AutoPilot(new Car());
                autoPilot.Navigate(marsLocation);
                Console.WriteLine($"We are on {marsLocation} \r\n");


                Console.WriteLine($"Lets navigate to {marsLocation}");
                autoPilot = new AutoPilot(new Truck());
                autoPilot.Navigate(marsLocation);
                Console.WriteLine($"We are on {marsLocation} \r\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Navigation failed, because {ex}");
            }
            Console.ReadLine();
        }
    }
}
