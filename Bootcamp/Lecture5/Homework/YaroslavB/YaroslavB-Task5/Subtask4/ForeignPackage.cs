namespace YaroslavB_Task5
{
    class ForeignPackage : Package
    {
        public string SenderCountry { get; set; }

        public ForeignPackage(string size, string title, string recipient)
        {
            Size = size;
            Title = title;
            Recipient = recipient;
        }
    }
}

