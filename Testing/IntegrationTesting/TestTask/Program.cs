using Task;
using Task.Exceptions;

namespace TestTask
{
    class Program
    {
        static FakeLogger logger = new FakeLogger();
        static void Main(string[] args)
        {
            //logger = Task.Logger;
            //logger.Messages.Add("gdf");
            ChargeABitPhones();
            ChargPhones();
            TryCallAmbulanceIPhoneException();
            TryCallAmbulanceNokiaException();
        }

        static void TryCallAmbulanceNokiaException()
        {
            try
            {
                TestData.nokiaPhoneZeroBattery.CallAmbulance();
            }
            catch (BatteryIsDeadException ex)
            {
                if (ex.Phone?.BatteryLevel == 0)
                {
                    Logger.WriteLine($"{TestData.nokiaPhoneZeroBattery.PhoneName} try to call ambulance is PASSED!");
                }
                return;
            }
            Logger.WriteLine($"{TestData.nokiaPhoneZeroBattery.PhoneName} try to call ambulance is FAILED!");
        }

        static void TryCallAmbulanceIPhoneException()
        {
            try
            {
                TestData.phoneIPhone13ZeroBattery.CallAmbulance();
            }
            catch(BatteryIsDeadException ex)
            {
                if(ex.Phone?.BatteryLevel == 0)
                {
                    Logger.WriteLine($"{TestData.phoneIPhone13ZeroBattery.PhoneName} try to call ambulance is PASSED!");
                }
                return;
            }
            Logger.WriteLine($"{TestData.phoneIPhone13ZeroBattery.PhoneName} try to call ambulance is FAILED!");
        }

        static void ChargPhones()
        {
            TestData.phoneIPhone13.Charge();

            if (TestData.phoneIPhone13.BatteryLevel == 100)
            {
                Logger.WriteLine($"{TestData.phoneIPhone13.PhoneName} Charg to 100% is PASSED!");
            }
            else
            {
                Logger.WriteLine($"{TestData.phoneIPhone13.PhoneName} Charg to 100% is FAILED!");
            }

            TestData.nokiaPhone.Charge();

            if (TestData.nokiaPhone.BatteryLevel == 100)
            {
                Logger.WriteLine($"{TestData.nokiaPhone.PhoneName} Charg to 100% is PASSED!");
            }
            else
            {
                Logger.WriteLine($"{TestData.nokiaPhone.PhoneName} Charg to 100% is FAILED!");
            }
        }

        static void ChargeABitPhones()
        {
            TestData.phoneIPhone13.ChargeABit();

            if(TestData.phoneIPhone13.BatteryLevel == 5)
            {
                Logger.WriteLine($"{TestData.phoneIPhone13.PhoneName} Charg a bit is PASSED!");
            }
            else
            {
                Logger.WriteLine($"{TestData.phoneIPhone13.PhoneName} Charg a bit is FAILED!");
            }

            TestData.nokiaPhone.ChargeABit();

            if (TestData.nokiaPhone.BatteryLevel == 9)
            {
                Logger.WriteLine($"{TestData.nokiaPhone.PhoneName} Charg a bit is PASSED!");
            }
            else
            {
                Logger.WriteLine($"{TestData.nokiaPhone.PhoneName} Charg a bit is FAILED!");
            }
        } 
    }
}
