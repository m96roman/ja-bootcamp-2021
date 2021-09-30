using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFedakTask3
{
    class SecondMethode : Test
    {
        public string[] answears { get; set; }

        public SecondMethode(Question question, string[] answears) : base(question)
        {
            this.answears=answears;
        }

        public override void Print()
        {
            base.Print();

            for (int i = 0; i < answears.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {answears[i]}");
            }

            Console.WriteLine("Write the number of answear:");
            var userAnswear = answears[int.Parse(Console.ReadLine())-1];
            base.IfCorrect(userAnswear);
        }
    }
}
