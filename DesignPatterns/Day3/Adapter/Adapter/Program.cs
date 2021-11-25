using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            MessageService messageService = new MessageService();

            var message = new Email();

            messageService.SendMessage(message, "Hello World");

            var message2 = new Dove();

            messageService.SendMessage(new Adapter(message2), "Hello bird");
        }
    }
}
