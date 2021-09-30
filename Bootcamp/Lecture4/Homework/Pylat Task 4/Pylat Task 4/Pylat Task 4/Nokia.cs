using System;
namespace Pylat_Task_4
{

    public class Nokia : PhoneBase, IPhoneMethods, NokiaMethods
    {


        public Nokia(string typeOfPhone, int bateryLevel) : base(typeOfPhone, bateryLevel)
        { }

        public void CheckingBateryLevel()
        {
            Console.WriteLine("Battery check");

            if (BateryLevel <= 0 || BateryLevel > 100)
            {
                //throw new PhoneExceptions($"Invalid value of batary ({TypeOfPhone})");
                throw new ArgumentException($"Invalid value of batary({ TypeOfPhone })");
            }
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
            throw new PhoneExceptions($@"Charging {TypeOfPhone} to {BateryLevel}%");
        }

        public void ChargeABit()
        {
            BateryLevel = BateryLevel + 1;
            throw new PhoneExceptions($@"Charging {TypeOfPhone} by {BateryLevel}%");
        }

        public void BatteryIsDeadException()
        {
            if (BateryLevel < 5)
            {
                string NewBataryLevel = BateryLevel.ToString();
                throw new PhoneExceptions($@"{TypeOfPhone}'s batary level is {NewBataryLevel}");
            }
        }

        public void PrayForBattery()
        {
            // int increasedBataryLevelNokia = BateryLevel + 8;
            BateryLevel += 8;
            throw new PhoneExceptions("Praying for the battery");
        }
    }
}

