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
        // GET: User
        public ActionResult Users()
        {
            var listOfUsers = new List<User>();


            for (int i = 0; i < 10; i++)
            {
                listOfUsers.Add(new User() { Id = i, Name = $"User{i}", LastName = $"LastName{i}" });
            }
            return View(listOfUsers);
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            return View();  
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            return View(new User() { Id = id });
        }

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            var listOfUsers = new List<User>();

            for (int i = 0; i < 10; i++)
            {
                if (i == id)
                {
                    continue;
                }

                listOfUsers.Add(new User() { Id = i, Name = $"User{i}", LastName = $"LastName{i}" });
            }
            return View("Users", listOfUsers);
        }
    }
}