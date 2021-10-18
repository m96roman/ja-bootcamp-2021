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
            Test_Contructor_Throwing_Exception_Nokia();

            Test_CallAmbulance_Work_And_Log_Nokia();

            Test_CallAmbulance_ThrowException_Nokia();

            Test_PrayForBattery_Nokia();

            Test_Charge_Nokia();

            Test_ChargeABit_Nokia();
        }

        #region Tests

        private void Test_ChargeABit_Nokia()
        {
            FakeLogger fakeLogger = new FakeLogger();
            Nokia nokia = new Nokia(20, "123", fakeLogger);

            nokia.ChargeABit();

            if (nokia.BatteryLevel == 21 &&
                fakeLogger.FakeLoggerLog.Count == 1 &&
                fakeLogger.FakeLoggerLog[0].Key == "Charging 123 by 1%" &&
                fakeLogger.FakeLoggerLog[0].Value == MessageType.Message)
            {
                writeResult.Invoke(nameof(Test_ChargeABit_Nokia) + " passed", ConsoleColor.Green);

                return;
            }

            writeResult.Invoke(nameof(Test_ChargeABit_Nokia) + " failed", ConsoleColor.Red);
        }

        private void Test_Charge_Nokia()
        {
            FakeLogger fakeLogger = new FakeLogger();

            Nokia nokia = new Nokia(8, "123", fakeLogger);
            nokia.Charge();

            if (nokia.BatteryLevel == 100 &&
                fakeLogger.FakeLoggerLog.Count == 1 &&
                fakeLogger.FakeLoggerLog[0].Key == "Charging 123 to 100%" &&
                fakeLogger.FakeLoggerLog[0].Value == MessageType.Message)
            {
                writeResult.Invoke(nameof(Test_Charge_Nokia) + " has passed", ConsoleColor.Green);

                return;
            }

            writeResult.Invoke(nameof(Test_Charge_Nokia) + " has failed", ConsoleColor.Red);
        }

        private void Test_PrayForBattery_Nokia()
        {
            FakeLogger fakeLogger = new FakeLogger();
            Nokia nokia = new Nokia(10, "123", fakeLogger);

            nokia.PrayForBattery();

            if (fakeLogger.FakeLoggerLog.Count != 0 &&
                fakeLogger.FakeLoggerLog[0].Key == "Praying for battery (Thank god for another day with Nokia)" &&
                fakeLogger.FakeLoggerLog[0].Value == MessageType.Message &&

                nokia.BatteryLevel == 18)
            {
                writeResult.Invoke(nameof(Test_PrayForBattery_Nokia) + " has passed", ConsoleColor.Green);

                return;
            }

            writeResult.Invoke(nameof(Test_PrayForBattery_Nokia) + " has failed", ConsoleColor.Red);
        }

        private void Test_Contructor_Throwing_Exception_Nokia()
        {

            try
            {
                Nokia nokia = new Nokia(-5, "123", null);
            }
            catch (ArgumentException)
            {
                writeResult.Invoke(nameof(Test_Contructor_Throwing_Exception_Nokia) + " has passed", ConsoleColor.Green);
                return;
            }

            writeResult.Invoke(nameof(Test_Contructor_Throwing_Exception_Nokia) + " has failed", ConsoleColor.Red);
        }

        private void Test_CallAmbulance_ThrowException_Nokia()
        {
            FakeLogger fakeLogger = new FakeLogger();

            Nokia nokia = new Nokia(2, "123", fakeLogger);

            try
            {
                nokia.CallForAmbulance();
            }
            catch (BatteryIsDeadException bs)
            {
                if (bs.Phone?.BatteryLevel == 0)
                {
                    writeResult.Invoke(nameof(Test_CallAmbulance_ThrowException_Nokia) + " passed", ConsoleColor.Green);
                }

                return;
            }

            writeResult.Invoke(nameof(Test_CallAmbulance_ThrowException_Nokia) + " failed", ConsoleColor.Red);
        }

        private void Test_CallAmbulance_Work_And_Log_Nokia()
        {
            FakeLogger fakeLogger = new FakeLogger();

            Nokia nokia = new Nokia(10, "Test1", fakeLogger);

            nokia.CallForAmbulance();

            if (fakeLogger.FakeLoggerLog.Count == 1 &&
                fakeLogger.FakeLoggerLog[0].Key == $"Calling an ambulance for phone Test1 remaining charge 5%" &&
                fakeLogger.FakeLoggerLog[0].Value == MessageType.Message &&

               nokia.BatteryLevel == 5
                )
            {

                writeResult.Invoke(nameof(Test_CallAmbulance_Work_And_Log_Nokia) + " passed", ConsoleColor.Green);

                return;
            }

            writeResult.Invoke(nameof(Test_CallAmbulance_Work_And_Log_Nokia) + " failed", ConsoleColor.Red);
        }

        #endregion
    }
}