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
             new User() { Id = 3, Name = $"User1", LastName = $"LastName1" },
           new User() { Id = 4, Name = $"User2", LastName = $"LastName2" },
             new User() { Id = 5, Name = $"User1", LastName = $"LastName1" },
           new User() { Id = 6, Name = $"User2", LastName = $"LastName2" }
       };
     
    // GET: User
    public ActionResult Users()
        {
         
            return View(listOfUsers);
        }

       
        public ActionResult Delete(int id)
        {
            listOfUsers.Remove(listOfUsers.Where(p=>p.Id==id).FirstOrDefault());

            return  RedirectToAction("Users");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            return View(listOfUsers.Where(p=>p.Id == id).FirstOrDefault());
        }

        [HttpPost]
        public ActionResult Edit(User user)
        {
            var currentUser = listOfUsers.Where(p => p.Id == user.Id).FirstOrDefault();
            currentUser.Name = user.Name;
            currentUser.LastName = user.LastName;
            return RedirectToAction("Users");
        }
    }
}