using System;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            Sportsman sportsman = new Sportsman(new Running());
            sportsman.IncreaseExerciseIntensity();
            sportsman.Relax();
            sportsman.Relax();
            Console.Read();
        }
    }
}
