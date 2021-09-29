using System.Collections.Generic;
using System.Linq;

namespace DIvanyshyn___Task_3
{
    public class Test
    {
        public List<TestQuestion> TestQuestions { get; private set; }
        public string Name { get; private set; }

        public Test(List<TestQuestion> testQuestions, string name)
        {
            TestQuestions = testQuestions;
            Name = name;
        }

        public void DoTest()
        {
            System.Console.WriteLine(new string('~', 20));
            System.Console.WriteLine($"Starting test with name: {this.Name}");
            System.Console.WriteLine(new string('~', 20));

            List<KeyValuePair<int, bool>> results = new List<KeyValuePair<int, bool>>();
            for (int i = 0; i < TestQuestions.Count; i++)
            {
                results.Add(new KeyValuePair<int, bool>(i, TestQuestions[i].AskHimself(i + 1)));
                System.Console.WriteLine(new string('~', 20));
            }

            //System.Console.WriteLine(new string('~', 20));

            System.Console.WriteLine($"Test result is - {results.Where(r => r.Value).Count()}/{results.Count}");

        }
    }
}