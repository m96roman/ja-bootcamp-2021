using System;
using System.Collections.Generic;
using System.Text;

namespace Task3_State
{

    class Sportsman
    {
        public SportsmanState State { get; set; }
        public Sportsman(SportsmanState sportsman)
        {
            State = sportsman;
        }

        public void IncreaseExerciseIntensity()
        {
            if (State.GetType() == typeof(Stay))
            {
                State.ToWalk(this);
                State = new Walk();
            }
            else if (State.GetType() == typeof(Walk))
            {
                State.ToRun(this);
                State = new Run();
            }
            else if (State.GetType() == typeof(Run))
            {
                Console.WriteLine("Sportsman is runing");
            }
        }

        public void Relax()
        {
            if (State.GetType() == typeof(Run))
            {
                State.ToWalk(this);
                State = new Walk();
            }
            else if (State.GetType() == typeof(Walk))
            {
                State.ToStay(this);
                State = new Stay();
            }
            else if (State.GetType() == typeof(Stay))
            {
                Console.WriteLine("Spotsman stays");
            }
        }
    }
}
