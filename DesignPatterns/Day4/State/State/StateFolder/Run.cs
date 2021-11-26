using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.StateFolder
{
     class Run : State
     {
        public override void IncreaseExerciseIntensity(Sportsman sportsman)
        {
            Console.WriteLine("We already running");
        }
        public override void Relax(Sportsman sportsman)
        {
            Console.WriteLine("Stop running go for a walk");
            sportsman._state = new Walk();
        }
     }
}
