using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    public interface ISportsmanState
    {
        void IncreaseExerciseIntensity(Sportsman sportsman);

        void Relax(Sportsman sportsman);
    }
}
