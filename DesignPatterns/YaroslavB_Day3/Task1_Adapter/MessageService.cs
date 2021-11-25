namespace Task1_Adapter
{
    class MessageService​
    {
        public void SendMessage(IMessage message)
        {
            message.Send("Hello!");
        }
    }
}