using System;
using ConsoleApp5.Abstracts;

namespace ConsoleApp5.Captains
{
    public class KyivCaptain : Captain
    {
        public KyivCaptain(Mediator mediator) : base(mediator) { }

        public override void Notify(string message)
        {
            Console.WriteLine($"Kyiv captain receive message {message}");
        }
    }
}
