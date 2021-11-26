using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class PrAction : BaseAction
    {
        public PrAction(Employee employee) : base(employee)
        {
        }
        protected void SendGreeting(string text)
        {
            string destination = $"{employee.PostIndex} {employee.Street}, {employee.City}, {employee.Country}";
            Console.WriteLine($"Sending letter with context '{text}' to destination {destination}");
        }
    }
}
