using System;
using NUnit.Framework;
using Yaroslav_Task4;

namespace Task4.NunitTest
{
    [TestFixture]
    public class Test_IPhone13
    {
        private Nokia InitIPhone13(int initBateryLevel)
        {
            return new Nokia(initBateryLevel);
        }


        [TestCase(0)]
        [TestCase(62)]
        [TestCase(100)]
        public void BateryLevel_HappyPath(int initBateryLevel)
        {
            //arrange & act
            Nokia instance = InitIPhone13(initBateryLevel);

            //assert
            Assert.That(instance.BatteryLevel, Is.EqualTo(initBateryLevel));
        }


        [TestCase(-1)]
        [TestCase(101)]
        public void BateryLevel_GivenValueOutOfRange_0_100_ShouldThrowException(int initBateryLevel)
        {
            //assert
            Assert.Throws<ArgumentOutOfRangeException>(() => InitIPhone13(initBateryLevel));
        }


        [TestCase(40, 35)]
        [TestCase(7, 2)]
        public void CallAmbulance_GivenValueInRange_SetValueShouldBeDecreasedBy_5(int initBateryLevel, int expected)
        {
            //arrange & act
            Nokia instance = InitIPhone13(initBateryLevel);

            //act
            instance.CallAmbulance();

            //assert
            Assert.That(instance.BatteryLevel, Is.EqualTo(expected));
        }


        [TestCase("Calling an ambulance from")]
        public void CallAmbulance_OutputMessageShouldStartWith(string outputMessage)
        {
            //arrange
            int initBateryLevel = 10;

            //arrange & act
            Nokia instance = InitIPhone13(initBateryLevel);

            //assert
            Assert.Fail();
        }


        [TestCase(3)]
        public void CallAmbulance_GivenValue_5_orLess_ShouldThrowException(int initBateryLevel)
        {
            //arrange & act
            Nokia instance = InitIPhone13(initBateryLevel);

            //act & assert
            //Assert.That(() => instance.CallAmbulance(), Throws.TypeOf<BatteryIsDeadException>()); //add description
            BatteryIsDeadException ex = Assert.Throws<BatteryIsDeadException>(() => instance.CallAmbulance());
            Assert.That(ex.PhoneInstance, Is.Not.Null);

        }


        [TestCase(3)]
        [TestCase(4)]
        public void CallAmbulance_GivenValue_5_orLess_ShouldSetValueAt_0(int initBateryLevel)
        {
            //arrange
            int expectedLevel = 0;

            //arrange & act
            Nokia instance = InitIPhone13(initBateryLevel);

            //act & assert
            Assert.That(() => instance.CallAmbulance(), Throws.Exception);
            Assert.AreEqual(expectedLevel, instance.BatteryLevel);
        }


        [Test]
        public void Charge_IncreaseBateryLevelUpto_100()
        {
            //arrange
            int expectedLevel = 100;
            int initBateryLevel = 10;

            //arrange & act
            Nokia instance = InitIPhone13(initBateryLevel);
            instance.Charge();

            //assert
            Assert.AreEqual(expectedLevel, instance.BatteryLevel);
        }


        [TestCase("Charging", "to 100%")]
        public void Charge_OutputMessageShouldStartWith_EndWith(string startString, string endString)
        {
            //arrange
            int initBateryLevel = 10;
            
            //arrange & act
            Nokia instance = InitIPhone13(initBateryLevel);
            instance.Charge();

            //assert
            Assert.Fail();
        }


        [TestCase(15, 16)]
        [TestCase(89, 90)]
        public void ChargeABit_IncreaseBateryLevelBy_1(int initBateryLevel, int expectedLevel)
        {
            //arrange & act
            Nokia instance = InitIPhone13(initBateryLevel);
            instance.ChargeABit();

            //assert
            Assert.AreEqual(expectedLevel,instance.BatteryLevel);
        }


        [TestCase("Charging", "by 1%")]
        public void ChargeABit_OutputMessageShouldStartWith(string startString, string endString)
        {
            //arrange
            int initBateryLevel = 10;

            //arrange & act
            Nokia instance = InitIPhone13(initBateryLevel);
            instance.ChargeABit();

            //assert
            Assert.Fail();
        }
    }
}