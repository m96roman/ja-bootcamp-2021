using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    class BuildModelA5 : IBuilder
    {
        Models a5model = new A5model();

        public void Engine(double volume)
        {
            a5model.Build($"Building engine with {volume} volume");
        }

        public void SeatHeater(bool heaterPresence)
        {
            string check = "with";
            if (!heaterPresence)
            {
                check = "without";
            }

            a5model.Build($"Building seats with {check}");
        }

        public void Wheels(int size)
        {
            a5model.Build($"Building wheels with disk diamter {size}");
        }

        public string Success()
        {
            return "A5 model was build successfully";
        }
    }
}
