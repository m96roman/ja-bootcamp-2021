using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    class Walking : ISportsmanState
    {
        public void IncreaseExerciseIntensity(Sportsman sportsman)
        {
            Console.WriteLine("Start running");
            sportsman.State = new Running();
        }

        public void Relax(Sportsman sportsman)
        {
            Console.WriteLine("Standing still");
            sportsman.State = new Standing();
        }
    }
}
