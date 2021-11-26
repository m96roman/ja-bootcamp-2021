using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace State
{
    class Relax : SportsmansState
    {
        string actionType;
        public Relax(string action)
        {
            this.actionType = action;
        }
        public override void ChangeAction(Sportsman sportsman)
        {
            if (actionType == "run")
            {
                Console.WriteLine("Stop running, start walking.");
                actionType = "walk";
            }
            else if (actionType == "walk")
            {
                Console.WriteLine("Stop walking, start standing.");
                actionType = "stand";
            }
            else if (actionType == "stand")
            {
                Console.WriteLine("Continue standing.");
            }

            sportsman.State = new Exercise(actionType);
        }
    }
}
