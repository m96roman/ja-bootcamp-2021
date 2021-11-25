using System;
using System.Collections.Generic;
using System.Text;

namespace Task3_State
{
    class Stay: SportsmanState
    {
        public override void ToRun(Sportsman sportsman)
        {
            Console.WriteLine("Spotsman Runs");
        }

        public override void ToStay(Sportsman sportsman)
        {
            Console.WriteLine("Spotsman Stays");
        }

        public override void ToWalk(Sportsman sportsman)
        {
            Console.WriteLine("Spotsman Walks");

        }
    }
}
