using DIVanyshyn_Task4;
using System;
using System.Linq;
using Prog = DIVanyshyn_Task4.Program;

namespace DIvanyshyn_UnitTests_Day1
{
    internal class ProgramPhonesTests : ITestable
    {
        public ProgramPhonesTests(Action<string, ConsoleColor> writeResult)
        {
            WriteResult = writeResult;
        }

        public Action<string, ConsoleColor> WriteResult { get; }

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
                WriteResult.Invoke($"{nameof(Test_Catch_Exception_And_Charge)} has passed", ConsoleColor.Green);

                return;
            }

            WriteResult.Invoke($"{nameof(Test_Catch_Exception_And_Charge)} is failed", ConsoleColor.Red);
        }

        private void Test_Catch_Exception_And_Charge()
        {
            PhoneEmeregencyTestHolder phones = new PhoneEmeregencyTestHolder();
            Phone phone = new IPhone13(1, "123", new FakeLogger());
            phones.Add(phone);

            Prog.RunProgram(phones, 1);

            if (phone.BatteryLevel == 100)
            {
                WriteResult.Invoke($"{nameof(Test_Catch_Exception_And_Charge)} has passed", ConsoleColor.Green);

                return;
            }

            WriteResult.Invoke($"{nameof(Test_Catch_Exception_And_Charge)} is failed", ConsoleColor.Red);
        }

        private void Test_Create_Holder_Count_Of_CreatedPhones_is_2()
        {
            PhoneEmeregencyTestHolder holder = Prog.CreateHolder(new int[] { 1 }, new FakeLogger());

            if (holder.Count() == 2)
            {
                WriteResult.Invoke($"{nameof(Test_Create_Holder_Count_Of_CreatedPhones_is_2)} has passed", ConsoleColor.Green);

                return;
            }

            WriteResult.Invoke($"{nameof(Test_Create_Holder_Count_Of_CreatedPhones_is_2)} has failed", ConsoleColor.Red);
        }
    }
}