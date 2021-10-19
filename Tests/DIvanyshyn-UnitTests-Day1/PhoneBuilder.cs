using DIVanyshyn_Task4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DIvanyshyn_UnitTests_Day1
{
    class PhoneBuilder
    {
        internal static Phone GetPhone(int batteryLevel, string name, Type phonetype, ILogger logger)
        {
            if (phonetype.IsSubclassOf(typeof(Phone)))
            {
                try
                {
                    if (phonetype == typeof(Nokia))
                    {
                        return new Nokia(batteryLevel, name, logger);
                    }

                    return new IPhone13(batteryLevel, name, logger);
                }
                catch (ArgumentException exe)
                {

                    throw;
                }
            }

            return null;
        }
    }
}
