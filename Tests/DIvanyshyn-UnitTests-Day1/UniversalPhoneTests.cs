using DIVanyshyn_Task4;
using System;

namespace DIvanyshyn_UnitTests_Day1
{
    internal class UniversalPhoneTests : ITestable
    {
        private Action<string, ConsoleColor> writeResult;
        private Type type;

        public UniversalPhoneTests(Action<string, ConsoleColor> writeResult, Type phoneType)
        {
            this.writeResult = writeResult;
            this.type = phoneType;
        }

        public void RunAll()
        {
            Test_Contructor_Throwing_Excpetion_Phone(-1, "123", this.type);
            Test_Contructor_Throwing_Excpetion_Phone(101, "123", this.type);

            Test_CallAmbulance_ThrowException_Phone(2, "123", this.type);
            Test_CallAmbulance_ThrowException_Phone(1, "123", this.type);

            Test_CallAmbulance_Log_Phone(6, "123", this.type);
            Test_CallAmbulance_Log_Phone(96, "123", this.type);

            Test_CallAmbulance_Work_Phone(6, "123", this.type);
            Test_CallAmbulance_Work_Phone(7, "123", this.type);

            Test_ChargeABit_Log_Phone(3, "123", this.type);
            Test_ChargeABit_Log_Phone(2, "123", this.type);

            Test_ChargeABit_Work_Phone(3, "123", this.type);
            Test_ChargeABit_Work_Phone(2, "123", this.type);

            Test_Charge_Log_Phone(3, "123", this.type);
            Test_Charge_Work_Phone(3, "123", this.type);
        }

        #region Tests

        private void Test_ChargeABit_Log_Phone(int batteryLevel, string name, Type type)
        {
            FakeLogger fakeLogger = new FakeLogger();

            Phone phone = PhoneBuilder.GetPhone(batteryLevel, name, type, fakeLogger);

            phone.ChargeABit();

            if (fakeLogger.FakeLoggerLog.Count == 1 &&
                fakeLogger.FakeLoggerLog[0].Key == $"Charging {name} by 1%" &&
                fakeLogger.FakeLoggerLog[0].Value == MessageType.Message)
            {
                writeResult.Invoke(nameof(Test_ChargeABit_Log_Phone) + " passed", ConsoleColor.Green);

                return;
            }

            writeResult.Invoke(nameof(Test_ChargeABit_Log_Phone) + " failed", ConsoleColor.Red);
        }

        private void Test_ChargeABit_Work_Phone(int batteryLevel, string name, Type type)
        {
            FakeLogger fakeLogger = new FakeLogger();

            Phone phone = PhoneBuilder.GetPhone(batteryLevel, name, type, fakeLogger);

            phone.ChargeABit();

            if (phone.BatteryLevel == (batteryLevel + 1))
            {
                writeResult.Invoke(nameof(Test_ChargeABit_Log_Phone) + " passed", ConsoleColor.Green);

                return;
            }

            writeResult.Invoke(nameof(Test_ChargeABit_Log_Phone) + " failed", ConsoleColor.Red);
        }

        private void Test_Charge_Log_Phone(int batteryLevel, string name, Type type)
        {
            FakeLogger fakeLogger = new FakeLogger();

            Phone phone = PhoneBuilder.GetPhone(batteryLevel, name, type, fakeLogger);
            phone.Charge();

            if (fakeLogger.FakeLoggerLog.Count == 1 &&
                fakeLogger.FakeLoggerLog[0].Key == $"Charging {name} to 100%" &&
                fakeLogger.FakeLoggerLog[0].Value == MessageType.Message)
            {
                writeResult.Invoke(nameof(Test_Charge_Log_Phone) + " has passed", ConsoleColor.Green);

                return;
            }

            writeResult.Invoke(nameof(Test_Charge_Log_Phone) + " has failed", ConsoleColor.Red);
        }

        private void Test_Charge_Work_Phone(int batteryLevel, string name, Type type)
        {
            FakeLogger fakeLogger = new FakeLogger();

            Phone phone = PhoneBuilder.GetPhone(batteryLevel, name, type, fakeLogger);
            phone.Charge();

            if (phone.BatteryLevel == 100)
            {
                writeResult.Invoke(nameof(Test_Charge_Log_Phone) + " has passed", ConsoleColor.Green);

                return;
            }

            writeResult.Invoke(nameof(Test_Charge_Log_Phone) + " has failed", ConsoleColor.Red);
        }

        private void Test_CallAmbulance_ThrowException_Phone(int batteryLevel, string name, Type type)
        {
            FakeLogger fakeLogger = new FakeLogger();

            Phone phone = PhoneBuilder.GetPhone(batteryLevel, name, type, fakeLogger);

            try
            {
                phone.CallForAmbulance();
            }
            catch (BatteryIsDeadException bs)
            {
                if (bs.Phone?.BatteryLevel == 0)
                {
                    writeResult.Invoke(nameof(Test_CallAmbulance_ThrowException_Phone) + " passed", ConsoleColor.Green);
                }

                return;
            }

            writeResult.Invoke(nameof(Test_CallAmbulance_ThrowException_Phone) + " failed", ConsoleColor.Red);
        }

        private void Test_CallAmbulance_Log_Phone(int batteryLevel, string name, Type type)
        {
            FakeLogger fakeLogger = new FakeLogger();

            Phone phone = PhoneBuilder.GetPhone(batteryLevel, name, type, fakeLogger);

            phone.CallForAmbulance();

            if (fakeLogger.FakeLoggerLog.Count == 1 &&
                fakeLogger.FakeLoggerLog[0].Key == $"Calling an ambulance for phone {name} remaining charge {batteryLevel - 5}%" &&
                fakeLogger.FakeLoggerLog[0].Value == MessageType.Message)
            {

                writeResult.Invoke(nameof(Test_CallAmbulance_Log_Phone) + " passed", ConsoleColor.Green);

                return;
            }

            writeResult.Invoke(nameof(Test_CallAmbulance_Log_Phone) + " failed", ConsoleColor.Red);
        }

        private void Test_CallAmbulance_Work_Phone(int batteryLevel, string name, Type type)
        {
            FakeLogger fakeLogger = new FakeLogger();

            Phone phone = PhoneBuilder.GetPhone(batteryLevel, name, type, fakeLogger);

            phone.CallForAmbulance();

            if (phone.BatteryLevel == (batteryLevel - 5))
            {

                writeResult.Invoke(nameof(Test_CallAmbulance_Log_Phone) + " passed", ConsoleColor.Green);

                return;
            }

            writeResult.Invoke(nameof(Test_CallAmbulance_Log_Phone) + " failed", ConsoleColor.Red);
        }

        private void Test_Contructor_Throwing_Excpetion_Phone(int batteryLevel, string name, Type type)
        {
            try
            {
                Phone phone = PhoneBuilder.GetPhone(batteryLevel, name, type, null);
            }
            catch (ArgumentException)
            {
                writeResult.Invoke(nameof(Test_Contructor_Throwing_Excpetion_Phone) + " has passed", ConsoleColor.Green);

                return;
            }

            writeResult.Invoke(nameof(Test_Contructor_Throwing_Excpetion_Phone) + " has failed", ConsoleColor.Red);
        }

        #endregion
    }
}