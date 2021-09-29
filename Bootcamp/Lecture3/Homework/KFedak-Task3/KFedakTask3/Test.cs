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
        public string Question;
        public string Answear;

        public Test(string question, string answer)
        {
            Question = question;
            Answear = answer;
        }

        public virtual void Print()
        {
            Console.WriteLine(Question);
        }
    }
}
