using System;

namespace DIvanyshyn___Task_3
{
    internal class StringTestQuestion : TestQuestion
    {
        public string answer;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="answer">Right answer str</param>
        /// <param name="questionString">Question itself</param>
        public StringTestQuestion(string answer, string questionString) : base(questionString)
        {
            this.answer = answer;
        }

        internal override bool AskHimself(int questionIndex)
        {

            base.PrintQuestionName(questionIndex);
            Console.WriteLine("Enter answer:");
            string input = Console.ReadLine();

            return input.Equals(answer, StringComparison.InvariantCultureIgnoreCase);
        }
    }
}