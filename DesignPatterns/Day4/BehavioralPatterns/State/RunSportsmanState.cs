using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    internal class RunSportsmanState : ISportsmanState
    {
        public void IncreaseExerciseIntensity(Sportsman sportsman)
        {
            Console.WriteLine("I am already running!");
        }

        public void Relax(Sportsman sportsman)
        {
            Console.WriteLine("Stop!Need to walk");

            sportsman.State = new WalkSportsmanState();
        }
    }
}
