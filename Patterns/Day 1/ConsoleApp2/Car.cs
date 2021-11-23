using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp2.Interfaces;

namespace ConsoleApp2
{
    public class Car : IVehicle
    {
        public void GoForward()
        {
            Console.WriteLine("Car going forward.");
        }

        public void TurnLeft()
        {
            Console.WriteLine("Car turns left.");
        }

        public void TurnRight()
        {
            Console.WriteLine("Car turns right.");
        }

        public void GoBackward()
        {
            Console.WriteLine("Car backing up.");
        }
    }
}
