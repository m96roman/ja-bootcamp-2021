namespace AdapterPattern
{
    class MessageService
    {
        public void SendMessage(IMessage message, string text)
        {
            message.Send(text);
        }
    }
}
