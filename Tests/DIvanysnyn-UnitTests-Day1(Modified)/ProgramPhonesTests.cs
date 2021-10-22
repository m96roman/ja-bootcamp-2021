using DIVanyshyn_Task4;
using Moq;
using NUnit.Framework;
using System;
using System.Linq;
using Prog = DIVanyshyn_Task4.Program;

namespace DIvanyshyn_UnitTests_Day1
{
    [TestFixture]
    public class ProgramPhonesTests
    {
        [TestCase(2, 1, "123", typeof(IPhone13), 96)]
        [TestCase(3, 4, "123", typeof(IPhone13), 92)]
        public void Test_Catch_Excpetion_And_Loop_Is_not_Interrupted(int iterationCount, int batteryLevel, string name, Type phoneType, int expectedBatteryLevel)
        {
            Mock<ILogger> mockLogger = new Mock<ILogger>();
            PhoneEmeregencyTestHolder phones = new PhoneEmeregencyTestHolder();
            Phone phone = PhoneBuilder.GetPhone(batteryLevel, name, phoneType, mockLogger.Object);
            phones.Add(phone);

            Prog.RunProgram(phones, iterationCount);

            //B=1->then handling Error B=100
            //B=100-5->B++

            Assert.AreEqual(expectedBatteryLevel, phone.BatteryLevel);
        }

        [TestCase(new int[] { 1, 2, 3 }, 6)]
        [TestCase(new int[] { 1 }, 2)]
        public void Test_Create_Holder_Count_Of_CreatedPhones_is_2(int[] batteryLevelsEnum, int expectedPhonesCount)
        {
            Mock<ILogger> mockLogger = new Mock<ILogger>();
            PhoneEmeregencyTestHolder holder = Prog.CreateHolder(batteryLevelsEnum, mockLogger.Object);

            Assert.AreEqual(expectedPhonesCount, holder.Count());
        }
    }
}