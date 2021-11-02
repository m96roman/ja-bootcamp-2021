using Microsoft.Extensions.Logging;
using Moq;
using NUnit.Framework;
using PersonsMVC.Controllers;
using PersonsMVC.Models.DPA;
using PersonsMVC.Models.Entities;
using System.Collections.Generic;

namespace PersonsMVC.UnitTests
{
    [TestFixture]
    public class HomeControllerTests
    {
        [Test]
        public void Get_Index()
        {
            Mock<IUserRepository> userMock = new Mock<IUserRepository>();
            //userStub.Setup(us => us.GetUsers()).Returns(new List<User>() { new("1", "2", "3") });

            Mock<ILogger<HomeController>> loggerMock = new Mock<ILogger<HomeController>>();

            HomeController homeController = new HomeController(loggerMock.Object, userMock.Object);

            homeController.Index();

            userMock.Verify(c => c.GetUsers());
        }
    }
}