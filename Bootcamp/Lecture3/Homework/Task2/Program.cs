using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            var YesNoAnswers = "Yes No".Split(" ");

            //created tests
            Test test1 = new Test(1, "Can you see Mars from your window?", "No");
            Test test2 = new Test(1, "Does coffee grow in Brazil?", "Yes");
            Test test3 = new Test(1, "Google it is product company?", "Yes");

            // first type of questions
            JustTest test1Just = new JustTest(1, test1.Question, test1.Answer, YesNoAnswers);
            JustTest test2Just = new JustTest(1, test2.Question, test2.Answer, YesNoAnswers);
            JustTest test3Just = new JustTest(1, test3.Question, test3.Answer, YesNoAnswers);
            test1Just.Print();
            test2Just.Print();
            test3Just.Print();

            //second type of questions
            CaseTest test1Case = new CaseTest(1, test1.Question, test1.Answer);
            CaseTest test2Case = new CaseTest(1, test2.Question, test2.Answer);
            CaseTest test3Case = new CaseTest(1, test3.Question, test3.Answer);
            test1Case.Print();
            test2Case.Print();
            test3Case.Print();
        }
    }
}
