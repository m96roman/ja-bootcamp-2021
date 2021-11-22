using System;

namespace Task2
{
    public class Train : IDrivableForwardAndBackward
    {
        public void GoForward()
        {
            Console.WriteLine("Train going forward.");
        }     
        public void GoBackward()
        {
            Console.WriteLine("Train backing up.");
        }
    }
}
