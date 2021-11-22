using System;

namespace Task2
{
    public class CommonAutoPilot : IPilot
    {
        protected IDrivable _transport;

        public CommonAutoPilot(IDrivable transport)
        {
            _transport = transport;
        }

        public virtual void Navigate(string destination)
        {
            Console.WriteLine($"Navigate to destination {destination}");
            _transport.GoForward();
            _transport.GoBackward();
        }
    }
}