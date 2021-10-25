using DIVanyshyn_Task4;
using Moq;
using NUnit.Framework;
using System;

namespace DIvanyshyn_UnitTests_Day1
{
    [TestFixture]
    public class PhoneEmeregencyHolderTests
    {
        #region Tests

        [TestCase(4, "123", typeof(IPhone13))]
        [TestCase(3, "123", typeof(IPhone13))]
        [TestCase(2, "123", typeof(IPhone13))]
        public void Test_PhoneEmergencyHolder_LogException(int batteryLevel, string name, Type phoneType)
        {
            Mock<ILogger> mockLogger = new Mock<ILogger>();

            PhoneEmeregencyTestHolder phones = new();
            Phone phone = PhoneBuilder.GetPhone(batteryLevel, name, phoneType, mockLogger.Object);
            phones.Add(phone);


            Assert.Throws<BatteryIsDeadException>(() => PhoneEmeregencyTestHolder.TestEmeregency(phones));

            mockLogger.Verify(l => l.WriteLine($"Phone failed to call an ambulance: {phone.GetType().Name}", MessageType.Exception),
                Times.Once);
        }

        [TestCase(4, "123", typeof(IPhone13), 1)]
        [TestCase(3, "123", typeof(IPhone13), 1)]
        public void Test_PhoneEmeregencyHolder_Rethrow_Excpetion_And_Charge_A_Bit(int batteryLevel, string name, Type phoneType, int expectedBatteryLevel)
        {
            Mock<ILogger> mockLogger = new Mock<ILogger>();
            PhoneEmeregencyTestHolder phones = new();
            phones.Add(PhoneBuilder.GetPhone(batteryLevel, name, phoneType, mockLogger.Object));

            var bs = Assert.Throws<BatteryIsDeadException>(() => PhoneEmeregencyTestHolder.TestEmeregency(phones));
            Assert.AreEqual(expectedBatteryLevel, bs.Phone?.BatteryLevel);
        }

        [TestCase(3, "123", 4)]
        [TestCase(4, "123", 4)]
        public void Test_For_Nokia_Case(int batteryLevel, string name, int expectedBatteryLevel)
        {
            Mock<ILogger> mockLogger = new Mock<ILogger>();
            PhoneEmeregencyTestHolder phones = new();
            Nokia nokia = (Nokia)PhoneBuilder.GetPhone(batteryLevel, name, typeof(Nokia), mockLogger.Object);
            phones.Add(nokia);

            PhoneEmeregencyTestHolder.TestEmeregency(phones);

            Assert.AreEqual(expectedBatteryLevel, nokia.BatteryLevel);
        }

        [TestCase(4, "123", typeof(IPhone13))]
        [TestCase(3, "123", typeof(IPhone13))]
        public void Test_PhoneEmeregencyHolder_Rethrow_Excpetion(int batteryLevel, string name, Type phoneType)
        {
            Mock<ILogger> mockLogger = new Mock<ILogger>();
            PhoneEmeregencyTestHolder phones = new();
            phones.Add(PhoneBuilder.GetPhone(batteryLevel, name, phoneType, mockLogger.Object));

            Assert.Throws<BatteryIsDeadException>(() => PhoneEmeregencyTestHolder.TestEmeregency(phones));
        }

        [TestCase(6, "1123", typeof(IPhone13), 2)]
        [TestCase(6, "1123", typeof(Nokia), 2)]
        public void Test_PhoneEmeregencyHolder_Charge_A_Bit(int batteryLevel, string name, Type phoneType, int expectedBatteryLevel)
        {
            Mock<ILogger> mockLogger = new Mock<ILogger>();
            PhoneEmeregencyTestHolder phones = new();
            Phone phone = PhoneBuilder.GetPhone(batteryLevel, name, phoneType, mockLogger.Object);
            phones.Add(phone);

            PhoneEmeregencyTestHolder.TestEmeregency(phones);

            Assert.AreEqual(expectedBatteryLevel, phone.BatteryLevel);
        }

        #endregion
    }
}