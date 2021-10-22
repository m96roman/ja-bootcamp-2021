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
                    return (Phone)Activator.CreateInstance(phonetype, batteryLevel, name, logger);
                }
                catch (TargetInvocationException exe)
                {
                    if (exe.InnerException is ArgumentException argexe)
                    {
                        throw new ArgumentException(argexe.Message);
                    }

                    throw;
                }
            }

            return null;
        }
    }
}
