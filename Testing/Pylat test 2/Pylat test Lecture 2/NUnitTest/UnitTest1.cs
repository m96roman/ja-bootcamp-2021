using NUnit.Framework;
using Pylat_Task_4;
using System;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        readonly Nokia nokia;
        readonly Nokia nokia1;
        readonly Nokia nokia2;
        readonly Nokia nokia3;
        readonly Nokia nokia4;
        readonly Nokia nokia5;
        readonly Nokia nokia6;
        readonly Nokia nokia7;

        public Tests()
        {
            nokia = new Nokia("Nokia", 1);
            nokia1 = new Nokia("Nokia", 10);
            nokia2 = new Nokia("Nokia", 1);
            nokia3 = new Nokia("Nokia", 1);
            nokia4 = new Nokia("Nokia", 2);
            nokia5 = new Nokia("Nokia", 2);
            nokia6 = new Nokia("Nokia", 10);
            nokia7 = new Nokia("Nokia", 93);
        }

        [Test]
        public void Test1_Phone_Nokia_1_CallAmbulance()
        {
            var ex = Assert.Throws<PhoneExceptions>(() => nokia.CallAmbulance());
            Assert.AreEqual(0, ex.phone.BateryLevel);
        }

        [Test]
        public void Test2_Phone_Nokia_10_CallAmbulance()
        {
            nokia1.CallAmbulance();
            Assert.AreEqual(5, nokia1.BateryLevel);
        }

        [Test]
        public void Test3_Phone_Nokia_1_Charge()
        {
            nokia2.Charge();
            Assert.AreEqual(100, nokia2.BateryLevel);
        }

        [Test]
        public void Test4_Phone_Nokia_1_ChargeABit()
        {
            nokia3.ChargeABit();
            Assert.AreEqual(2, nokia3.BateryLevel);
        }

        [Test]
        public void Test5_Phone_Nokia_2_BatteryIsDeadException()
        {
            var ex = Assert.Throws<PhoneExceptions>(() => nokia5.BatteryIsDeadException());
            Assert.AreEqual(2, nokia5.BateryLevel);
        }

        [TestCase(-1)]
        [TestCase(-10)]
        [TestCase(120)]
        public void Test6_Phone_Nokia_NotCreatedException(int bataryLevel)
        {
            Assert.Throws<ArgumentException>(() => new Nokia("", bataryLevel));
        }

        [Test]
        public void Test7_Phone_Nokia_10_PrayForBatary_BataryLowerThan93()
        {
            nokia6.PrayForBattery();
            Assert.AreEqual(18, nokia6.BateryLevel);
        }

        [Test]
        public void Test8_Phone_Nokia_93_PrayForBatary_BataryLevelIs93()
        {
            nokia7.PrayForBattery();
            Assert.AreEqual(100, nokia7.BateryLevel);
        }
    }
}