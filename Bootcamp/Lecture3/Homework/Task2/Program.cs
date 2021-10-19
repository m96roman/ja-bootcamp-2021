using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            var yesNoAnswers = new string[] { "Yes", "No" };

            // first type of questions
            CaseTest test1Just = new CaseTest(1, "Can you see Mars from your window?", "No", yesNoAnswers);
            CaseTest test2Just = new CaseTest(1, "Does coffee grow in Brazil?", "Yes", yesNoAnswers);
            CaseTest test3Just = new CaseTest(1, "Google it is product company?", "Yes", yesNoAnswers);
            test1Just.Print();
            test2Just.Print();
            test3Just.Print();

            //second type of questions
            JustTest test1Case = new JustTest(1, "Can you see Mars from your window?", "No");
            JustTest test2Case = new JustTest(1, "Does coffee grow in Brazil?", "Yes");
            JustTest test3Case = new JustTest(1, "Google it is product company?", "Yes");
            test1Case.Print();
            test2Case.Print();
            test3Case.Print();
        }
    }
}
