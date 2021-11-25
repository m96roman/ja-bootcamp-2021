using System;

namespace State
{
    internal class WalkingSportsman : Sportsman
    {
        public override void IncreaseExerciseIntensity()
        {
            Console.WriteLine("Starting running");
            this.brain.SetState(new RunningSportsman());
        }

        public override void Relax()
        {
            Console.WriteLine("Stop to take a rest");
            this.brain.SetState(new StandingSportsman());
        }
    }
}
