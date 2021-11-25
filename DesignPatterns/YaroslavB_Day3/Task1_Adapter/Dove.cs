using System;

namespace Task1_Adapter
{
    class Dove : IOldFashionMessage​
    {
        public void KickTheBird(string text)
        {
            Console.WriteLine($"повідомлення {text}");
            Console.WriteLine("повідомлення відправлене поштовим голубом");
        }
    }
}