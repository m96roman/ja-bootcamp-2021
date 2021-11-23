using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class AutoPilot
    {
        private IDrivable _transport;
        private ILogger _logger;

        public AutoPilot(IDrivable transport) : this(transport, new LoggerToConsole()) { }

        public AutoPilot(IDrivable transport, ILogger logger)
        {
            _transport = transport;
            _logger = logger;
        }

        public void Navigate(string destination)
        {
            _logger.Log($"Navigate to destination {destination}");
            _transport.GoForward();
            _transport.TurnLeft();
            _transport.GoBackward();
            _transport.TurnRight();
        }
    }
}
