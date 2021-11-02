using Lecture_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lecture_2.Controllers
{
    public class UserController : Controller
    {
        public static List<User> listOfUsers = new List<User>() {
           new User() { Id = 1, Name = $"User1", LastName = $"LastName1" },
           new User() { Id = 2, Name = $"User2", LastName = $"LastName2" }
       };

        // GET: User
        public ActionResult User()
        {
            return View(listOfUsers);
        }

        public JsonResult FilterUsers(string searchText = "")
        {
            var filtredUsers = listOfUsers.Where(user => user.Name.Contains(searchText)).ToList();

            return Json(filtredUsers, JsonRequestBehavior.AllowGet);
        }
    }
}