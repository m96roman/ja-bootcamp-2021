using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Interfaces
{
    public interface IVehicle : IRail
    {
        void TurnLeft();
        void TurnRight();
    }
}
