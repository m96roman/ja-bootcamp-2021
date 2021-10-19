using NUnit.Framework;
using System.Collections.Generic;
using TDD_KFedak;

namespace EmployeeUnitTest
{
    [TestFixture]
    public class EmployeeDetailsUnitTest
    {
        List<EmployeeDetails> users;

        [Test]
        public void CheckDetails()
        {
            Program pobj = new Program();

            users = pobj.AllUsers();

            foreach (var user in users)
            {
                Assert.IsNotNull(user.Id);
                Assert.IsNotNull(user.Name);
                Assert.IsNotNull(user.Salary);
                Assert.IsNotNull(user.Geneder);
            }
        }

        [Test]
        public void TestLogin()
        {
            Program pobj = new Program();
            string x = pobj.Login("Ajit", "1234");
            string y = pobj.Login("", "");
            string z = pobj.Login("Admin", "Admin");
            Assert.AreEqual("Userid or password could not be Empty.", y);
            Assert.AreEqual("Incorrect UserId or Password.", x);
            Assert.AreEqual("Welcome Admin.", z);
        }

        [Test]
        public void GetUserDetails()
        {
            Program pobj = new Program();
            var detsilsOfUsers = pobj.GetDetails(100);
            foreach (var user in detsilsOfUsers)
            {
                Assert.AreEqual(user.Id, 100);
                Assert.AreEqual(user.Name, "Bharat");
            }
        }
    }
}
