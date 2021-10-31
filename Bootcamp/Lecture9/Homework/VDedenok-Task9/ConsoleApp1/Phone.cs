using System;

namespace VDedenok_Task9
{
    class Phone
    {
        Logger logger = new Logger();

        const int fullBattery = 100;
        const int lowLevel = 5;
       
        private int batteryLevel;
      
        public int BatteryLevel
        { 
            get
            {
                return batteryLevel;
            }
            set
            {
                try
                {
                    if (value < fullBattery && value > 0)
                    {
                        batteryLevel = value;
                    }
                    else
                    {
                        throw new PhoneOverflowException($"Datas are unappopriate on {this.GetType().Name}!");
                    }
                }

                catch (PhoneOverflowException ex)
                {
                    Console.WriteLine($"Exception message: {ex.ShowMessage}");
                    logger.WriteLine(ex.ShowMessage);               
                }
            }
        }

        public void CallAmbulance()
        {
            if (this.batteryLevel >= lowLevel)
            {
                batteryLevel -= 5;
                Console.WriteLine($"Calling an ambulance from {this.GetType().Name}, remaining charge: {batteryLevel}%.");
            }
            else
            {
                batteryLevel = 0;
                throw new BatteryIsDeadException($"Ambulance Phone failed to call an ambulance: {this.GetType().Name}.");
            };
        }

        public void Charge()
        {
            this.batteryLevel = 100;
            Console.WriteLine($"Charging {this.GetType().Name} to 100%.");
        }

        public void ChargeABit()
        {
            batteryLevel += 1;
            Console.WriteLine($"Charging {this.GetType().Name} by 1%.");
        }
    }
}
