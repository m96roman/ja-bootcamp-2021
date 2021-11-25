namespace Task1_Adapter
{
    class MessageAdapter : IMessage
    {
        private IOldFashionMessage _obsoleteMethod;

        public void Send(string text)
        {
            _obsoleteMethod.KickTheBird(text);
        }

        public MessageAdapter(IOldFashionMessage​ obsoleteMethod)
        {
            _obsoleteMethod = obsoleteMethod;
        }
    }
}