using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFedak_TDD
{
    class BatteryIsDeadException : ApplicationException
    {
        public Phone Telephone { get; set; }
        public DateTime ErrorTimeStamp { get; set; }
        public string CauseOfError { get; set; }

        public BatteryIsDeadException() { }

        public BatteryIsDeadException(Phone telephone, string cause) : base(cause)
        {
            this.Telephone = telephone;
        }

        public BatteryIsDeadException(string cause) : base(cause) { }
    }
    class InvalidValueForBattery : ApplicationException
    {
        public int BatteryLevel { get; set; }
        public DateTime ErrorTimeStamp { get; set; }
        public string CauseOfError { get; set; }

        public InvalidValueForBattery() { }

        public InvalidValueForBattery(int baterry, string cause) : base(cause)
        {
            this.BatteryLevel = baterry;
        }

        public InvalidValueForBattery(string cause) : base(cause) { }
    }
}
