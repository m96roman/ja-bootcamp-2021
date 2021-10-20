using NUnit.Framework;
using Pylat_Task_4;
using System;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        readonly Nokia nokia;

        public Tests()
        {
        nokia = new Nokia("Nokia", 1);
        
        }

        [Test]
        public void Test1()
        {
            nokia.CallAmbulance();
            Assert.Throws<PhoneExceptions>;
            Assert.AreEqual(0, nokia.BateryLevel);
            
        }
    }
}