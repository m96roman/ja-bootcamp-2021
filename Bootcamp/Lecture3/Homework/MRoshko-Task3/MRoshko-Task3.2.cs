namespace MRoshko_Task3
{
    using System;
    using System.Collections.Generic;

    public class Task3_2
    {
        public Task3_2(int numberOfTest)
        {
            if (numberOfTest == 1)
            {
                Case test = new Case();
                test.Print();
            }
            else if (numberOfTest == 2)
            {
                JUST_STR test = new JUST_STR();
                test.Print();
            }
        }

        public class Test
        {

            public virtual void Print()
            {

            }
        }

        public class Case : Test
        {
            private int correctAnswer = 0;
            private static int testCount = 4;
            private string[][] caseTest = new string[testCount][];

            public Case()
            {
                caseTest[0] = new string[] { "The capital of Ukraine is ?", "a)Uzhhorod", "b)Kiev", "c)Lviv", "b" };
                caseTest[1] = new string[] { "Two Four Two Zero ?", "a)2420", "b)4400", "c)2400", "d)4420", "d" };
                caseTest[2] = new string[] { "The capital of Great Britain is ?", "a)London", "b)Paris", "a" };
                caseTest[3] = new string[] { "Bananas are ?", "a)Blue", "b)Yellow", "c)Green", "b" };
            }

            public override void Print()
            {
                for (int i = 0; i < testCount; i++)
                {
                    Console.Write($"{i + 1}.");
                    for (int j = 0; j < caseTest[i].Length - 1; j++)
                    {
                        Console.Write($"{caseTest[i][j]}\n");
                    }
                    if (caseTest[i][caseTest[i].Length - 1] == Console.ReadLine())
                    {
                        correctAnswer++;
                    }

                }
                Console.WriteLine($"Count of correct answer was : {correctAnswer}");
            }

        }

        public class JUST_STR : Test
        {

            private Dictionary<int, string> justStr = new Dictionary<int, string>();
            private Dictionary<int, string> justStrAnswer = new Dictionary<int, string>();

            public JUST_STR()
            {
                justStr.Add(1, "What is your name");
                justStr.Add(2, "What is the capital of Great Britain");
                justStr.Add(3, "Who was the fifth president of Ukraine");
                justStr.Add(4, "Tell Me About Yourself");
            }

            public override void Print()
            {
                foreach (KeyValuePair<int, string> test in justStr)
                {
                    Console.Write($"{test.Key}){test.Value}?\nYour answer : ");
                    justStrAnswer.Add(test.Key, Console.ReadLine());
                }
            }
        }

    }

}


