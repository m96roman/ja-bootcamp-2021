using System;
using ConsoleApp2.Interfaces;

namespace ConsoleApp2
{
    public class Truck : IVehicle
    {
        public void GoForward()
        {
            Console.WriteLine("Truck going forward.");
        }

        public void TurnLeft()
        {
            Console.WriteLine("Truck turns left.");
        }

        public void TurnRight()
        {
            Console.WriteLine("Truck turns right.");
        }

        public void GoBackward()
        {
            Console.WriteLine("Truck backing up.");
        }
    }
}
