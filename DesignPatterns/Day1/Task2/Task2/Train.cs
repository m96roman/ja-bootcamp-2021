using System;

namespace Task2
{
    public class Train : IDrivable
    {
        public void GoForward()
        {
            Console.WriteLine("Train going forward.");
        }

        public void TurnLeft()
        {
            throw new NotSupportedException();
        }

        public void TurnRight()
        {
            throw new NotSupportedException();
        }

        public void GoBackward()
        {
            Console.WriteLine("Train backing up.");
        }
    }
}
