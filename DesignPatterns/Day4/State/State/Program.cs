using State.StateFolder;
using System;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new Sportsman(new Stand());            

            context.IncreaseExerciseIntensity();
            context.IncreaseExerciseIntensity();
            context.Relax();
        }
    }
}
