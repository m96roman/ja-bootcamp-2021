using Microsoft.AspNetCore.Mvc;
using MVCDayOne.Models;
using System.Collections.Generic;

namespace MVCDayOne.Controllers
{
    public class UserController : Controller
    {
        public static List<UserModel> Users = new List<UserModel>() {
            new UserModel {FirstName = "Piter", LastName = "Pan"} }; 

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

        public ActionResult DeleteUser()
        {
            //Users.Remove(Users.Where());
            return RedirectToAction("ShowUsers");
        }
    }
}