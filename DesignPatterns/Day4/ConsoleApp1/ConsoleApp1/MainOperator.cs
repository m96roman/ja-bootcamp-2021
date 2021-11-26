using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    class MainOperator : Operator
    {
        public Captain CaptainLviv { get; set; }
        public Captain CaptainUzh { get; set; }
        public Captain CaptainKyiv { get; set; }
        

        public override void SendMessage(string message, Captain captain)
        {
            if (CaptainKyiv == captain)
            {
                CaptainKyiv.SpeakToCaptain(message);
            }
            else if (CaptainLviv == captain)
            {
                CaptainLviv.SpeakToCaptain(message);
            }
            else if (CaptainUzh == captain)
            {
                CaptainUzh.SpeakToCaptain(message);
            }
        }
    }
}
