using System;

namespace State
{
    internal class RunningSportsman : Sportsman
    {
        public override void IncreaseExerciseIntensity()
        {
            Console.WriteLine("We already running");
        }

        public override void Relax()
        {
            Console.WriteLine("Slower down to walking");
            this.brain.SetState(new WalkingSportsman());
        }
    }
}
