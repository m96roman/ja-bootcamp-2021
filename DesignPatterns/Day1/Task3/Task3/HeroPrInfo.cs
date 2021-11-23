using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class HeroPrInfo : IHeroPrInfo
    {
        public string City { get; set; }
        public string Street { get; set; }
        public string PostIndex { get; set; }
        public string Country { get; set; }

        public void SendGreeting(string text)
        {
            string destination = $"{PostIndex} {Street}, {City}, {Country}";
            Console.WriteLine($"Sending letter with context '{text}' to destination {destination}");
        }
    }
}
