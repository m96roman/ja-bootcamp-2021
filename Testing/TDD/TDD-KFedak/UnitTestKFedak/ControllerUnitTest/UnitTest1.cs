using KFedakT8;
using NUnit.Framework;

namespace ControllerUnitTest
{
    public class Tests
    {
        public static FakeLogger InitLogger()
        {
            ILogger logger = new FakeLogger();
            Program.logger = logger;
            return (FakeLogger)logger;
        }

        [Test]
        public void PostMethodMessage()
        {
            //arrange
            var logger = InitLogger();

            //act
            var api = new Api(logger);
            api.Controller.Post();

            //assert
            Assert.IsTrue(logger.message.Contains($"Post method executed in {api.Controller.Name} controller"));
        }

        [Test]
        public void PutMethodMessage()
        {
            //arrange
            var logger = InitLogger();

            //act
            var api = new Api(logger);
            api.Controller.Put();

            //assert
            Assert.IsTrue(logger.message.Contains($"Put method executed in {api.Controller.Name} controller"));
        }

        [Test]
        public void DeleteMethodMessage()
        {
            //arrange
            var logger = InitLogger();

            //act
            var api = new Api(logger);
            api.Controller.Delete();

            //assert
            Assert.IsTrue(logger.message.Contains($"Delete method execute in {api.Controller.Name} controller"));
        }

        [Test]
        [TestCase("Delete")]
        [TestCase("Put")]
        [TestCase("Post")]
        public void CallEndpointVoidMethodMessage(string methodName)
        {
            //arrange
            var logger = InitLogger();

            //act
            var api = new Api(logger);
            api.CallEndpoint($"/controller/{methodName.ToLower()}");
            var result = $"{methodName} method executed in {api.Controller.Name}";

            //assert
            Assert.IsTrue(logger.message.Contains($"Method {methodName} return {result}"));
        }

        [Test]
        [TestCase("Get")]
        public void CallEndpointValueMethodMessage(string methodName)
        {
            //arrange
            var logger = InitLogger();

            //act
            var api = new Api(logger);
            api.CallEndpoint($"/controller/{methodName.ToLower()}");
            var result=typeof(Controller).GetMethod(methodName).Invoke(api.Controller,null);

            //assert
            Assert.IsTrue(logger.message.Contains($"Method {methodName} return {result}"));
        }
    }
}