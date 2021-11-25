using System;

namespace Observer
{
    class EvilZhek : BasicWaterService, IClient
    {
        public void NotifyFor(MessageType waterState, string message)
        {
            Console.WriteLine($"Argh! again water is {waterState} well, now i must notify my clients..");

            NotifyAll(waterState, "The head office says: " + message);
        }

        public override void TurnOffEverything()
        {
            NotifyAll(MessageType.WaterOff, "We are not bad guys, just doing some fixes");
        }

        public override void TurnOnEverything()
        {
            NotifyAll(MessageType.WaterOn, "Now everything is working");
        }
    }
}
