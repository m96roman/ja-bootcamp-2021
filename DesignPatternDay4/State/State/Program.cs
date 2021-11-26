using System;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            string actionRun = "run";
            string actionWalk = "walk";
            string actionStand = "stand";
            
            Sportsman runningSportsman = new Sportsman(new Relax(actionRun));
            Sportsman walkingSportsman = new Sportsman(new Relax(actionWalk));
            Sportsman standingSportsman = new Sportsman(new Relax(actionStand));

            Console.WriteLine("------Start form running-----");
            runningSportsman.RequesteChange();
            runningSportsman.RequesteChange();
          
            Console.WriteLine("------Start form walking-----");
            walkingSportsman.RequesteChange();
            walkingSportsman.RequesteChange();
           
            Console.WriteLine("------Start form standing-----");
            standingSportsman.RequesteChange();
            standingSportsman.RequesteChange();
        }
    }
}

