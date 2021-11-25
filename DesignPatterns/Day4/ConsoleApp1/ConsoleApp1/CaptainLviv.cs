using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    class CaptainLviv : Captain
    {
        public CaptainLviv(Operator opr) : base(opr) { }

        public override void SpeakToCaptain(string message)
        {
            Console.WriteLine($"Message to another captains from Lviv Cap {message}");
        }
    }
}
