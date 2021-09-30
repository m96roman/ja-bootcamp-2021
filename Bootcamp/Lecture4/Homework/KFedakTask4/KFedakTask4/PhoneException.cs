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
        public ITelephone telephone { get; set; }
        public DateTime ErrorTimeStamp { get; set; }
        public string CauseOfError { get; set; }

        public BatteryIsDeadException() { }

        public BatteryIsDeadException(ITelephone telephone)
        {
            this.telephone = telephone;
        }

        public BatteryIsDeadException(string cause)
        {
            Console.WriteLine(cause);
        }
    }
}
