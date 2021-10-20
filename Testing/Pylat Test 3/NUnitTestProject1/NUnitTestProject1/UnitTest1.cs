using NUnit.Framework;
using Task_1;

namespace Tests
{
    public class Tests
    {
        Controller controller = new Controller();
        Api api = new Api();
        [SetUp]
        public void Setup()
        {
                  }

        [Test]
        public void Test1_NameIs_Null()
        {
                        Assert.AreEqual(null, controller.Name);
        }

        [Test]
        public void Test2_Get_RouteIsNull()
        {
            api.CallEndpoint(null);
            Assert.AreEqual(8 , controller.Get());
        }

        [Test]
        public void Test3_Post_Route()
        {
            api.CallEndpoint("/controller/post");
            Assert.AreEqual("Post method executed in controller", controller.Post());
        }

        [Test]
        public void Test4_Put_Route()
        {
            api.CallEndpoint("/controller/put");
            Assert.AreEqual("Put method executed in controller", controller.Put());
        }

        [Test]
        public void Test5_Put_Route()
        {
            api.CallEndpoint("/controller/delete");
            Assert.AreEqual("Delete method executed in controller", controller.Delete());
        }
    }
}