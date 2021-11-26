using System;
using ConsoleApp2.Interfaces;

namespace ConsoleApp2
{
    public class Train : IRail
    {
        public void GoBackward()
        {
            Console.WriteLine("Train backing up.");
        }

        public void GoForward()
        {
            Console.WriteLine("Train going forward.");
        }
    }
}
