using Pylat_Lecture_9___.Task4;
using System;

namespace Pylat_Task_4
{
    public abstract class PhoneBase : IPhoneBehaviour
    {
        Logger logger = new Logger();
        public int BateryLevel { get; protected set; }
        public string TypeOfPhone { get; protected set; }

        public PhoneBase(string typeOfPhone, int bateryLevel)
        {
            if (bateryLevel < 0 || bateryLevel > 100)
            {
                var ex = new ArgumentException($"Invalid value of batary({ TypeOfPhone })");
                 logger.LogExeptions($"< {DateTime.UtcNow} >" + ex.ToString());
                throw ex;
            }
            BateryLevel = bateryLevel;
            TypeOfPhone = typeOfPhone;
        }
        public void CallAmbulance()
        {
            var ex = new PhoneExceptions(this);
            var message = $"calling an ambulance from {TypeOfPhone}, remaining charge: {BateryLevel}%";
            if (BateryLevel < 5)
            {
                BateryLevel = 0;
                logger.LogExeptions($"< {DateTime.UtcNow} >" + ex.ToString());
                throw ex;
            }
            else
            {
                BateryLevel -= 5;
                logger.LogExeptions($"< {DateTime.UtcNow} >" + message);
                Console.WriteLine(message);
            }

        }

        public void Charge()
        {
            var message = $@"Charging {TypeOfPhone} to {BateryLevel}%";
            BateryLevel = 100;
            Console.WriteLine(message);
            logger.LogExeptions($"< {DateTime.UtcNow} >" + message);
        }

        public void ChargeABit()
        {
            var message = $@"Charging {TypeOfPhone} by {BateryLevel}%";

            if (BateryLevel < 100)
            {
                BateryLevel = BateryLevel + 1;
            }
            logger.LogExeptions($"< {DateTime.UtcNow} >" + message);
            Console.WriteLine($@"Charging {TypeOfPhone} by {BateryLevel}%");
        }

        public void BatteryIsDeadException()
        {
            if (BateryLevel < 5)
            {
                string NewBataryLevel = BateryLevel.ToString();
                var ex = new PhoneExceptions($@"{TypeOfPhone}'s batary level is {NewBataryLevel}");
                logger.LogExeptions($"< {DateTime.UtcNow} >" + ex);
                throw ex;
            }
        }
    }
} 

