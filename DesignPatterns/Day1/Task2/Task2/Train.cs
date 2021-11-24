using System;

namespace Task2
{
    public class Train : IDrivable
    {
        public override void GoForward()
        {
            Console.WriteLine("Train going forward.");
        }
        
        public override void GoBackward()
        {
            Console.WriteLine("Train backing up.");
        }
    }
}
