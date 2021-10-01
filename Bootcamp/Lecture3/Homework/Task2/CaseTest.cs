using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class CaseTest : Test
    {
        public CaseTest(int id, string question, string answer) : base(id, question, answer) { }

        public override void Print()
        {
            base.Print();

            Console.WriteLine("Your answer here:");
            var answerFromUser = Console.ReadLine();

            if (answerFromUser == Answer)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
