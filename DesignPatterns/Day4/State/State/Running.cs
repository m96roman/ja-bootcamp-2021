using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    class Running : ISportsmanState
    {
        public void IncreaseExerciseIntensity(Sportsman sportsman)
        {
            Console.WriteLine("Already running");
        }

        public void Relax(Sportsman sportsman)
        {
            Console.WriteLine("Starting to walk");
            sportsman.State = new Walking();            
        }
    }
}
