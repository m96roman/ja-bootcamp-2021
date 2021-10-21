using DIvanyshyn_8.AssembliesExample;
using NUnit.Framework;

namespace DIvanyhyn_UnitTests_Day2
{
    [TestFixture]
    public class ApiTests
    {

        [TestCase("controller/get", 8)]
        [TestCase("controller/post", "Method Post in MyController is called")]
        [TestCase("controller/put", "Method Put in MyController is called")]
        [TestCase("controller/delete", "Method Delete in MyController is called")]
        public void Test_Get_Method(string route, object expectedResult)
        {
            Api api = new Api(new FakeLogger());

            Assert.AreEqual(expectedResult, api.CallEndpoint(route).Result);
        }

        [TestCase("/random/controller/path/go/put")]
        public void Test_Return_Null(string route)
        {
            Assert.IsNull(CallEndpoint(route));
        }

        [TestCase("///")]
        [TestCase("111,2,3")]
        [TestCase("test;/case")]
        public void Test_ThrowArgumentException(string route)
        {
            Assert.That(() => CallEndpoint(route),
                Throws.ArgumentException);
        }

        [Test]
        public void Test_ThrowArgumentNullException()
        {
            Assert.That(() => CallEndpoint(null),
                Throws.ArgumentNullException);
        }

        private ActionResult CallEndpoint(string path)
        {
            Api api = new Api(new FakeLogger());

            return api.CallEndpoint(path);
        }
    }
}