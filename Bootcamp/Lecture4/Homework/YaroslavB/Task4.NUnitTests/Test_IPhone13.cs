using System;
using NUnit.Framework;
using Yaroslav_Task4;
using Moq;

namespace Task4.NunitTest
{
    [TestFixture]
    public class Test_IPhone13
    {
        private IPhone13 InitIPhone13(int initBateryLevel)
        {
            return new IPhone13(initBateryLevel);
        }

        private IPhone13 InitIPhone13WithLoggerMock(int initBateryLevel, out Mock<ILogger> loggerMock)
        {
            loggerMock = new Mock<ILogger>();
            return new IPhone13(initBateryLevel, loggerMock.Object);
        }


        [TestCase(0)]
        [TestCase(62)]
        [TestCase(100)]
        public void BateryLevel_HappyPath(int initBateryLevel)
        {
            //arrange & act
            IPhone13 instance = InitIPhone13(initBateryLevel);

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
            //arrange
            IPhone13 instance = InitIPhone13(initBateryLevel);

            //act
            instance.CallAmbulance();

            //assert
            Assert.That(instance.BatteryLevel, Is.EqualTo(expected));
        }


        [TestCase("Calling an ambulance from iPhone 13")]
        public void CallAmbulance_OutputMessageShouldStartWith(string startString)
        {
            //arrange
            int initBateryLevel = 10;
            IPhone13 instance = InitIPhone13WithLoggerMock(initBateryLevel, out Mock<ILogger> loggerMock);

            //arrange & act
            instance.CallAmbulance();
            int invocationsCount = loggerMock.Invocations.Count;
            string outputMessage = loggerMock.Invocations[0].Arguments[0].ToString();

            //assert
            Assert.AreEqual(1, invocationsCount, $"Invocations count:");
            Assert.IsTrue(outputMessage.StartsWith(startString), $"Output message: <{outputMessage}> is starting with expected substring: <{startString}>");
        }


        [TestCase(3)]
        public void CallAmbulance_GivenValue_5_orLess_ShouldThrowException(int initBateryLevel)
        {
            //arrange
            IPhone13 instance = InitIPhone13(initBateryLevel);

            //act & assert
            BatteryIsDeadException ex = Assert.Throws<BatteryIsDeadException>(() => instance.CallAmbulance());
            Assert.That(ex.PhoneInstance, Is.Not.Null);
        }


        [TestCase(3)]
        [TestCase(4)]
        public void CallAmbulance_GivenValue_5_orLess_ShouldSetValueAt_0(int initBateryLevel)
        {
            //arrange
            int expectedLevel = 0;
            IPhone13 instance = InitIPhone13(initBateryLevel);

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
            IPhone13 instance = InitIPhone13(initBateryLevel);

            //act
            instance.Charge();

            //assert
            Assert.AreEqual(expectedLevel, instance.BatteryLevel);
        }


        [TestCase("Charging iPhone 13 to 100%")]
        public void Charge_ShouldPrintMessage(string message)
        {
            //arrange
            int initBateryLevel = 10;
            IPhone13 instance = InitIPhone13WithLoggerMock(initBateryLevel, out Mock<ILogger> loggerMock);

            //act
            instance.Charge();

            //assert
            loggerMock.Verify(ins => ins.Log(message, MessageType.Warning));
        }


        [TestCase(15, 16)]
        [TestCase(89, 90)]
        public void ChargeABit_IncreaseBateryLevelBy_1(int initBateryLevel, int expectedLevel)
        {
            //act
            IPhone13 instance = InitIPhone13(initBateryLevel);

            //act
            instance.ChargeABit();

            //assert
            Assert.AreEqual(expectedLevel,instance.BatteryLevel);
        }


        [TestCase("Charging", "by 1%")]
        public void ChargeABit_OutputMessageShouldStartWith(string startString, string endString)
        {
            //arrange
            int initBateryLevel = 10;
            IPhone13 instance = InitIPhone13WithLoggerMock(initBateryLevel, out Mock<ILogger> loggerMock);

            //arrange & act
            instance.ChargeABit();
            int invocationsCount = loggerMock.Invocations.Count;
            string outputMessage = loggerMock.Invocations[0].Arguments[0].ToString();

            //assert
            Assert.IsTrue(invocationsCount == 1);
            Assert.IsTrue(outputMessage.StartsWith(startString), $"Output message: <{outputMessage}> is starting with expected substring: <{startString}>");
            Assert.IsTrue(outputMessage.EndsWith(endString), $"Output message: <{outputMessage}> is ending with expected substring: <{endString}>");
        }
    }
}