using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    class CaptainUzhgorod : Captain
    {
        public CaptainUzhgorod(Operator opr) : base(opr) { }

        public override void SpeakToCaptain(string message)
        {
            Console.WriteLine($"Message to another captains Uzh Cap {message}");
        }
    }
}
