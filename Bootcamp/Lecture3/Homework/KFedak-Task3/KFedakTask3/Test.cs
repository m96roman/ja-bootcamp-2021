using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFedakTask3
{
    class Test
    {
        public readonly string Id= Guid.NewGuid().ToString("N");
        public Question Question { get; set; }

        public Test(Question question)
        {
            Question = question;
        }

        public virtual void Print()
        {
           Console.WriteLine(Question.Questions);
        }

        public void IfCorrect(string userAnswear)
        {
            if (userAnswear == Question.Answear)
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
