using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace KFedakTask4
{
    class BatteryIsDeadException : ApplicationException
    {
        private string _messageDetails = String.Empty;
        public DateTime ErrorTimeStamp { get; set; }
        public string CauseOfError { get; set; }

        public BatteryIsDeadException() { }

        public BatteryIsDeadException(string cause)
        {
            Console.WriteLine(cause);
        }
    }
}
