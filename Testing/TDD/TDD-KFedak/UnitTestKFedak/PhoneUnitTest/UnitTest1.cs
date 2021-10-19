using KFedak_TDD;
using NUnit.Framework;

namespace PhoneUnitTest
{
    public class Tests
    {
        
        public FakeLogger InitLogger()
        {
            var logger = new FakeLogger();
            KFedak_TDD.Program.logger = logger;
            return logger;
        }

        [Test]
        public void ChargeABitMessage()
        {
            //arrange
            FakeLogger fakeLogger = InitLogger();

            //act
            Nokia phone = new Nokia(6, "5600", fakeLogger);
            phone.ChargeABit();
            //assert
            Assert.IsTrue(fakeLogger.message.Contains($"Charging {phone.PhoneName} by 1%"));
        }
    }
}