using KFedak_TDD;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using NUnit.Framework;
using System;
using Assert = NUnit.Framework.Assert;

namespace PhoneUnitTest
{
    public class Tests
    {
        public static FakeLogger InitLogger()
        {
            var logger = new FakeLogger();
            Program.logger = logger;
            return logger;
        }

        [Test]
        public void ChargeABitMessage()
        {
            //arrange
            Mock<ILogger> fileMock = new();
          //  Program.logger =fileMock.Object;

            //act
            Nokia phone = new Nokia(6, "5600", fileMock.Object);
            phone.ChargeABit();

            //assert
            fileMock.Verify(it=>it.WriteLine(new Exception($"Charging {phone.PhoneName} by 1%")),Times.Once);
        }

        [Test]
        public void CallAmbulanceLess5Message()
        {
            //arrange
            var logger = InitLogger();

            //act
            Nokia phone = new Nokia(4, "5600", logger);

            //assert
            var ex = Assert.Throws<BatteryIsDeadException>(() => phone.CallAmbulance());
            var message = logger.message.Find(m => m == $"Phone failed to call an ambulance: {phone.PhoneName}");
            Assert.That(ex.Message, Is.EqualTo(message));
        }

        [Test]
        public void CallAmbulanceMore5Message()
        {
            //arrange
            var logger = InitLogger();

            //act
            Nokia phone = new Nokia(9, "5600", logger);
            phone.CallAmbulance();

            //assert
            Assert.IsTrue(logger.message.Contains($"Calling an ambulance from {phone.PhoneName}, remaining charge: {phone.BatteryLevel}%"));
        }

        [Test]
        public void CheckChargeMessage()
        {
            //arrange
            var logger = InitLogger();

            //act
            Nokia phone = new Nokia(9, "5600",logger);
            phone.Charge();

            //assert
            Assert.IsTrue(logger.message.Contains($"Charging {phone.PhoneName} to 100%"));
        }

        [Test]
        public void CheckPrayForBatteryMessage()
        {
            //arrange
            var logger = InitLogger();

            //act
            Nokia phone = new Nokia(9, "5600", logger);
            phone.PrayForBattery();

            //assert
            Assert.IsTrue(logger.message.Contains("Praying for the battery"));
        }

        [Test]
        public void CallAmbulanceCatchException()
        {
            //arrange
            var logger = InitLogger();

            //act
            Nokia phone = new Nokia(3, "5600", logger);
           
            //assert
            var ex = Assert.Throws<BatteryIsDeadException>(() => phone.CallAmbulance());
            Assert.That(ex.Message, Is.EqualTo($"Phone failed to call an ambulance: {phone.PhoneName}"));
        }

        [Test]
        public void ConstructorForPhoneCatchException()
        {
            //arrange
            var logger = InitLogger();

            //assert
            var ex = Assert.Throws<InvalidValueForBattery>(() => new Nokia(-3,"8800",logger));
            Assert.That(ex.Message, Is.EqualTo("Invalid value!"));
        }

        [Test]
        public void ChargeValue()
        {
            //arrange
            var logger = InitLogger();

            //act
            Nokia phone = new Nokia(3, "5600", logger);
            phone.Charge();

            //assert
            Assert.That(phone.BatteryLevel, Is.EqualTo(100));
        }

        [Test]
        public void ChargeABitValue()
        {
            //arrange
            var logger = InitLogger();

            //act
            Nokia phone = new Nokia(19, "5600", logger);
            phone.ChargeABit();

            //assert
            Assert.That(phone.BatteryLevel, Is.EqualTo(20));
        }

        [Test]
        public void PrayForABatteryValue()
        {
            //arrange
            var logger = InitLogger();

            //act
            Nokia phone = new Nokia(19, "5600", logger);
            phone.PrayForBattery();

            //assert
            Assert.That(phone.BatteryLevel, Is.EqualTo(27));
        }

        [Test]
        public void CallAmbulanceMoreThan5Value()
        {
            //arrange
            var logger = InitLogger();

            //act
            Nokia phone = new Nokia(19, "5600", logger);
            phone.CallAmbulance();

            //assert
            Assert.That(phone.BatteryLevel, Is.EqualTo(14));
        }

        [Test]
        public void CallAmbulanceLessThan5Value()
        {
            //arrange
            var logger = InitLogger();

            //act
            Nokia phone = new Nokia(4, "5600", logger);

            //assert
            var ex = Assert.Throws<BatteryIsDeadException>(() => phone.CallAmbulance());
            Assert.That(ex.Telephone.BatteryLevel, Is.EqualTo(0));
        }

        [Test]
        public void ConstructorPhoneValue()
        {
            //arrange
            var logger = InitLogger();

            //act
            Nokia phone = new Nokia(4, "5600", logger);

            //assert
            Assert.That(phone.BatteryLevel, Is.EqualTo(4));
        }

        [Test]
        public void ConstructorPhoneValueAfterException()
        {
            //arrange
            var logger = InitLogger();

            //assert
            var ex = Assert.Throws<InvalidValueForBattery>(() => new Nokia(-3, "8800", logger));
            Assert.That(ex.BatteryLevel, Is.EqualTo(0));
        }

    }
}