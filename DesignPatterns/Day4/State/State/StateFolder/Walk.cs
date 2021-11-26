using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.StateFolder
{
    class Walk : State
    {
        public override void IncreaseExerciseIntensity(Sportsman sportsman)
        {
            Console.WriteLine("Stop walking go run");
            sportsman._state = new Run();
        }

        public override void Relax(Sportsman sportsman)
        {
            Console.WriteLine("Stop walking, take a rest.");
            sportsman._state = new Stand();
        }
    }
}
