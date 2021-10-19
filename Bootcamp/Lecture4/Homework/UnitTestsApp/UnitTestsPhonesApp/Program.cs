using System;
using System.Collections.Generic;
using ADovhanych_Task4;

namespace UnitTestsPhonesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CallAmbulanceTest(-5);
            ValidBatteryTest(200);
            NokiaTest(20);
            ChargeABitTest(-5);
        }

        static void ValidBatteryTest(int batteryLvl)
        {
            try
            {
                Phone phone = new IPhone(batteryLvl);
                if (phone.BatteryLvl > 0 && phone.BatteryLvl <= 100)
                {
                    Logger.PassedTest(batteryLvl);
                }
            }
            catch (Exception)
            {
                Logger.FailedTest(batteryLvl);
                throw;
            }
        }

        static void CallAmbulanceTest(int battery)
        {
            try
            {   
                Phone phone = new Nokia(battery);
                phone.CallAmbulance();

                if (battery >= 5 && battery < 100)
                {                    
                    Logger.PassedTest(battery);
                }
            }
            catch (Exception)
            {
                Logger.FailedTest(battery);
            }
        }

        static void ChargeTest(int battery)
        {
            IPhone iphone = new IPhone(battery);
            iphone.Charge();

            if (iphone.BatteryLvl == 100)
            {
                Logger.PassedTest(battery);
            }
            else
            {
                Logger.FailedTest(battery);
            }
        }

        static void ChargeABitTest(int battery)
        {
            Nokia nokia = new Nokia(battery);
            nokia.ChargeABit();
            if (nokia.BatteryLvl == battery + 1)
            {
                Logger.PassedTest(battery);
            }
            else
            {
                Logger.FailedTest(battery);
            }
        }

        static void NokiaTest(int battery)
        {
            Nokia nokia = new Nokia(battery);
            nokia.PrayForBatery();
            if (nokia.BatteryLvl == battery + 8)
            {
                Logger.PassedTest(battery);
            }
            else
            {
                Logger.FailedTest(battery);
            }
        }
    }
}
