using System;

namespace Task2
{
    public class Train : IDrivableLinear
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
