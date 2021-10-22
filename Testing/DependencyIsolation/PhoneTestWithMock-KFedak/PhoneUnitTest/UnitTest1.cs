using KFedak_TDD;
using Moq;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace PhoneUnitTest
{
    public class Tests
    {

        [Test]
        public void ChargeABitMessage()
        {
            //arrange
            Mock<ILogger> loggerMock = new();

            //act
            IPhone phone = new IPhone(6, "5600", loggerMock.Object);
            phone.ChargeABit();

            //assert
            loggerMock.Verify(it=>it.WriteLine($"Charging {phone.PhoneName} by 1%"),Times.Once);
        }

        [Test]
        public void CallAmbulanceLess5Message()
        {
            //arrange
            Mock<ILogger> loggerMock = new();
            Nokia phone = new Nokia(4, "5600", loggerMock.Object);

            //assert&&act
            Assert.Throws<BatteryIsDeadException>(() => phone.CallAmbulance());
            loggerMock.Verify(it => it.WriteLine($"Phone failed to call an ambulance: {phone.PhoneName}"), Times.Once);
        }

        [Test]
        public void CallAmbulanceMore5Message()
        {
            //arrange
            Mock<ILogger> loggerMock = new();

            //act
            Nokia phone = new Nokia(9, "5600", loggerMock.Object);
            phone.CallAmbulance();

            //assert
            loggerMock.Verify(it=>it.WriteLine($"Calling an ambulance from {phone.PhoneName}, remaining charge: {phone.BatteryLevel}%"),Times.Once);
        }

        [Test]
        public void CheckChargeMessage()
        {
            //arrange
            Mock<ILogger> loggerMock = new();

            //act
            Nokia phone = new Nokia(9, "5600", loggerMock.Object);
            phone.Charge();

            //assert
            loggerMock.Verify(it=>it.WriteLine($"Charging {phone.PhoneName} to 100%"), Times.Once);
        }

        [Test]
        public void CheckPrayForBatteryMessage()
        {
            //arrange
            Mock<ILogger> loggerMock = new();

            //act
            Nokia phone = new Nokia(9, "5600", loggerMock.Object);
            phone.PrayForBattery();

            //assert
            loggerMock.Verify(it=>it.WriteLine("Praying for the battery"), Times.Once);
        }

        [Test]
        public void ConstructorForPhoneCatchException()
        {
            //arrange
            Mock<ILogger> loggerMock = new();

            //assert&&act
            Assert.Throws<InvalidValueForBattery>(() => new Nokia(-3,"8800", loggerMock.Object));
            loggerMock.Verify(it => it.WriteLine($"Invalid value!"),Times.Once);
        }

        [Test]
        public void ChargeValue()
        {
            //arrange
            Mock<ILogger> loggerMock = new();

            //act
            Nokia phone = new Nokia(3, "5600", loggerMock.Object);
            phone.Charge();

            //assert
            Assert.That(phone.BatteryLevel, Is.EqualTo(100));
        }

        [Test]
        public void ChargeABitValue()
        {
            //arrange
            Mock<ILogger> loggerMock = new();

            //act
            Nokia phone = new Nokia(19, "5600", loggerMock.Object);
            phone.ChargeABit();

            //assert
            Assert.That(phone.BatteryLevel, Is.EqualTo(20));
        }

        [Test]
        public void PrayForABatteryValue()
        {
            //arrange
            Mock<ILogger> loggerMock = new();

            //act
            Nokia phone = new Nokia(19, "5600", loggerMock.Object);
            phone.PrayForBattery();

            //assert
            Assert.That(phone.BatteryLevel, Is.EqualTo(27));
        }

        [Test]
        public void CallAmbulanceMoreThan5Value()
        {
            //arrange
            Mock<ILogger> loggerMock = new();

            //act
            Nokia phone = new Nokia(19, "5600", loggerMock.Object);
            phone.CallAmbulance();

            //assert
            Assert.That(phone.BatteryLevel, Is.EqualTo(14));
        }

        [Test]
        public void CallAmbulanceLessThan5Value()
        {
            //arrange
            Mock<ILogger> loggerMock = new();

            //act
            Nokia phone = new Nokia(4, "5600", loggerMock.Object);

            //assert
            var ex = Assert.Throws<BatteryIsDeadException>(() => phone.CallAmbulance());
            Assert.That(ex.Telephone.BatteryLevel, Is.EqualTo(0));
        }

        [Test]
        public void ConstructorPhoneValue()
        {
            //arrange
            Mock<ILogger> loggerMock = new();

            //act
            Nokia phone = new Nokia(4, "5600", loggerMock.Object);

            //assert
            Assert.That(phone.BatteryLevel, Is.EqualTo(4));
        }

        [Test]
        public void ConstructorPhoneValueAfterException()
        {
            //arrange
            Mock<ILogger> loggerMock = new();

            //assert
            var ex = Assert.Throws<InvalidValueForBattery>(() => new Nokia(-3, "8800", loggerMock.Object));
            Assert.That(ex.BatteryLevel, Is.EqualTo(0));
        }

    }
}