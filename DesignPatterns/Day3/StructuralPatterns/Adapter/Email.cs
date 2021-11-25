using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
   internal class Email:IMessage
    {
        public void Send(string text)
        {
            Console.WriteLine($"message{text}");
            Console.WriteLine($"message send by email");
        }
    }
}
