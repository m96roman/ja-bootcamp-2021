﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using WEB_TASK1.Models;
using System.Text.Json;
using System.IO;
using WEB_TASK1.Models.Binders;

namespace WEB_TASK1.Controllers
{
    public class HomeController : Controller
    {       
       

        private readonly ILogger<HomeController> _logger;

        private static List<UserModel> SelectedUsers = new List<UserModel>();

        private static List<UserModel> UsersList = new List<UserModel>();

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
        public ActionResult CreateUser([ModelBinder(BinderType = typeof(UserModelBinder))] UserModel userModel)
        {
            UsersList.Add(userModel);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult DeleteUser(int? id)
        {
            UsersList.Remove(UsersList.Where(u => u.UserId == id).FirstOrDefault());
            return Json(UsersList);
        }

        [HttpPost]
        public ActionResult EditUser( UserModel userModel)
        {
            if (userModel.UserName != null && userModel.UserSurname != null)
            {
                var editUser = UsersList.Where(u => u.UserId == userModel.UserId).FirstOrDefault();
                editUser.UserName = userModel.UserName;
                editUser.UserSurname = userModel.UserSurname;
            }

            return Json(userModel);
        }

        public JsonResult GetUsers()
        {
            return Json(UsersList);
        }       

        [HttpPost]
        public ActionResult FindUser(string userName)
        {
            SelectedUsers.Clear();
            if (userName != null)
            {
                SelectedUsers.AddRange(UsersList.Where(u => userName.Contains(u.UserName) || userName.Contains(u.UserSurname)).ToList<UserModel>());
            }

            return Json(SelectedUsers);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        private static void WriteDataIntoFile()
        {
            string path = $@"{Directory.GetCurrentDirectory()}\Data.json";

            string jsonWriter = JsonSerializer.Serialize(UsersList);

        }
    }
}
