using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    interface ISportsmanState
    {
        void IncreaseExerciseIntensity(Sportsman sportsman);
        void Relax(Sportsman sportsman);
    }
}
