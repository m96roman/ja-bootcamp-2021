using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class SportsmanRun : SportsmanState
    {
        public override void Run(Sportsman sportsman)
        {
            Console.WriteLine("Run");
            
        }

        public override void Stand(Sportsman sportsman)
        {
            Console.WriteLine("Stand");
          //  sportsman.State = new SportsmanWalk();

        }

        public override void Walk(Sportsman sportsman)
        {
            Console.WriteLine("Walk");
          //  sportsman.State = new SportsmanRun();
        }
    }
}
