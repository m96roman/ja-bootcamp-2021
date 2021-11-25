using System;

namespace Adapter
{
    internal class Program
    {
        private static void Main()
        {
            var text = " Hi, I am Adapter!";

            var messageService = new MessageService();

            var email = new Email();

            messageService.SendMessage(email,text);

            var dove = new Dove();

            IMessage messageDove = new MessageAdapter(dove);

            messageService.SendMessage(messageDove,text);
        }
    }
}
