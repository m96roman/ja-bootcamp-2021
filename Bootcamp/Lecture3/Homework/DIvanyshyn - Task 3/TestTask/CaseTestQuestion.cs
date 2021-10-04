namespace DIvanyshyn___Task_3
{
    public class CaseTestQuestion : TestQuestion
    {

        public CaseAnswer[] testAnswers;
        public int rightAnswer;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="testAnswers">answers</param>
        /// <param name="questionString">Question itself</param>
        public CaseTestQuestion(CaseAnswer[] testAnswers, string questionString) : base(questionString)
        {
            this.testAnswers = testAnswers;
        }

        /// <summary>
        /// Asks a question with specified answers and parameters
        /// </summary>
        /// <param name="questionIndex">number of question</param>
        /// <returns>result of answer</returns>
        internal override bool AskHimself(int questionIndex)
        {
            base.PrintQuestionName(questionIndex);

            for (int i = 0; i < testAnswers.Length; i++)
            {
                System.Console.WriteLine(testAnswers[i].GetAnswerStr(i + 1));
            }
            var num = ReadNumber(i => i <= testAnswers.Length && i >= 1, " number of an answer for question");

            return testAnswers[num - 1].IsRight;
        }

        //I had to reuse but dont want to touch dependencies

    }
}