using Microsoft.AspNetCore.Mvc;
using MVCDayOne.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace MVCDayOne.Controllers
{
    public class UserController : Controller
    {
        public static List<UserModel> Users = new List<UserModel>() {
            new UserModel {FirstName = "Piter", LastName = "Pan"}, 
            new UserModel {FirstName = "John", LastName = "Kick"},
            new UserModel {FirstName = "Rob", LastName = "Bob"},
            new UserModel {FirstName = "Hugh", LastName = "Jack"}
        }; 
        
        public ActionResult User()
        {
            UserModel users = new UserModel();
            return View(users);
        }
        
        [HttpPost]
        public ActionResult CreateUser(UserModel users)
        {
            Users.Add(users);
            return RedirectToAction("SearchUser");
        }

        [HttpGet]
        public ActionResult ShowUsers()
        {
            return View(Users);
        }

        public ActionResult DeleteUser(UserModel user)
        {
            Users.Remove(user);
            return RedirectToAction("ShowUsers");
        }

        public ActionResult SearchUser()
        {
            return View(Users);
        }

        [HttpPost]
        public JsonResult SearchingData(string SearchBy, [Required]string SearchValue)
        {
            List<UserModel> userModel = new List<UserModel>();

            if (SearchBy == "FirstName")
            {
                try
                {
                    userModel = Users.Where(x => x.FirstName.Contains(SearchValue)).ToList();
                }
                catch (System.Exception)
                {
                    System.Console.WriteLine($"{SearchValue} is incorrect");
                }
                return Json(userModel);
            }
            else
            {
                userModel = Users.Where(x => x.LastName.Contains(SearchValue)).ToList();
                return Json(userModel);
            }
        }
    }
}