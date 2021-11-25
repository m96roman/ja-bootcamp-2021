using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Email : IMessage
    {
        public void Send(string text)
        {
            Console.WriteLine($"Message {text}");
            Console.WriteLine($"Message was send by E-mail");
        }
    }
}
