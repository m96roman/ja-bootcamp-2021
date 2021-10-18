using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRoshko_Task4
{
    class BatteryIsDeadException : Exception
    {
        public Phone Instance { get; set; }

        public BatteryIsDeadException()
        {
        }

        public BatteryIsDeadException(Phone phone, string message) : base(message)
        {
            Instance = phone;
        }
    }
}
