using System;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            SportsmanState sportsmanState = new SportsmanWalk();
            Sportsman sportsman = new Sportsman(sportsmanState);
            sportsman.IncreaseExerciseIntensity();
            sportsman.Relax();
            sportsman.Relax();

        }
    }
}
