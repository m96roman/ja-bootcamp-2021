using System;

namespace AdapterPattern
{
    class Email : IMessage
    {
        public void Send(string text)
        {
            Console.WriteLine($"message {text}");
            Console.WriteLine("message sent by post");
        }
    }
}
