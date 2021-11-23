using System;

namespace Task2
{
    public class AutoPilotTrain
    {
        private IDrivableLinear _transport;
        private ILogger _logger;

        public AutoPilotTrain(IDrivableLinear transport) : this(transport, new LoggerToConsole()) { }

        public AutoPilotTrain(IDrivableLinear transport, ILogger logger)
        {
            _transport = transport;
            _logger = logger;
        }

        public void Navigate(string destination)
        {
            _logger.Log($"Navigate to destination {destination}");
            _transport.GoForward();
            _transport.GoBackward();
        }
    }
}
