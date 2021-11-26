using System;
using ConsoleApp3.States;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Sportsman sportsman = new Sportsman(new WalkState());
            sportsman.IncreaseExerciseIntensity();
            sportsman.Relax();
            sportsman.Relax();
            Console.Read();
        }
    }
}