using System;
using ConsoleApp3.Interfaces;

namespace ConsoleApp3.States
{
    public class RunState : ISportsmanState
    {
        public void IncreaseExerciseIntensity(Sportsman sportsman)
        {
            Console.WriteLine("We already run!");
        }

        public void Relax(Sportsman sportsman)
        {
            Console.WriteLine("Decrease run temp to walk temp");
            sportsman.State = new WalkState();
        }
    }
}
