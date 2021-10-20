using System;

namespace ADovhanych_Task4
{
    internal class Phone
    {
        public string PhoneName { get; set; }
        public int BatteryLvl { get; set; }
        protected ILogger _logger;

        public Phone(int batteryLvl, ILogger logger = null)
        {
            _logger = logger ?? new PhoneLogger();
            
            if (batteryLvl > 0 && batteryLvl < 100)
            {
                BatteryLvl = batteryLvl;
            }
            else
            {
                throw new InvalidBatteryLevelException();
            }
        }

        public void CallAmbulance()
        {
            if (BatteryLvl > 100 || BatteryLvl < 0)
            {
                throw new InvalidPhoneChargeException();
            }

            if (BatteryLvl >= 5)
            {
                BatteryLvl -= 5;
                _logger.LogInfo($"Calling an ambulance from {GetType().Name}, remaining charge: {BatteryLvl}");
            }
            else
            {
                BatteryLvl = 0;
                throw new BatteryIsDeadException();
            }
        }
    }
}
