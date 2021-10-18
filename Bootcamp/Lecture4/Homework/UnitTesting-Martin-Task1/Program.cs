using System;
using System.Collections.Generic;

namespace UnitTesting_Martin_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            var loggerList = new List<ConsoleLogger>()
            {
                PhoneCreatingWithBatteryLevel(70),
                PhoneCreatingWithBatteryLevel(120),
                PhoneCreatingWithBatteryLevel(-23),
                PhoneCreatingWithBatteryLevel(0),

                TestNokiaPrayForBattery(99),

                TestPhoneCharge(20),

                TestPhoneChargeABit(100),
                TestPhoneChargeABit(23),

                TestPhoneCallAmbulance(4),
                TestPhoneCallAmbulance(5),
                TestPhoneCallAmbulance(6),
            };

            foreach (var iteam in loggerList) 
            {
                iteam.WriteTestResult();
            }

        }

        static ConsoleLogger PhoneCreatingWithBatteryLevel(int expectedBatteryLevl)
        {

            MRoshko_Task4.Phone phone;

            try
            {
                phone = new MRoshko_Task4.Nokia($"{expectedBatteryLevl}");
            }
            catch (Exception ex)
            {
                return new ConsoleLogger(true, $"Battery value is {expectedBatteryLevl} \n{ex}");
            }

            if (phone.batteryLevel == expectedBatteryLevl)
            {
                return new ConsoleLogger(true, $"Was create new phone with battery level {expectedBatteryLevl}");
            }

            return new ConsoleLogger(false, $"Battery level is {phone.batteryLevel}\nExpected battery level is {expectedBatteryLevl}");
        }

        static ConsoleLogger TestNokiaPrayForBattery(int batteryValue)
        {

            MRoshko_Task4.Nokia phone = new MRoshko_Task4.Nokia($"{batteryValue}");

            phone.PrayForBattery();

            if (batteryValue + 8 == phone.batteryLevel || phone.batteryLevel == 100)
            {
                return new ConsoleLogger(true, $"Current battery level is {phone.batteryLevel}");
            }

            return new ConsoleLogger(false, $"Incorrect battery value {phone.batteryLevel}");
        }

        static ConsoleLogger TestPhoneCharge(int batteryValue)
        {

            MRoshko_Task4.Phone phone = new MRoshko_Task4.Phone($"{batteryValue}");

            phone.Charge();

            if (phone.batteryLevel == 100)
            {
                return new ConsoleLogger(true, $"Current battery level is {phone.batteryLevel}");
            }

            return new ConsoleLogger(false, $"Incorrect battery value {phone.batteryLevel}");
        }

        static ConsoleLogger TestPhoneChargeABit(int batteryValue)
        {

            MRoshko_Task4.Phone phone = new MRoshko_Task4.Phone($"{batteryValue}");

            phone.ChargeABit();

            if ((phone.batteryLevel == batteryValue+1 && batteryValue + 1<=100) || phone.batteryLevel == 100)
            {
                return new ConsoleLogger(true, $"Current battery level is {phone.batteryLevel}");
            }

            return new ConsoleLogger(false, $"Incorrect battery value {phone.batteryLevel}");
        }

        static ConsoleLogger TestPhoneCallAmbulance(int batteryValue) 
        {

            MRoshko_Task4.Phone phone = new MRoshko_Task4.Phone($"{batteryValue}");

            try
            {
                phone.CallAmbulance();
            }
            catch (Exception ex)
            {
                return new ConsoleLogger(true, $"Battery value is {batteryValue-5} \n{ex}");
            }

            if (phone.batteryLevel == batteryValue-5)
            {
                return new ConsoleLogger(true, $"Ambulance was colled \nBattery value is {phone.batteryLevel}");
            }

            return new ConsoleLogger(false, $"Incorrect battery value {phone.batteryLevel}");
        }
    }
}
