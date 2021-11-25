using System;

namespace State
{
    internal class StandingSportsman : Sportsman
    {
        public override void IncreaseExerciseIntensity()
        {
            Console.WriteLine("Walking");
            this.brain.SetState(new WalkingSportsman());
        }

        public override void Relax()
        {
            Console.WriteLine("Stay some more");
        }

    }
}
