using DIVanyshyn_Task4;
using System;

namespace DIvanyshyn_UnitTests_Day1
{
    internal class NokiaTests : ITestable
    {
        private Action<string> logSucces;

        private Action<string> logFailure;

        public NokiaTests(Action<string> logSucces, Action<string> logFailure)
        {
            this.logSucces = logSucces;
            this.logFailure = logFailure;
        }

        public void RunAll()
        {
            Test_PrayForBattery_Log_Nokia(1, "123");
            Test_PrayForBattery_Log_Nokia(4, "123");

            Test_PrayForBattery_Work_Nokia(1, "123", expectedValue: 9);
            Test_PrayForBattery_Work_Nokia(4, "123", expectedValue: 12);
        }

        private void PrayForBatteryInit(string Name, int batteryLevel, ref Nokia nokia, ref FakeLogger fakeLogger)
        {
            fakeLogger = new FakeLogger();

            nokia = (Nokia)PhoneBuilder.GetPhone(batteryLevel, Name, typeof(Nokia), fakeLogger);

            nokia.PrayForBattery();
        }

        private void Test_PrayForBattery_Work_Nokia(int batteryLevel, string Name, int expectedValue)
        {
            Nokia nokia = null;
            FakeLogger fakeLogger = null;

            PrayForBatteryInit(Name, batteryLevel, ref nokia, ref fakeLogger);

            if (nokia.BatteryLevel == expectedValue)
            {
                logSucces.Invoke(nameof(Test_PrayForBattery_Log_Nokia));

                return;
            }

            logFailure.Invoke(nameof(Test_PrayForBattery_Log_Nokia));
        }

        private void Test_PrayForBattery_Log_Nokia(int batteryLevel, string Name)
        {
            Nokia nokia = null;
            FakeLogger fakeLogger = null;

            PrayForBatteryInit(Name, batteryLevel, ref nokia, ref fakeLogger);

            if (fakeLogger.FakeLoggerLog.Count == 1 &&
                fakeLogger.FakeLoggerLog[0].Key == "Praying for battery (Thank god for another day with Nokia)" &&
                fakeLogger.FakeLoggerLog[0].Value == MessageType.Message)
            {
                logSucces.Invoke(nameof(Test_PrayForBattery_Log_Nokia));

                return;
            }

            logFailure.Invoke(nameof(Test_PrayForBattery_Log_Nokia));
        }
    }
}