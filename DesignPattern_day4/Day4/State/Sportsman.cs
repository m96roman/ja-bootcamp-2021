using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class Sportsman
    {
        public SportsmanState State { get; set; }
        public Sportsman(SportsmanState ws)
        {
            State = ws;
        }
        public void IncreaseExerciseIntensity()
        {
            if (State.GetType()==typeof(SportsmanStand))
            {
              
                State.Walk(this);
                State = new SportsmanWalk();
            }
            else if (State.GetType() == typeof(SportsmanWalk))
            {
               
                State.Run(this);
                State = new SportsmanRun();
            }
            else if (State.GetType() == typeof(SportsmanRun))
            {
                Console.WriteLine("Imruning");
            }
        }
        public void Relax()
        {
            if (State.GetType() == typeof(SportsmanRun))
            {
               
                State.Walk(this);
                State = new SportsmanWalk();
            }
            else if (State.GetType() == typeof(SportsmanWalk))
            {
               
                State.Stand(this);
                State = new SportsmanStand();
            }
            else if (State.GetType() == typeof(SportsmanStand))
            {
                Console.WriteLine("standing");
            }
        }
    }
}
