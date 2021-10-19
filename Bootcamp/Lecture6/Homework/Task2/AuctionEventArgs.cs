using System;

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