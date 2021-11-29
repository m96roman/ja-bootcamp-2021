using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    internal class WalkSportsmanState : ISportsmanState
    {
        public void IncreaseExerciseIntensity(Sportsman sportsman)
        {
            Console.WriteLine("Start to run");

            sportsman.State = new RunSportsmanState();
        }

        public void Relax(Sportsman sportsman)
        {
            Console.WriteLine("Stop to relax");

            sportsman.State = new StandSportsmanState();
        }
    }
}
