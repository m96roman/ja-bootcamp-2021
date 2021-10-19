using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class CaseTest : Test
    {
        public List<string> Answers = new List<string>();

        public CaseTest(int id, string question, string answer, string[] answers) : base(id, question, answer)
        {
            foreach (var item in answers)
            {
                this.Answers.Add(item);
            }
        }

        public override void Print()
        {
            base.Print();

            for (int i = 0; i < Answers.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {Answers[i]}");
            }

            Console.WriteLine("Choose number of answer:");
            var answerFromUser = Answers[int.Parse(Console.ReadLine()) - 1];

            Console.WriteLine(answerFromUser == Answer);
        }
    }
}
