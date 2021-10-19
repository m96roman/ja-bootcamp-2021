using DIVanyshyn_Task4;
using System;

namespace DIvanyshyn_UnitTests_Day1
{
    internal class NokiaTests : ITestable
    {
        private Action<string, ConsoleColor> writeResult;

        public NokiaTests(Action<string, ConsoleColor> writeResult)
        {
            this.writeResult = writeResult;
        }

        public void RunAll()
        {
            Test_PrayForBattery_Log_Nokia(1, "123");
            Test_PrayForBattery_Log_Nokia(4, "123");

            Test_PrayForBattery_Work_Nokia(1, "123", expectedValue: 9);
            Test_PrayForBattery_Work_Nokia(4, "123", expectedValue: 12);
        }
      
        private void Test_PrayForBattery_Work_Nokia(int batteryLevel, string Name, int expectedValue)
        {
            FakeLogger fakeLogger = new FakeLogger();

            Nokia nokia = (Nokia)PhoneBuilder.GetPhone(batteryLevel, Name, typeof(Nokia), fakeLogger);

            nokia.PrayForBattery();

            if (nokia.BatteryLevel == expectedValue)
            {
                writeResult.Invoke(nameof(Test_PrayForBattery_Log_Nokia) + " has passed", ConsoleColor.Green);

                return;
            }

            writeResult.Invoke(nameof(Test_PrayForBattery_Log_Nokia) + " has failed", ConsoleColor.Red);
        }

        private void Test_PrayForBattery_Log_Nokia(int batteryLevel, string Name)
        {
            FakeLogger fakeLogger = new FakeLogger();

            Nokia nokia = (Nokia)PhoneBuilder.GetPhone(batteryLevel, Name, typeof(Nokia), fakeLogger);

            nokia.PrayForBattery();

            if (fakeLogger.FakeLoggerLog.Count == 1 &&
                fakeLogger.FakeLoggerLog[0].Key == "Praying for battery (Thank god for another day with Nokia)" &&
                fakeLogger.FakeLoggerLog[0].Value == MessageType.Message)
            {
                writeResult.Invoke(nameof(Test_PrayForBattery_Log_Nokia) + " has passed", ConsoleColor.Green);

                return;
            }

            writeResult.Invoke(nameof(Test_PrayForBattery_Log_Nokia) + " has failed", ConsoleColor.Red);
        }
    }
}