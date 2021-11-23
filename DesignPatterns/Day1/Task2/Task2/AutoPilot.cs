using System;

namespace Task2
{
    public class AutoPilot
    {
        public void Navigate(string destination, IDrivable transport)
        {
            Console.WriteLine($"Navigate to destination {destination}");
            transport.GoForward();
            transport.TurnLeft();
            transport.GoBackward();
            transport.TurnRight();
        }

        public void Navigate(string destination, ITrain train)
        {
            Console.WriteLine($"Navigate to destination {destination}");
            train.GoForward();
            train.GoBackward();
        }
    }
}
