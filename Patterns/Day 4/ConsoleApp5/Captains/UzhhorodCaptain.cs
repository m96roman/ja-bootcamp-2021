using System;
using ConsoleApp5.Abstracts;

namespace ConsoleApp5.Captains
{
    public class UzhhorodCaptain : Captain
    {
        public UzhhorodCaptain(Mediator mediator) : base(mediator) { }

        public override void Notify(string message)
        {
            Console.WriteLine($"Uzhhorod captain receive message {message}");
        }
    }
}
