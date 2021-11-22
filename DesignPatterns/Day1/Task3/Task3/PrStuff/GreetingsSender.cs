using System;

namespace Task3
{
    public class GreetingsSender : IGreetingSender
    {
        public string PostIndex { get; set; }

        public string Street { get; set; }

        public string City { get; set; }

        public string Country { get; set; }

        public void SendGreeting(string text)
        {
            string destination = $"{PostIndex} {Street}, {City}, {Country}";
            Console.WriteLine($"Sending letter with context '{text}' to destination {destination}");
        }
    }
}
