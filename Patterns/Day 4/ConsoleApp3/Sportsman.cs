using ConsoleApp3.Interfaces;

namespace ConsoleApp3
{
    public class Sportsman
    {
        public ISportsmanState State { get; set; }

        public Sportsman(ISportsmanState state)
        {
            State = state;
        }

        public void IncreaseExerciseIntensity()
        {
            State.IncreaseExerciseIntensity(this);
        }

        public void Relax()
        {
            State.Relax(this);
        }
    }
}
