using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Violated principles
             * ISP
             * LCP
             * OCP
             * 
             * used DI and Method injection
             */

            string marsLocation = "Mars";
            string sunLocation = "Sun";

            Console.WriteLine($"Lets navigate to {marsLocation}");
            AutoPilotVehicle autoPilotCar = new AutoPilotVehicle(new Car());
            autoPilotCar.Navigate(marsLocation);
            Console.WriteLine($"We are on {marsLocation} \r\n");


            Console.WriteLine($"We are on {sunLocation} \r\n");
            AutoPilotRail autoPilotTrain = new AutoPilotRail(new Train());
            autoPilotTrain.Navigate(sunLocation);
            Console.WriteLine($"We are on {sunLocation} \r\n");
        }
    }
}
