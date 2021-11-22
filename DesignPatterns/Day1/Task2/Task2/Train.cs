using System;

namespace Task2
{
    public class Train : IMoveStraight
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
