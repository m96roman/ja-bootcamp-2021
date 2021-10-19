using IPlyskaLect4;
using NUnit.Framework;

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

        [TestCase(0)]
        [TestCase(20)]
        [TestCase(99)]
        public void Test_Charge(int value)
        {
            //arrange
            var expectedValue = 100;
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

        [TestCase(101)]
        [TestCase(-1)]
        [TestCase(-10)]
        [TestCase(110)]
        public void Test_Prop_BatteryLevelWithInpropValue(int value)
        {
            //arrange
            var expectedEx = typeof(InappropriateBatteryLevelValueException);
            //act
            var actEx = Assert.Catch(() => phone.BatteryLevel = value);
            //Assert
            Assert.AreEqual(expectedEx, actEx.GetType());
        }

        [TestCase(40)]
        [TestCase(2)]
        [TestCase(33)]
        [TestCase(1)]
        public void Test_ChargeABit(int value)
        {
            //arrange
            phone.BatteryLevel = value;
            var expectedValue = ++value;
            //act
            phone.ChargeABit();
            //Assert
            Assert.AreEqual(expectedValue, phone.BatteryLevel);
            
        }

        [TestCase(5)]
        [TestCase(6)]
        [TestCase(10)]
        [TestCase(7)]
        [TestCase(44)]
        public void Test_CallAmbulanceWithCorrectValue(int value)
        {
            //arrange
            var expectedValue = value - 5;
            phone.BatteryLevel = value;
            //act
            phone.CallAmbulance();
            //Assert
            Assert.AreEqual(expectedValue, phone.BatteryLevel);
        }

        [TestCase(4)]
        [TestCase(3)]
        [TestCase(2)]
        [TestCase(1)]
        [TestCase(0)]
        public void Test_CallAmbulanceWithInCorrectValue(int value)
        {
            //arrange
            var expectedEx = typeof(BatteryIsDeadException);
            phone.BatteryLevel = value;
            //act
            var actEx = Assert.Catch(() => phone.CallAmbulance());
            //Assert
            Assert.AreEqual(expectedEx, actEx.GetType());

        }

    }
}