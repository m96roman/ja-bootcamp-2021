using Microsoft.AspNetCore.Mvc;
using MVCDayOne.Models;
using System.Collections.Generic;
using System.Linq;

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
        public JsonResult SearchingData(string SearchBy, string SearchValue)
        {
            List<UserModel> userModel = new List<UserModel>();

            if (SearchBy == "FirstName")
            {
                try
                {
                    string FirstName = SearchValue;
                    userModel = Users.Where(x => x.FirstName == FirstName).ToList();
                }
                catch (System.Exception)
                {
                    System.Console.WriteLine($"{SearchValue} is incorrect");
                }
                return Json(userModel, System.Web.Mvc.JsonRequestBehavior.AllowGet);
            }
            else
            {
                userModel = Users.Where(x => x.LastName.Contains(SearchValue)).ToList();
                return Json(userModel, System.Web.Mvc.JsonRequestBehavior.AllowGet);
            }
        }
    }
}