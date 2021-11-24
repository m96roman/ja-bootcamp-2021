using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            MessageService message = new MessageService();
            Email email = new Email();

            message.SendMessage(email);

            Dove dove = new Dove();
            IMessage doveMessage = new EmailToDoveAdapter(dove);

            message.SendMessage(doveMessage);

        }
    }
}
