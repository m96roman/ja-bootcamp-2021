using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting.Internal;
using Microsoft.Extensions.Logging;
using Moq;
using NUnit.Framework;
using PersonsMVC.Controllers;
using System;

namespace PersonsMVC.UnitTests
{
    [TestFixture]
    public class ValueControllerTests
    {
        //[TestCase("value/show/123", "123")]
        //[TestCase("value/123", "123")]
        //[TestCase("value/123", "No value provided")]
        //public void Route_Tests(string route, string expectedMessage)
        //{
        //    var server = TestServer.Create(_app, _services);
        //}

        [TestCase("123")]
        [TestCase("23222")]
        public void Value_Controller_Index(string id)
        {
            string response = GetResponseFromValueController(id);

            //Assert
            Assert.AreEqual(id, response);
        }

        private static string GetResponseFromValueController(string id)
        {
            //Arrange
            ValueController valueController = new ValueController();

            //Act
            string response = valueController.Index(id);
            return response;
        }

        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        public void Value_Controller_Returns_No_value_provided(string id)
        {
            string response = GetResponseFromValueController(id);

            Assert.AreEqual("No value provided", response);
        }
    }
}