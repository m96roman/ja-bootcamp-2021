using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    class Standing : ISportsmanState
    {
        public void IncreaseExerciseIntensity(Sportsman sportsman)
        {
            Console.WriteLine("Starting to run");
            sportsman.State = new Running();
        }

        public void Relax(Sportsman sportsman)
        {
            Console.WriteLine("Resting right now");
        }
    }
}
