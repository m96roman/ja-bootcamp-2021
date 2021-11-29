using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    internal class Sportsman
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
