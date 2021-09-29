using System;
using System.Collections.Generic;
using System.Text;

namespace Pylat___Task_3
{
    public abstract class Test
    {
        public string question { get; set; }
        public string answer { get; set; }
        public Test(string question, string answer)
        {
            this.answer = answer;
            this.question = question;
        }
        public abstract void Question();
        public abstract void Answer();
    }

    public class Case : Test
    {
        public string getAnswer;
        public Case(string question = null, string answer= "" ) : base(question, answer)
        {
           
           

        }
        public override void Question()
        {
            Console.WriteLine("What do you think about it?");

        }

        public override void Answer()
        {
            Console.WriteLine($"Your answer is: {answer}");
        }
    }

    public class Just_Str: Test
    {

        public Just_Str(string question = null, string answer = ""):base(question,answer)
        {

        }

        public override void Question()
        {
            Console.WriteLine(@"Is it good for you?
yes? or no?");

        }

        public override void Answer()
        {
            Console.WriteLine($@"Your answer is: {answer}");
        }



    }

    public class Task2
    {
        public static void doTask2()
        {
            // 1 class /////////////////////////

            /* Case case1 = new Case();
            case1.Question();
            case1.answer = Console.ReadLine();
            case1.Answer();*/

            // 2 class /////////////////////////

            Just_Str just_str = new Just_Str();
            just_str.Question();
            just_str.answer = Console.ReadLine();
            just_str.Answer();
        }


    }
}
