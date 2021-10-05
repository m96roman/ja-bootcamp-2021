using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class JustTest : Test
    {
        public JustTest(int id, string question, string answer) : base(id, question, answer) { }

        public override void Print()
        {
            base.Print();

            Console.WriteLine("Your answer here:");
            var answerFromUser = Console.ReadLine();

            Console.WriteLine(answerFromUser == Answer);
        }
    }
}
