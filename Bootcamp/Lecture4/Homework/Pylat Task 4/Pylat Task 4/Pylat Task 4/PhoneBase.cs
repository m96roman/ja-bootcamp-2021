using System;

namespace Pylat_Task_4
{
    public abstract class PhoneBase : IPhoneBehaviour
    {
        public int BateryLevel { get; protected set; }
        public string TypeOfPhone { get; protected set; }

        public PhoneBase(string typeOfPhone, int bateryLevel)
        {
            if (bateryLevel < 0 || bateryLevel > 100)
            {
                throw new ArgumentException($"Invalid value of batary({ TypeOfPhone })");
            }
            BateryLevel = bateryLevel;
            TypeOfPhone = typeOfPhone;
        }
        public void CallAmbulance()
        {
            if (BateryLevel < 5)
            {
                BateryLevel = 0;
                throw new PhoneExceptions(this);
            }
            else
            {
                BateryLevel -= 5;
                Console.WriteLine($"calling an ambulance from {TypeOfPhone}, remaining charge: {BateryLevel}%");
            }

        }

        public void Charge()
        {
            BateryLevel = 100;
            Console.WriteLine($@"Charging {TypeOfPhone} to {BateryLevel}%");
        }

        public void ChargeABit()
        {
            if (BateryLevel < 100)
            {
                BateryLevel = BateryLevel + 1;
            }
            Console.WriteLine($@"Charging {TypeOfPhone} by {BateryLevel}%");
        }

        public void BatteryIsDeadException()
        {
            if (BateryLevel < 5)
            {
                string NewBataryLevel = BateryLevel.ToString();
                throw new PhoneExceptions($@"{TypeOfPhone}'s batary level is {NewBataryLevel}");
            }
        }
    }
} 

