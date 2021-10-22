using DIVanyshyn_Task4;
using Moq;
using NUnit.Framework;
using System;

namespace DIvanyshyn_UnitTests_Day1
{
    [TestFixture]
    public class UniversalPhoneTests
    {
        #region Tests

        [TestCase(3, "123", typeof(IPhone13))]
        [TestCase(2, "123", typeof(IPhone13))]
        public void Test_ChargeABit_Log_Phone(int batteryLevel, string name, Type type)
        {
            Mock<ILogger> mockLogger = new();

            Phone phone = PhoneBuilder.GetPhone(batteryLevel, name, type, mockLogger.Object);

            phone.ChargeABit();

            mockLogger.Verify(l => l.WriteLine($"Charging {name} by 1%", MessageType.Message));
        }

        [TestCase(3, "123", typeof(IPhone13), 4)]
        [TestCase(2, "123", typeof(IPhone13), 3)]
        public void Test_ChargeABit_Work_Phone(int batteryLevel, string name, Type type, int expectedValue)
        {
            Mock<ILogger> mockLogger = new();

            Phone phone = PhoneBuilder.GetPhone(batteryLevel, name, type, mockLogger.Object);

            phone.ChargeABit();

            Assert.AreEqual(expectedValue, phone.BatteryLevel);
        }

        [TestCase(3, "123", typeof(IPhone13))]
        public void Test_Charge_Log_Phone(int batteryLevel, string name, Type type)
        {
            Mock<ILogger> mockLogger = new();

            Phone phone = PhoneBuilder.GetPhone(batteryLevel, name, type, mockLogger.Object);
            phone.Charge();

            mockLogger.Verify(l => l.WriteLine($"Charging {name} to 100%", MessageType.Message));
        }

        [TestCase(3, "123", typeof(IPhone13))]
        public void Test_Charge_Work_Phone(int batteryLevel, string name, Type type)
        {
            Mock<ILogger> mockLogger = new();

            Phone phone = PhoneBuilder.GetPhone(batteryLevel, name, type, mockLogger.Object);
            phone.Charge();

            Assert.AreEqual(100, phone.BatteryLevel);
        }

        [TestCase(3, "123", typeof(IPhone13))]
        [TestCase(4, "123", typeof(IPhone13))]
        public void Test_CallAmbulance_ThrowException_Phone(int batteryLevel, string name, Type type)
        {
            Mock<ILogger> mockLogger = new();

            Phone phone = PhoneBuilder.GetPhone(batteryLevel, name, type, mockLogger.Object);

            var excp = Assert.Throws<BatteryIsDeadException>(() => phone.CallForAmbulance());

            Assert.That(excp.Phone?.BatteryLevel == 0);
        }

        [TestCase(96, "123", typeof(IPhone13), 91)]
        [TestCase(6, "123", typeof(IPhone13), 1)]
        public void Test_CallAmbulance_Log_Phone(int batteryLevel, string name, Type type, int expectedBatteryLevel)
        {
            Mock<ILogger> mockLogger = new();

            Phone phone = PhoneBuilder.GetPhone(batteryLevel, name, type, mockLogger.Object);

            phone.CallForAmbulance();

            mockLogger.Verify(l => l.WriteLine($"Calling an ambulance for phone {name} remaining charge {expectedBatteryLevel}%", MessageType.Message),
                Times.Once);
        }

        [TestCase(96, "123", typeof(IPhone13), 91)]
        [TestCase(6, "123", typeof(IPhone13), 1)]
        public void Test_CallAmbulance_Work_Phone(int batteryLevel, string name, Type type, int expectedValue)
        {
            Mock<ILogger> mockLogger = new();

            Phone phone = PhoneBuilder.GetPhone(batteryLevel, name, type, mockLogger.Object);

            phone.CallForAmbulance();

            Assert.AreEqual(expectedValue, phone.BatteryLevel);
        }

        [TestCase(-1, "123", typeof(IPhone13))]
        [TestCase(101, "123", typeof(IPhone13))]
        public void Test_Contructor_Throwing_Excpetion_Phone(int batteryLevel, string name, Type type)
        {
            Assert.Throws<ArgumentException>(() => PhoneBuilder.GetPhone(batteryLevel, name, type, null));
        }

        #endregion
    }
}