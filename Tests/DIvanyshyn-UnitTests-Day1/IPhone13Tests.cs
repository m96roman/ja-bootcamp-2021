using DIVanyshyn_Task4;
using System;

namespace DIvanyshyn_UnitTests_Day1
{
    internal class IPhone13Tests : ITestable
    {
        private Action<string, ConsoleColor> writeResult;

        public IPhone13Tests(Action<string, ConsoleColor> writeResult)
        {
            this.writeResult = writeResult;
        }

        public void RunAll()
        {
            Test_Contructor_Throwing_Excpetion_Iphone13();

            Test_CallAmbulance_ThrowException_IPhone13();

            Test_CallAmbulance_Work_And_Log_IPhone13();

            Test_ChargeABit_Iphone13();

            Test_Charge_Iphone14();
        }

        #region Tests

        private void Test_ChargeABit_Iphone13()
        {
            FakeLogger fakeLogger = new FakeLogger();

            IPhone13 iphone = new IPhone13(20, "123", fakeLogger);

            iphone.ChargeABit();

            if (iphone.BatteryLevel == 21 &&
                fakeLogger.FakeLoggerLog.Count == 1 &&
                fakeLogger.FakeLoggerLog[0].Key == "Charging 123 by 1%" &&
                fakeLogger.FakeLoggerLog[0].Value == MessageType.Message)
            {
                writeResult.Invoke(nameof(Test_ChargeABit_Iphone13) + " passed", ConsoleColor.Green);

                return;
            }

            writeResult.Invoke(nameof(Test_ChargeABit_Iphone13) + " failed", ConsoleColor.Red);
        }

        private void Test_Charge_Iphone14()
        {
            FakeLogger fakeLogger = new FakeLogger();

            IPhone13 iphone = new IPhone13(8, "123", fakeLogger);
            iphone.Charge();

            if (iphone.BatteryLevel == 100 &&
                fakeLogger.FakeLoggerLog.Count == 1 &&
                fakeLogger.FakeLoggerLog[0].Key == "Charging 123 to 100%" &&
                fakeLogger.FakeLoggerLog[0].Value == MessageType.Message)
            {
                writeResult.Invoke(nameof(Test_Charge_Iphone14) + " has passed", ConsoleColor.Green);

                return;
            }

            writeResult.Invoke(nameof(Test_Charge_Iphone14) + " has failed", ConsoleColor.Red);
        }

        private void Test_CallAmbulance_ThrowException_IPhone13()
        {
            FakeLogger fakeLogger = new FakeLogger();

            IPhone13 phone13 = new IPhone13(2, "123", fakeLogger);

            try
            {
                phone13.CallForAmbulance();
            }
            catch (BatteryIsDeadException bs)
            {
                if (bs.Phone?.BatteryLevel == 0)
                {
                    writeResult.Invoke(nameof(Test_CallAmbulance_ThrowException_IPhone13) + " passed", ConsoleColor.Green);
                }

                return;
            }

            writeResult.Invoke(nameof(Test_CallAmbulance_ThrowException_IPhone13) + " failed", ConsoleColor.Red);
        }

        private void Test_CallAmbulance_Work_And_Log_IPhone13()
        {
            FakeLogger fakeLogger = new FakeLogger();

            IPhone13 phone13 = new IPhone13(10, "Test1", fakeLogger);

            phone13.CallForAmbulance();

            if (fakeLogger.FakeLoggerLog.Count == 1 &&
                fakeLogger.FakeLoggerLog[0].Key == $"Calling an ambulance for phone Test1 remaining charge 5%" &&
                fakeLogger.FakeLoggerLog[0].Value == MessageType.Message &&

                phone13.BatteryLevel == 5
                )
            {

                writeResult.Invoke(nameof(Test_CallAmbulance_Work_And_Log_IPhone13) + " passed", ConsoleColor.Green);

                return;
            }

            writeResult.Invoke(nameof(Test_CallAmbulance_Work_And_Log_IPhone13) + " failed", ConsoleColor.Red);
        }

        private void Test_Contructor_Throwing_Excpetion_Iphone13()
        {
            try
            {
                IPhone13 phone13 = new IPhone13(-5, "123", null);
            }
            catch (ArgumentException)
            {
                writeResult.Invoke(nameof(Test_Contructor_Throwing_Excpetion_Iphone13) + " has passed", ConsoleColor.Green);
                return;
            }

            writeResult.Invoke(nameof(Test_Contructor_Throwing_Excpetion_Iphone13) + " has failed", ConsoleColor.Red);
        }

        #endregion
    }
}