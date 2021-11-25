using System;
using ConsoleApp1.Interfaces;
using ConsoleApp1.Models;

namespace ConsoleApp1
{
    public class Email : IMessage
    {
        public void Send(Message message)
        {
            Console.WriteLine($"Message: {message.MessageBody}");
            Console.WriteLine("Message sent by post");
        }
    }
}
