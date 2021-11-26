using System;
using ConsoleApp3.Interfaces;

namespace ConsoleApp3.States
{
    public class WalkState : ISportsmanState
    {
        public void IncreaseExerciseIntensity(Sportsman sportsman)
        {
            Console.WriteLine("Start run");
            sportsman.State = new RunState();
        }

        public void Relax(Sportsman sportsman)
        {
            Console.WriteLine("Decrease temp walk to stand");
            sportsman.State = new StandState();
        }
    }
}
