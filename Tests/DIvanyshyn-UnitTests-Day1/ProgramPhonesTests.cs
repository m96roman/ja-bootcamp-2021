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
            Test_Create_Holder_Count_Of_CreatedPhones_is_2(new int[] { 1, 2, 3 }, 6);
            Test_Create_Holder_Count_Of_CreatedPhones_is_2(new int[] { 1 }, 2);

            Test_Catch_Excpetion_And_Loop_Is_not_Interrupted(iterationCount: 2, 1, "123", typeof(IPhone13), 96);
            Test_Catch_Excpetion_And_Loop_Is_not_Interrupted(iterationCount: 3, 4, "123", typeof(IPhone13), 92);
        }

        private void Test_Catch_Excpetion_And_Loop_Is_not_Interrupted(int iterationCount, int batteryLevel, string name, Type phoneType, int expectedBatteryLevel)
        {
            PhoneEmeregencyTestHolder phones = new PhoneEmeregencyTestHolder();
            Phone phone = PhoneBuilder.GetPhone(batteryLevel, name, phoneType, new FakeLogger());
            phones.Add(phone);

            Prog.RunProgram(phones, iterationCount);

            //B=1->then handling Error B=100
            //B=100-5->B++
            if (phone.BatteryLevel == expectedBatteryLevel)
            {
                logSucces.Invoke(nameof(Test_Catch_Excpetion_And_Loop_Is_not_Interrupted));

                return;
            }

            logFailure.Invoke(nameof(Test_Catch_Excpetion_And_Loop_Is_not_Interrupted));
        }



        private void Test_Create_Holder_Count_Of_CreatedPhones_is_2(int[] batteryLevelsEnum, int expectedPhonesCount)
        {
            PhoneEmeregencyTestHolder holder = Prog.CreateHolder(batteryLevelsEnum, new FakeLogger());

            if (holder.Count() == expectedPhonesCount)
            {
                logSucces.Invoke(nameof(Test_Create_Holder_Count_Of_CreatedPhones_is_2));

                return;
            }

            logFailure.Invoke(nameof(Test_Create_Holder_Count_Of_CreatedPhones_is_2));
        }
    }
}