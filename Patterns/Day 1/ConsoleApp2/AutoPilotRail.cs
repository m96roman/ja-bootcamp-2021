using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp2.Interfaces;

namespace ConsoleApp2
{
    public class AutoPilotRail : IAutoPilot
    {
        IRail _rail;

        public AutoPilotRail(IRail rail)
        {
            _rail = rail;
        }

        public void Navigate(string destination)
        {
            Console.WriteLine($"Navigate to destination {destination}");

            _rail.GoForward();
            _rail.GoBackward();
        }
    }
}
