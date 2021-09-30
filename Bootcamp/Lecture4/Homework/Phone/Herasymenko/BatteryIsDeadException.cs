using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herasymenko
{
    public class BatteryIsDeadException : Exception
    {
        public BatteryIsDeadException(IMobile phone)
        {
            Console.WriteLine($"Bettery is dead you can't call from {phone.PhoneModel}");
        }

        public BatteryIsDeadException(string message) : base(message)
        {
        }
    }
}
