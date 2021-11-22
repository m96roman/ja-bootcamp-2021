using System;

namespace Task3
{
    public class GreetingsSender : IGreetingSender
    {
        public string PostIndex { get; private set; }

        public string Street { get; private set; }

        public string City { get; private set; }

        public string Country { get; private set; }

        public void SendGreeting(string text)
        {
            string destination = $"{PostIndex} {Street}, {City}, {Country}";
            Console.WriteLine($"Sending letter with context '{text}' to destination {destination}");
        }
    }
}
