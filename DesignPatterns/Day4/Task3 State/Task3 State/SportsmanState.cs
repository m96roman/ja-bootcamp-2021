using System;
using System.Collections.Generic;
using System.Text;

namespace Task3_State
{
    abstract class SportsmanState
    {
        public abstract void ToRun(Sportsman man);

        public abstract void ToWalk(Sportsman man);

        public abstract void ToStay(Sportsman man);
    }
}
