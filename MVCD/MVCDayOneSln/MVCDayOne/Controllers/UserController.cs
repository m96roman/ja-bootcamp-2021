using Microsoft.AspNetCore.Mvc;
using MVCDayOne.Models;
using System.Collections.Generic;
using System.Linq;

namespace MVCDayOne.Controllers
{
    public class UserController : Controller
    {
        public static List<UserModel> Users = new List<UserModel>() {
            new UserModel {Id = 1, FirstName = "Piter", LastName = "Pan"},
            new UserModel {Id = 2, FirstName = "Jack", LastName = "Sparrow"},
            new UserModel {Id = 3, FirstName = "Pit", LastName = "Bonk"} };

        public ActionResult User()
        {
            UserModel users = new UserModel();
            return View(users);
        }
        
        [HttpPost]
        public ActionResult CreateUser(UserModel users)
        {
            Users.Add(users);
            return RedirectToAction("ShowUsers");
        }

        [HttpGet]
        public ActionResult ShowUsers()
        {
            return View(Users);
        }

        [HttpPost]
        public ActionResult DeleteUser(int id)
        {
            Users.Remove(Users.Where(x => x.Id == id).FirstOrDefault());

            return RedirectToAction("ShowUsers");
        }

        [HttpPost]
        public ActionResult Edit(UserModel editUser)
        {
            UserModel userData = Users.Where(x => x.Id == editUser.Id).FirstOrDefault();

            if(userData != null)
            {
                userData.FirstName = editUser.FirstName;
                userData.LastName = editUser.LastName;
            }

            return View();
        }
    }
}