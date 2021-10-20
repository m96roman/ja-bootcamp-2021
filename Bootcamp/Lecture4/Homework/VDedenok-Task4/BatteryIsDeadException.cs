using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VDedenok_Task4
{
    class BatteryIsDeadException : Exception
    {
       // Phone phonInstance = new Phone();
        public String ShowMessage { get; set; }
        public BatteryIsDeadException(string message, Phone instance)
        {
            this.ShowMessage = message;
            //phonInstance = instance;
            instance.Charge();
        }
    }
}
