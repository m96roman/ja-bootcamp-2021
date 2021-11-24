namespace AdapterPattern
{
    class CleverDoveFarm : IMessage
    {
        private IOldFashionMessage oldFashionMessage;

        public CleverDoveFarm(IOldFashionMessage oldFashionMessage)
        {
            this.oldFashionMessage = oldFashionMessage;
        }

        public void Send(string text)
        {
            oldFashionMessage.KickTheBird(text);
        }
    }
}
