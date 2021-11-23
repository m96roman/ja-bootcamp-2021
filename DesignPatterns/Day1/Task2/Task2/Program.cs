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
            try
            {
                string marsLocation = "Mars";
                string sunLocation = "Sun";

                IDrivable car = new Car();
                ITrain train = new Train();
                
                Console.WriteLine($"Lets navigate to {marsLocation}");
                AutoPilot autoPilot = new AutoPilot();
                autoPilot.Navigate(marsLocation, car);
                Console.WriteLine($"We are on {marsLocation} \r\n");

                Console.WriteLine($"Lets navigate to {sunLocation}");
                autoPilot = new AutoPilot();
                autoPilot.Navigate(sunLocation, train);
                Console.WriteLine($"We are on {sunLocation} \r\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Navigation failed, because {ex}");
            }
            Console.ReadLine();

            // Task violates Interface segragation principle since Train doesn't have to implement methods it's not using
            // Also, after segragating Navigate method to make it mutable so we can satisfy Liskove Substitution Principle, 
        }
    }
}
