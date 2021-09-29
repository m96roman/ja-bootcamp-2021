using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IuriiPlyskaLect3
{
    public class History
    {
        public int Id { get; set; }

        public string Answer { get; set; }

        public string Question { get; set; }

        public string CorrectAnswer { get; set; }

        public string A { get; set; }
        public string B { get; set; }
        public string C { get; set; }
        public string D { get; set; }

        //public static void Print(History history)
        //{
        //    Console.WriteLine("History test" + history.Question);
        //}

        public virtual string Print()
        {
            return string.Empty;
        }
    }

    public class HistoryCaseQuestion : History
    {
        public override string Print()
        {
            Console.WriteLine(Question);

            Console.WriteLine("Please choose correct an answer. Type only A, or B, or C, or D. If was inputed something else an answer will be not correct");

            Console.WriteLine($"A: {A}  B:{B}");

            Console.WriteLine($"C {C}   D:{D}");

            return Console.ReadLine();
        }  
    }

    public class HistoryJUST_STRQuestion : History
    {
        public override string Print()
        {
            Console.WriteLine("Please input the right an answer. There is no case sensitive for an answer...");

            return Console.ReadLine();
        } 
    }
}