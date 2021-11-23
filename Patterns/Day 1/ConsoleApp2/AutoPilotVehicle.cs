﻿using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp2.Interfaces;

namespace ConsoleApp2
{
    public class AutoPilotVehicle
    {
        private IVehicle _vehicle;

        public AutoPilotVehicle(IVehicle vehicle)
        {
            _vehicle = vehicle;
        }

        public void Navigate(string destination)
        {
            Console.WriteLine($"Navigate to destination {destination}");
            _vehicle.GoForward();
            _vehicle.TurnLeft();
            _vehicle.GoBackward();
            _vehicle.TurnRight();
        }
    }
}
