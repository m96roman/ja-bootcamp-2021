using System;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            Sportsman sportsman = new Sportsman(new RunSportsmanState());
            sportsman.IncreaseExerciseIntensity();
            sportsman.Relax();
            sportsman.Relax();
            sportsman.IncreaseExerciseIntensity();
            sportsman.IncreaseExerciseIntensity();
        }
    }
}
