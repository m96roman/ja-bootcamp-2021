using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    class BuildModelA2 : IBuilder
    {
        Models a2model = new A2model();

        public void Engine(double volume)
        {
            a2model.Build($"Building engine with {volume} volume");
        }

        public void SeatHeater(bool heaterPresence)
        {
            string check = "with";
            if (!heaterPresence)
            {
                check = "without";
            }

            a2model.Build($"Building seats with {check}");
        }

        public void Wheels(int size)
        {
            a2model.Build($"Building wheels with disk diamter {size}");
        }
        public string Success()
        {
            return "A2 model was build successfully";
        }

    }
}
