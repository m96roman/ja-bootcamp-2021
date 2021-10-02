namespace DIvanyshyn_5.Task_4
{
    public class ForeignPackage : Package
    {
        public ForeignPackage(int size, string title, string recepient, string senderCountry) : base(size, title, recepient)
        {
            SenderCountry = senderCountry;
        }

        public string SenderCountry { get; private set; }

    }
}
