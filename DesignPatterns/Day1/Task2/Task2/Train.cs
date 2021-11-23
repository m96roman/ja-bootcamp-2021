using System;

namespace Task2
{
    public class Train : IDrivableTrain
    {
        public void GoForward()
        {
            Console.WriteLine("Train is going forward.");
        }

        public void GoBackward()
        {
            Console.WriteLine("Train is backing up.");
        }

        public void Navigate(string destination)
        {
            Console.WriteLine($"Navigate to destination {destination}");
            GoForward();
            GoBackward();
        }
    }
}
