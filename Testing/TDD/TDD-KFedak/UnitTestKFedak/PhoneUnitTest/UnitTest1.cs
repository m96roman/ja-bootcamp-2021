using KFedak_TDD;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace PhoneUnitTest
{
    public class Tests
    {
        public static FakeLogger InitLogger()
        {
            var logger = new FakeLogger();
            KFedak_TDD.Program.logger = logger;
            return logger;
        }

        [Test]
        public void ChargeABitMessage()
        {
            //arrange
            var logger = InitLogger();

            //act
            Nokia phone = new Nokia(6, "5600",logger);
            phone.ChargeABit();

            //assert
            Assert.IsTrue(logger.message.Contains($"Charging {phone.PhoneName} by 1%"));
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


    }
}