using IPlyskaLect4;
using NUnit.Framework;
using System;

namespace IPlyska.NUnitTest
{
    [TestFixture]
    public class PhoneUnitTest
    {
        Phone phone;
        [SetUp]
        public void Setup()
        {
             phone = new Phone();
        }

        [TestCase(0, 100)]
        [TestCase(20, 100)]
        [TestCase(99, 100)]
        public void Test_Charge(int value, int expectedValue)
        {
            //arrange
            phone.BatteryLevel = value;
            //act
            phone.Charge();
            //Assert
            Assert.AreEqual(expectedValue, phone.BatteryLevel);
        }

        [TestCase(4)]
        [TestCase(22)]
        [TestCase(100)]
        [TestCase(0)]
        public void Test_Prop_BatteryLevel(int value)
        {
            //arrange
            phone.BatteryLevel = value;
            //Assert
            Assert.AreEqual(phone.BatteryLevel, value);
        }

        [TestCase(101, typeof(InappropriateBatteryLevelValueException))]
        [TestCase(-1, typeof(InappropriateBatteryLevelValueException))]
        [TestCase(-10, typeof(InappropriateBatteryLevelValueException))]
        [TestCase(110, typeof(InappropriateBatteryLevelValueException))]
        public void Test_Prop_BatteryLevelWithInpropValue(int value, Type expectedEx)
        {
            //arrange
           
            //act
            var actEx = Assert.Catch<InappropriateBatteryLevelValueException>(() => phone.BatteryLevel = value);
            //Assert
            Assert.AreEqual(expectedEx, actEx.GetType());
        }

        [TestCase(40, 41)]
        [TestCase(2, 3)]
        [TestCase(33, 34)]
        [TestCase(1, 2)]
        public void Test_ChargeABit(int value, int expectedValue)
        {
            //arrange
            phone.BatteryLevel = value;
            //act
            phone.ChargeABit();
            //Assert
            Assert.AreEqual(expectedValue, phone.BatteryLevel);
            
        }

        [TestCase(5, 0)]
        [TestCase(6, 1)]
        [TestCase(10, 5)]
        [TestCase(7, 2)]
        [TestCase(44, 39)]
        public void Test_CallAmbulanceWithCorrectValue(int value, int expectedValue)
        {
            //arrange
            phone.BatteryLevel = value;
            //act
            phone.CallAmbulance();
            //Assert
            Assert.AreEqual(expectedValue, phone.BatteryLevel);
        }

        [TestCase(4, typeof(BatteryIsDeadException))]
        [TestCase(3, typeof(BatteryIsDeadException))]
        [TestCase(2, typeof(BatteryIsDeadException))]
        [TestCase(1, typeof(BatteryIsDeadException))]
        [TestCase(0, typeof(BatteryIsDeadException))]
        public void Test_CallAmbulanceWithInCorrectValue(int value, Type expectedEx)
        {
            //arrange
            phone.BatteryLevel = value;
            //act
            var actEx = Assert.Catch<BatteryIsDeadException>(() => phone.CallAmbulance());
            //Assert
            Assert.AreEqual(expectedEx, actEx.GetType());

        }
    }
}