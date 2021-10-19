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
            Test_PrayForBattery_Log_Nokia();
        }

        private void Test_PrayForBattery_Log_Nokia()
        {
            FakeLogger fakeLogger = new FakeLogger();
            Nokia nokia = new Nokia(10, "123", fakeLogger);

            nokia.PrayForBattery();

            if (fakeLogger.FakeLoggerLog.Count != 0 &&
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