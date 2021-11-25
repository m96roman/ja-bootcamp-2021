using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    class CaptainKyiv : Captain
    {
        public CaptainKyiv(Operator opr) : base(opr) { }

        public override void SpeakToCaptain(string message)
        {
            Console.WriteLine($"Message to another captains from Kyiv Cap {message}");
        }
    }
}
