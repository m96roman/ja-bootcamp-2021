using System;

namespace Task3
{
    public class Hero: HumanBase
    {
        public string Alias { get; set; }
        public string Power { get; set; }
        public string PostIndex { get; set; }
        public int CurrencyCode { get; set; }


        public void SendGreeting(string text)
        {
            string destination = $"{PostIndex} {Street}, {City}, {Country}";
            Console.WriteLine($"Sending letter with context '{text}' to destination {destination}");
        }
    }
}
