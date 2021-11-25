using System;
using ConsoleApp1.Interfaces;
using ConsoleApp1.Models;

namespace ConsoleApp1
{
    public class Dove : IOldFashionMessage
    {
        public void KickTheBird(Message message)
        {
            Console.WriteLine($"Message: {message.MessageBody}");
            Console.WriteLine("Message sent by dove");
        }
    }
}
