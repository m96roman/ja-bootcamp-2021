namespace Yaroslav_Task4
{
    class AdvancedTestPhoneEmergency
    {
        ILogger _logger;

        public PhoneEmergencyTestHolder PhoneHolder { get; }

        public AdvancedTestPhoneEmergency(PhoneEmergencyTestHolder phones, ILogger logger)
        {
            PhoneHolder = phones;
            _logger = logger;
        }

        public void CycleTestEmergency(int cycles)
        {
            for (int i = 1; i <= cycles; i++)
            {
                try
                {
                    TestEmergency();
                }
                catch (BatteryIsDeadException ex)
                {
                    ex.PhoneInstance.Charge();
                }
            }
        }

        public void TestEmergency()
        {
            foreach (var phone in PhoneHolder)
            {
                try
                {
                    phone.CallAmbulance();
                }
                catch (BatteryIsDeadException ex)
                {
                    _logger.Log($"Phone failed to call an ambulance: {ex.PhoneInstance.PhoneType}", MessageType.Error);

                    if (phone is Nokia nokiaPhone)
                    {
                        nokiaPhone.PrayForBattery();
                        phone.CallAmbulance();
                        continue;
                    }

                    throw;
                }
                finally
                {
                    phone.ChargeABit();
                }
            }
        }
    }
}
