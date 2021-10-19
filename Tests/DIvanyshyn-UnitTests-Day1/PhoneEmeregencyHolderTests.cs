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
            Test_PhoneEmeregencyHolder_Rethrow_Excpetion();

            Test_For_Nokia_Case();

            Test_Charge_A_Bit();

            Test_PhoneEmergencyHolder_LogException();
        }

        #region Tests

        private void Test_PhoneEmergencyHolder_LogException()
        {
            FakeLogger fakeLogger = new FakeLogger();

            PhoneEmeregencyTestHolder phones = new();
            Phone phone = new IPhone13(1, "123", fakeLogger);
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

        private void Test_PhoneEmeregencyHolder_Rethrow_Excpetion_And_Charge_A_Bit()
        {
            PhoneEmeregencyTestHolder phones = new();
            phones.Add(new IPhone13(2, "123", new FakeLogger()));

            try
            {
                PhoneEmeregencyTestHolder.TestEmeregency(phones);
            }
            catch (BatteryIsDeadException bs)
            {
                if (bs.Phone?.BatteryLevel == 1)
                {
                    logSuccess.Invoke(nameof(Test_PhoneEmeregencyHolder_Rethrow_Excpetion_And_Charge_A_Bit));
                    return;
                }
            }

            logFailure.Invoke(nameof(Test_PhoneEmeregencyHolder_Rethrow_Excpetion_And_Charge_A_Bit));
        }

        private void Test_For_Nokia_Case()
        {
            PhoneEmeregencyTestHolder phones = new();
            Nokia nokia = new Nokia(2, "123", new FakeLogger());
            phones.Add(nokia);

            try
            {
                PhoneEmeregencyTestHolder.TestEmeregency(phones);

                if (nokia.BatteryLevel == 4)
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
            Test_PhoneEmeregencyHolder_Rethrow_Excpetion_And_Charge_A_Bit();

            Test_PhoneEmeregencyHolder_Charge_A_Bit();
        }

        private void Test_PhoneEmeregencyHolder_Rethrow_Excpetion()
        {
            PhoneEmeregencyTestHolder phones = new();
            phones.Add(new IPhone13(2, "123", new FakeLogger()));

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

        private void Test_PhoneEmeregencyHolder_Charge_A_Bit()
        {
            PhoneEmeregencyTestHolder phones = new();
            Phone phone = new IPhone13(10, "123", new FakeLogger());
            phones.Add(phone);

            PhoneEmeregencyTestHolder.TestEmeregency(phones);

            if (phone.BatteryLevel == 6)
            {
                logSuccess.Invoke(nameof(Test_PhoneEmeregencyHolder_Charge_A_Bit));

                return;
            }

            logFailure.Invoke(nameof(Test_PhoneEmeregencyHolder_Charge_A_Bit));
        }

        #endregion
    }
}