using ConsoleApp1.Models;
using ConsoleApp1.Interfaces;
using ConsoleApp1.Adapters;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Adapter */

            // create message
            Message message = new Message() { MessageBody = "Hello!" };

            MessageService service = new MessageService(message);
            Email email = new Email();

            service.SendMessage(email);

            Dove dove = new Dove();

            IMessage doveToMessage = new EmailToDove(dove);
            service.SendMessage(doveToMessage);
        }
    }
}
