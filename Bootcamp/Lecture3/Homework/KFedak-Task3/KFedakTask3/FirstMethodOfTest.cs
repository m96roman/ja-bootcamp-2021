using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFedakTask3
{
    class FirstMethodOfTest : Test
    {
        public FirstMethodOfTest(string question,string answear) : base(question,answear) {}
        public override void Print()
        {
            base.Print();
            Console.WriteLine("Write your answear:");
            var userAnswear = Console.ReadLine();
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
