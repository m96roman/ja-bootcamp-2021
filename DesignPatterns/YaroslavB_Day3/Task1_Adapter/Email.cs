using System;

namespace Task1_Adapter
{
    class Email : IMessage​
    {
        public void Send(string text)
        {
            Console.WriteLine($"повідомлення {text}");
            Console.WriteLine("повідомлення відправлене поштою");
        }
    }
}