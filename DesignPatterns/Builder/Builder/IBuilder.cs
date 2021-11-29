using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public interface IBuilder
    {
        void Engine(double volume);
        void Wheels(int size);
        void SeatHeater(bool heaterPresence);
        string Success();
    }
}
