using Task.Interfaces;
using Task.Exceptions;
using Task.Enums;

namespace Task
{
    public class Program
    {
       internal static ILogger logger = new Logger();

        public static void Main(string[] args)
        {
            IPhone[] phones = new IPhone[]
            {
                new Iphone13("IPhone 13 Test 1", 4, PhoneType.IPhone, logger),
                new Iphone13("IPhone 13 Test 2", 8, PhoneType.IPhone, logger),
                new Iphone13("IPhone 13 Test 3", 25, PhoneType.IPhone, logger),

                new Nokia("Nokia 3110 Test 1", 4, PhoneType.Nokia, logger),
                new Nokia("Nokia 3110 Test 2", 8, PhoneType.Nokia, logger),
                new Nokia("Nokia 3110 Test 2", 25, PhoneType.Nokia, logger)
            };

            PhoneEmergencyTestHolder tests = new PhoneEmergencyTestHolder(phones);

            int countCallsEmergency = 0;
            while (countCallsEmergency < 10)
            {
                try
                {
                    PhoneEmergencyTestHolder.TestEmergency(tests, logger);
                }
                catch (BatteryIsDeadException ex)
                {
                    ex.Phone.Charge();
                }

                countCallsEmergency++;
            }
        }
    }
}
