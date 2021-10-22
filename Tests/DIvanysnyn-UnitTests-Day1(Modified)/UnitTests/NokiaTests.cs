using DIVanyshyn_Task4;
using Moq;
using NUnit.Framework;
using System;

namespace DIvanyshyn_UnitTests_Day1
{
    [TestFixture]
    public class NokiaTests
    {
        private void PrayForBatteryInit(string Name, int batteryLevel, ref Nokia nokia, ref Mock<ILogger> mockLogger)
        {
            mockLogger = new Mock<ILogger>();

            nokia = (Nokia)PhoneBuilder.GetPhone(batteryLevel, Name, typeof(Nokia), mockLogger.Object);

            nokia.PrayForBattery();
        }

        [TestCase(1, "123", 9)]
        [TestCase(4, "123", 12)]
        public void Test_PrayForBattery_Work_Nokia(int batteryLevel, string Name, int expectedValue)
        {
            Nokia nokia = null;
            Mock<ILogger> fakeLogger = null;

            PrayForBatteryInit(Name, batteryLevel, ref nokia, ref fakeLogger);

            Assert.AreEqual(expectedValue, nokia.BatteryLevel);
        }

        [TestCase(1, "123")]
        [TestCase(4, "123")]
        public void Test_PrayForBattery_Log_Nokia(int batteryLevel, string Name)
        {
            Nokia nokia = null;
            Mock<ILogger> mockLogger = null;

            PrayForBatteryInit(Name, batteryLevel, ref nokia, ref mockLogger);

            mockLogger.Verify(l => l.WriteLine("Praying for battery (Thank god for another day with Nokia)", MessageType.Message),
                Times.Once);
        }
    }
}