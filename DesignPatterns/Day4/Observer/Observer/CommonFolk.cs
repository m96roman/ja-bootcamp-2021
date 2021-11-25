using System;

namespace Observer
{
    public class CommonFolk : IClient
    {
        public void NotifyFor(MessageType waterOff, string message)
        {
            Console.WriteLine($"Reads message {message}");

            switch (waterOff)
            {
                case MessageType.WaterOff:
                    Console.WriteLine("Water is off again..");
                    break;
                case MessageType.WaterOn:
                    Console.WriteLine("Water is on! Finally!");
                    break;
            }
        }
    }
}
