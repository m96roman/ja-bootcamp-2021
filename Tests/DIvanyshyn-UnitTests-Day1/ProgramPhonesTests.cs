using DIVanyshyn_Task4;
using System;
using System.Linq;
using Prog = DIVanyshyn_Task4.Program;

namespace DIvanyshyn_UnitTests_Day1
{
    internal class ProgramPhonesTests : ITestable
    {
        private Action<string> logSucces;
        private Action<string> logFailure;

        public ProgramPhonesTests(Action<string> logSucces, Action<string> logFailure)
        {
            this.logSucces = logSucces;
            this.logFailure = logFailure;
        }

        public void RunAll()
        {
            Test_Create_Holder_Count_Of_CreatedPhones_is_2();

            Test_Catch_Exception_And_Charge();

            Test_Catch_Excpetion_And_Loop_Is_not_Interrupted();
        }

        private void Test_Catch_Excpetion_And_Loop_Is_not_Interrupted()
        {
            PhoneEmeregencyTestHolder phones = new PhoneEmeregencyTestHolder();
            Phone phone = new IPhone13(1, "123", new FakeLogger());
            phones.Add(phone);

            Prog.RunProgram(phones, 2);

            //B=1->then handling Error B=100
            //B=100-5->B++
            if (phone.BatteryLevel == 96)
            {
                logSucces.Invoke(nameof(Test_Catch_Exception_And_Charge));

                return;
            }

            logFailure.Invoke(nameof(Test_Catch_Exception_And_Charge));
        }

        private void Test_Catch_Exception_And_Charge()
        {
            PhoneEmeregencyTestHolder phones = new PhoneEmeregencyTestHolder();
            Phone phone = new IPhone13(1, "123", new FakeLogger());
            phones.Add(phone);

            Prog.RunProgram(phones, 1);

            if (phone.BatteryLevel == 100)
            {
                logSucces.Invoke(nameof(Test_Catch_Exception_And_Charge));

                return;
            }

            logFailure.Invoke(nameof(Test_Catch_Exception_And_Charge));
        }

        private void Test_Create_Holder_Count_Of_CreatedPhones_is_2()
        {
            PhoneEmeregencyTestHolder holder = Prog.CreateHolder(new int[] { 1 }, new FakeLogger());

            if (holder.Count() == 2)
            {
                logSucces.Invoke(nameof(Test_Create_Holder_Count_Of_CreatedPhones_is_2));

                return;
            }

            logFailure.Invoke(nameof(Test_Create_Holder_Count_Of_CreatedPhones_is_2));
        }
    }
}