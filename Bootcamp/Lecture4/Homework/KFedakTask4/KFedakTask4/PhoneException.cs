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
        public ITelephone Telephone { get; set; }
        public DateTime ErrorTimeStamp { get; set; }
        public string CauseOfError { get; set; }

        public BatteryIsDeadException() { }

        public BatteryIsDeadException(ITelephone telephone) : this($"Phone failed to call an ambulance: {telephone.PhoneName} ")
        {
            this.Telephone = telephone;
        }

        public BatteryIsDeadException(string cause) : base(cause) { }
    }
}
