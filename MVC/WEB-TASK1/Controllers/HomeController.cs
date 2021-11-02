using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WEB_TASK1.Models;

namespace WEB_TASK1.Controllers
{
    public class HomeController : Controller
    {
        private static int iterator = 0;

        private static int Iterator()
        {
            return iterator++;
        }

        private readonly ILogger<HomeController> _logger;

        private static List<UserModel> SelectedUsers = new List<UserModel>();

        private static List<UserModel> UsersList = new List<UserModel>(){
                    new UserModel{UserId = Iterator(), UserName = "Jhon", UserSurname = "Doe" },
                     new UserModel{UserId = Iterator(), UserName = "Martin", UserSurname = "Roshko" },
                };

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public ViewResult Index()
        {
            var user = new UserModel();
            return View(user);
        }

        public ViewResult Users()
        {
            return View(UsersList);
        }

        [HttpPost]
        public ActionResult CreateUser(UserModel userModel)
        {
            userModel.UserId = Iterator();
            UsersList.Add(userModel);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult DeleteUser(int? id)
        {
            UsersList.Remove(UsersList.Where(u => u.UserId == id).FirstOrDefault());
            return RedirectToAction("Users");
        }

        [HttpPost]
        public ActionResult EditUser(int userId, string userName, string userSurname)
        {
            if (int.TryParse(userId.ToString(), out int ID) && userName != null && userSurname != null)
            {
                var editUser = UsersList.Where(u => u.UserId == ID).FirstOrDefault();
                editUser.UserName = userName;
                editUser.UserSurname = userSurname;
            }

            return RedirectToAction("Users");
        }

        /*[HttpPost]
        public ActionResult postCreateUser(UserModel userModel)
        {
            UsersList.Add(userModel);
            string message = "SUCCESS";
            return Json(new { Message = message, System.Web.Mvc.JsonRequestBehavior.AllowGet });
        }

        public JsonResult getUser()
        {
            return Json(UsersList, System.Web.Mvc.JsonRequestBehavior.AllowGet);
        }*/

        [HttpPost]
        public ActionResult FindUser(string userName)
        {
            if (userName != null)
            {
                SelectedUsers = new List<UserModel>();
                SelectedUsers.AddRange(UsersList.Where(u => userName.Contains(u.UserName) || userName.Contains(u.UserSurname)).ToList<UserModel>());

                return RedirectToAction("Users");
            }
            return RedirectToAction("Users");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
