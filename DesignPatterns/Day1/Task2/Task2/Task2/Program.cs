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

            string marsLocation = "Mars";
            string sunLocation = "Sun";

            Console.WriteLine($"Lets navigate to {marsLocation}");
            Car universeCar = new Car();
            universeCar.Navigate(marsLocation);
            Console.WriteLine($"We are on {marsLocation} \r\n");

            Console.WriteLine($"Lets navigate to {sunLocation}");
            Train interPlanet = new Train();
            interPlanet.Navigate(sunLocation);
            Console.WriteLine($"We are on {sunLocation} \r\n");

            Console.ReadLine();
        }
    }
}
//       Interface segregation principle
// In the given example there previously was a Train class which extended
// IDravable interface, but did not implemented all it`s methods.
//
//       Liskov substitute principle
// After creating classes which extend two different interfaces, there became impossible to
// use AutoPilot class without the checking of class type. That`s why method Navigate has been made abstract
// and overridden with proper implementation in those different classes.