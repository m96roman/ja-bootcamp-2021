namespace DIvanyshyn_5.Task_4
{
    public abstract class Package
    {
        protected Package(int size, string title, string recepient)
        {
            Size = size;
            Title = title;
            Recepient = recepient;
        }

        public int Size { get; private set; }

        public string Title { get; private set; }

        public string Recepient { get; private set; }
    }
}
