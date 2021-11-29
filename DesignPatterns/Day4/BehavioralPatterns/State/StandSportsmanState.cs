using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    internal class StandSportsmanState : ISportsmanState
    {
        public void IncreaseExerciseIntensity(Sportsman sportsman)
        {
            Console.WriteLine("Walk");

            sportsman.State = new WalkSportsmanState();
        }

        public void Relax(Sportsman sportsman)
        {
            Console.WriteLine("I will stand a little bit more");
        }
    }
}
