using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFedakTask3
{
    class SecondMethode : Test
    {
        public List<string> answears = new List<string>();

        public SecondMethode(string question, string answear, string[] answears) : base(question, answear)
        {
            foreach (var ans in answears)
            {
                this.answears.Add(ans);
            }
        }

        public override void Print()
        {
            base.Print();
            for (int i = 0; i < answears.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {answears[i]}");
            }
            Console.WriteLine("Write the number of answear:");
            var userAnswear = answears[int.Parse(Console.ReadLine())-1];
            if (userAnswear == Answear)
            {
                Console.WriteLine("Correct!!!");
            }
            else
            {
                Console.WriteLine("Fail!!!");
            }
        }
    }
}
