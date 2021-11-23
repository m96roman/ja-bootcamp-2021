using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class PrDepartment
    {
        public void SendNewYearGreeting(Adderess heroAdderess)
        {
            SendGreeting("Happy New Year!", heroAdderess);
        }

        public void SendGreeting(string text, Adderess heroAdderess)
        {
            string destination = $"{heroAdderess.PostIndex} {heroAdderess.Street}, {heroAdderess.City}, {heroAdderess.Country}";
            Console.WriteLine($"Sending letter with context '{text}' to destination {destination}");
        }
    }
}
