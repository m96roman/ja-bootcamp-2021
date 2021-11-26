using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.StateFolder
{
    class Stand : State
    {
        public override void IncreaseExerciseIntensity(Sportsman sportsman)
        {
            Console.WriteLine("Stop standing go for a walk");
            sportsman._state = new Walk();
        }
        public override void Relax(Sportsman sportsman)
        {
            Console.WriteLine("We are already resting");
        }
    }
}
