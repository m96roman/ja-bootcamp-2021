namespace DIvanyshyn___Task_3
{
    public class CaseAnswer
    {
        private readonly string answerStr;

        public CaseAnswer(string answerStr, bool isRight)
        {
            this.answerStr = answerStr;
            IsRight = isRight;
        }

        internal bool IsRight { get; private set; }



        internal string GetAnswerStr(int i)
        {
            return $"{i}) {answerStr}";
        }
    }
}