using System;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            ISportsman water = new Brain(new WalkingSportsman());
            water.IncreaseExerciseIntensity();
            water.Relax();
            water.Relax();
            Console.Read();
        }
    }
}
