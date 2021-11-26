using System;
using ConsoleApp3.Interfaces;

namespace ConsoleApp3.States
{
    public class StandState : ISportsmanState
    {
        public void IncreaseExerciseIntensity(Sportsman sportsman)
        {
            Console.WriteLine("Wolking");
            sportsman.State = new WalkState();
        }

        public void Relax(Sportsman sportsman)
        {
            Console.WriteLine("Continue standing");
        }
    }
}
