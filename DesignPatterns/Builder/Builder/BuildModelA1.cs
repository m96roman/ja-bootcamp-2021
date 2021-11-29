using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    class BuildModelA1 : IBuilder
    {
        Models a1model = new A1model();

        public void Engine(double volume)
        {
            a1model.Build($"Building engine with {volume} volume");
        }

        public void SeatHeater(bool heaterPresence)
        {
            string check = "with";
            if (!heaterPresence)
            {
                check = "without";
            }

            a1model.Build($"Building seats with {check}");
        }

        public string Success()
        {
            return "A1 model was build successfully";
        }

        public void Wheels(int size)
        {
            a1model.Build($"Building wheels with disk diamter {size}");
        }
    }
}
