using System;

namespace DIvanyshyn___Task_3
{
    /// <summary>
    /// Class that represents question in test
    /// </summary>
    public abstract class TestQuestion
    {
        private string questionString;

        protected TestQuestion(string questionString)
        {
            this.questionString = questionString;
        }

        /// <summary>
        /// Asks question to console and print answer
        /// </summary>
        /// <param name="questionIndex">number of Question</param>
        /// <returns>result of question</returns>
        internal abstract bool AskHimself(int questionIndex);
        public static int ReadNumber(Predicate<int> condition, string name = "integer number")
        {
            int num = 0;
            Console.WriteLine($"Enter a valid {name}: ");
            bool result = false;
            do
            {
                Console.WriteLine("Write valid number!");
                result = int.TryParse(Console.ReadLine(), out num);
               
            }
            while (!result || !condition(num));

            return num;
        }

        internal void PrintQuestionName(int questionIndex)
        {
            System.Console.WriteLine($"Question No {questionIndex} {questionString}");
        }
    }
}