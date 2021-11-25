using System;

namespace Task3_State
{
    class Program
    {
        static void Main(string[] args)
        {
            SportsmanState sportsmanState = new Walk();
            Sportsman sportsman = new Sportsman(sportsmanState);

            sportsman.Relax();
            sportsman.IncreaseExerciseIntensity();
            sportsman.IncreaseExerciseIntensity();
            sportsman.IncreaseExerciseIntensity();
            sportsman.Relax();
        }
    }
}
