using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFedakTask3
{
    class FirstMethodOfTest : Test
    {
        public FirstMethodOfTest(Question question) : base(question) { } 
        
        public override void Print()
        {
            base.Print();
            Console.WriteLine("Write your answear:");
            var userAnswear = Console.ReadLine();
            base.IfCorrect(userAnswear);
        }
    }
}
