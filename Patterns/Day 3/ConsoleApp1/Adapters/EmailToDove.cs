using ConsoleApp1.Interfaces;
using ConsoleApp1.Models;

namespace ConsoleApp1.Adapters
{
    public class EmailToDove : IMessage
    {
        private Dove _dove;

        public EmailToDove(Dove dove)
        {
            _dove = dove;
        }

        public void Send(Message message)
        {
            _dove.KickTheBird(message);
        }
    }
}
