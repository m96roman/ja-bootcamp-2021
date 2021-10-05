using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    public class AuctionEventArgs : EventArgs
    {
        public readonly string msg;
        public AuctionEventArgs (string message)
        {
            msg = message;
        }
    }
}