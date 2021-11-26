using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    public class Sportsman
    {
        public ISportsmanState State { get; set; }
        public Sportsman(ISportsmanState sportsmanState)
        {
            State = sportsmanState;
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
