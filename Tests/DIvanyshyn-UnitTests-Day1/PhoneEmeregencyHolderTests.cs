using DIVanyshyn_Task4;
using System;

namespace DIvanyshyn_UnitTests_Day1
{
    internal class PhoneEmeregencyHolderTests : ITestable
    {
        private Action<string> logSuccess;
        private Action<string> logFailure;

        public PhoneEmeregencyHolderTests(Action<string> logSuccess, Action<string> logFailure)
        {
            this.logSuccess = logSuccess;
            this.logFailure = logFailure;
        }



        public void RunAll()
        {
            Test_PhoneEmeregencyHolder_Rethrow_Excpetion(3, "123", typeof(IPhone13));
            Test_PhoneEmeregencyHolder_Rethrow_Excpetion(4, "123", typeof(IPhone13));

            Test_For_Nokia_Case(3, "123", 4);
            Test_For_Nokia_Case(4, "123", 4);

            Test_Charge_A_Bit();

            Test_PhoneEmergencyHolder_LogException(4, "123", typeof(IPhone13));
            Test_PhoneEmergencyHolder_LogException(3, "123", typeof(IPhone13));
            Test_PhoneEmergencyHolder_LogException(2, "123", typeof(IPhone13));
        }

        #region Tests

        private void Test_PhoneEmergencyHolder_LogException(int batteryLevel, string name, Type phoneType)
        {
            FakeLogger fakeLogger = new FakeLogger();

            PhoneEmeregencyTestHolder phones = new();
            Phone phone = PhoneBuilder.GetPhone(batteryLevel, name, phoneType, fakeLogger);
            phones.Add(phone);

            try
            {
                PhoneEmeregencyTestHolder.TestEmeregency(phones);
            }
            catch (BatteryIsDeadException bs)
            {
                if (fakeLogger.FakeLoggerLog.Count == 2
                    && fakeLogger.FakeLoggerLog[0].Key == $"Phone failed to call an ambulance: {phone.GetType().Name}"
                    && fakeLogger.FakeLoggerLog[0].Value == MessageType.Exception)
                {
                    logSuccess.Invoke(nameof(Test_PhoneEmergencyHolder_LogException));

                    return;
                }
            }

            logFailure.Invoke(nameof(Test_PhoneEmergencyHolder_LogException));
        }

        private void Test_PhoneEmeregencyHolder_Rethrow_Excpetion_And_Charge_A_Bit(int batteryLevel, string name, Type phoneType, int expectedBatteryLevel)
        {
            PhoneEmeregencyTestHolder phones = new();
            phones.Add(PhoneBuilder.GetPhone(batteryLevel, name, phoneType, new FakeLogger()));

            try
            {
                PhoneEmeregencyTestHolder.TestEmeregency(phones);
            }
            catch (BatteryIsDeadException bs)
            {
                if (bs.Phone?.BatteryLevel == expectedBatteryLevel)
                {
                    logSuccess.Invoke(nameof(Test_PhoneEmeregencyHolder_Rethrow_Excpetion_And_Charge_A_Bit));
                    return;
                }
            }

            logFailure.Invoke(nameof(Test_PhoneEmeregencyHolder_Rethrow_Excpetion_And_Charge_A_Bit));
        }

        private void Test_For_Nokia_Case(int batteryLevel, string name, int expectedBatteryLevel)
        {
            PhoneEmeregencyTestHolder phones = new();
            Nokia nokia = (Nokia)PhoneBuilder.GetPhone(batteryLevel, name, typeof(Nokia), new FakeLogger());
            phones.Add(nokia);

            try
            {
                PhoneEmeregencyTestHolder.TestEmeregency(phones);

                if (nokia.BatteryLevel == expectedBatteryLevel)
                {
                    logSuccess.Invoke(nameof(Test_For_Nokia_Case));

                    return;
                }
            }
            catch
            {

            }

            logFailure.Invoke(nameof(Test_For_Nokia_Case));
        }

        private void Test_Charge_A_Bit()
        {
            Test_PhoneEmeregencyHolder_Rethrow_Excpetion_And_Charge_A_Bit(4, "123", typeof(IPhone13), 1);
            Test_PhoneEmeregencyHolder_Rethrow_Excpetion_And_Charge_A_Bit(3, "123", typeof(IPhone13), 1);

            Test_PhoneEmeregencyHolder_Charge_A_Bit(6, "1123", typeof(IPhone13), 2);
            Test_PhoneEmeregencyHolder_Charge_A_Bit(6, "1123", typeof(Nokia), 2);
        }

        private void Test_PhoneEmeregencyHolder_Rethrow_Excpetion(int batteryLevel, string name, Type phoneType)
        {
            PhoneEmeregencyTestHolder phones = new();
            phones.Add(PhoneBuilder.GetPhone(batteryLevel, name, phoneType, new FakeLogger()));

            try
            {
                PhoneEmeregencyTestHolder.TestEmeregency(phones);
            }
            catch (BatteryIsDeadException bs)
            {
                logSuccess.Invoke(nameof(Test_PhoneEmeregencyHolder_Rethrow_Excpetion));
                return;
            }

            logFailure.Invoke(nameof(Test_PhoneEmeregencyHolder_Rethrow_Excpetion));
        }

        private void Test_PhoneEmeregencyHolder_Charge_A_Bit(int batteryLevel, string name, Type phoneType, int expectedBatteryLevel)
        {
            PhoneEmeregencyTestHolder phones = new();
            Phone phone = PhoneBuilder.GetPhone(batteryLevel, name, phoneType, new FakeLogger());
            phones.Add(phone);

            PhoneEmeregencyTestHolder.TestEmeregency(phones);

            if (phone.BatteryLevel == expectedBatteryLevel)
            {
                logSuccess.Invoke(nameof(Test_PhoneEmeregencyHolder_Charge_A_Bit));

                return;
            }

            logFailure.Invoke(nameof(Test_PhoneEmeregencyHolder_Charge_A_Bit));
        }

        #endregion
    }
}