using System.Collections.Generic;

namespace Observer
{
    class UkrainianWaterWoodooMages : BasicWaterService
    {
        public override void TurnOffEverything()
        {
            string message = "Sorry)";

            NotifyAll(MessageType.WaterOff, message);
        }

        public override void TurnOnEverything()
        {
            string message = "Dont worry we will turn water off again, from minute to minute";

            NotifyAll(MessageType.WaterOn, message);
        }

    }
}
