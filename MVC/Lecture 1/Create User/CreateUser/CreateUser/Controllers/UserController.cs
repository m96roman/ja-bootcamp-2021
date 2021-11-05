using CreateUser.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CreateUser.Controllers
{
    public class UserController : Controller
    {
        public static List<User> listOfUsers = new List<User>() {
           new User() { Id = 1, Name = $"User1", LastName = $"LastName1" },
           new User() { Id = 2, Name = $"User2", LastName = $"LastName2" },
             new User() { Id = 3, Name = $"User3", LastName = $"LastName3" },
           new User() { Id = 4, Name = $"User4", LastName = $"LastName4" },
             new User() { Id = 5, Name = $"User5", LastName = $"LastName5" },
           new User() { Id = 6, Name = $"User6", LastName = $"LastName6" }
       };

        // GET: User
        public ActionResult Users()
        {

            return View(listOfUsers);
        }


        [HttpGet]
        public ActionResult Delete(int? id)
        {

            return View(listOfUsers.Where(p => p.Id == id).FirstOrDefault());
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View(new User());
        }

        [HttpPost]
        public ActionResult Create(User user)
        {
            var currentUser = user;
            listOfUsers.Add(currentUser);
            return RedirectToAction("Users");
        }

        [HttpPost]
        public ActionResult Delete(User user)
        {
            var currentUser = listOfUsers.Where(p => p.Id == user.Id).FirstOrDefault();
            listOfUsers.Remove(currentUser);

            return RedirectToAction("Users");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            return View(listOfUsers.Where(p => p.Id == id).First());
        }

        [HttpPost]
        public ActionResult Edit(User user)
        {
            var currentUser = listOfUsers.Where(p => p.Id == user.Id).First();
            currentUser.Name = user.Name;
            currentUser.LastName = user.LastName;
            return RedirectToAction("Users");
        }
    }
}