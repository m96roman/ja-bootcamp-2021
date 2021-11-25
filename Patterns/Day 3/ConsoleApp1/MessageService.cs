using ConsoleApp1.Interfaces;
using ConsoleApp1.Models;

namespace ConsoleApp1
{
    public class MessageService
    {
        private Message _message { get; set; }

        public MessageService(Message message)
        {
            _message = message;
        }

        public void SendMessage(IMessage message)
        {
            message.Send(_message);
        }
    }
}
