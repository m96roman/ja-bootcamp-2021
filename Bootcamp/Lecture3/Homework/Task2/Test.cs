using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class Test
    {
        public int Id { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }

        public Test(int id, string question, string answer)
        {
            Id = id;
            Question = question;
            Answer = answer;
        }

        public virtual void Print()
        {
            Console.WriteLine(Question);
        }
    }
}
