using System;
using ConsoleApp5.Abstracts;

namespace ConsoleApp5.Captains
{
    public class LvivCaptain : Captain
    {
        public LvivCaptain(Mediator mediator) : base(mediator) { }

        public override void Notify(string message)
        {
            Console.WriteLine($"Lviv captain receive message {message}");
        }
    }
}
