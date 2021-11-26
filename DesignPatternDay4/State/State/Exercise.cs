using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class Exercise : SportsmansState
    {
        string actionType;
        public Exercise(string action)
        {
            this.actionType = action;
        }
        public override void ChangeAction(Sportsman sportsman)
        {
            if (actionType == "run")
            {
                Console.WriteLine("I already run.");
            }
            else if (actionType == "walk")
            {
                Console.WriteLine("Stop walking, start running.");
                actionType = "run";
            }
            else if (actionType == "stand")
            {
                Console.WriteLine("Stop standing, start walking.");
                actionType = "walk";
            }
          
            sportsman.State = new Relax(actionType);
        }
    }
}

