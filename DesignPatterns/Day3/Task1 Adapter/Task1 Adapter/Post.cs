using System;
using System.Collections.Generic;
using System.Text;

namespace Task1_Adapter
{
    interface Post: IMessage
    {
       public void Send(string text)
        {
            Console.WriteLine(@$"Message: {text}");
            Console.WriteLine("Message is sent by post");

            
        }
    }
}
