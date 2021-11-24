using Lecture_2.Models;
using Lecture_2_MVC.Models;
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
           new User() { Id = 2, Name = $"User2", LastName = $"LastName2" },
           new User() { Id =3, Name = $"User3", LastName = $"LastName3" },
           new User() { Id =4, Name = $"User4", LastName = $"LastName4" },
           new User() { Id = 5, Name = $"User5", LastName = $"LastName5" }
       };

        // GET: User
        public ActionResult User()
        {
            return View(listOfUsers);
        }

        public JsonResult FilterUsers(string searchText = "")
        {
            var filtredUsers = listOfUsers.Where(user => string.IsNullOrWhiteSpace(searchText) || user.Name.Contains(searchText)).ToList();

            return Json(filtredUsers, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult CreateUser()
        {

            return View(new User());
        }

        [HttpPost]
        public ActionResult CreateUser([ModelBinder(typeof(UserBinder))]User user)
        {
            listOfUsers.Add(user);

            return RedirectToAction("User");
        }
    }
}