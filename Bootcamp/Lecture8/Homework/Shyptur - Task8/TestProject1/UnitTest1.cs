using NUnit.Framework;
using Shyptur_Task8HW;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {

            var api = new Api();
          api.CallEndpoint("/controller/get",Loge);
           // Assert.That();
          
        }
    }
}