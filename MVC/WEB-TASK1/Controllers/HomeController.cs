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
        private readonly ILogger<HomeController> _logger;

        private static List<UserModel> UsersList = new List<UserModel>(){
                    new UserModel{UserName = "Jhon", UserSurname = "Doe" },
                     new UserModel{UserName = "Martin", UserSurname = "Roshko" },
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
            UsersList.Add(userModel);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult DeleteUser(int? id) 
        {
            UsersList.Remove(UsersList.Where(u => u.UserId == id).FirstOrDefault());           
            return RedirectToAction("Users");
        }
        /*  [HttpPost]
          public ActionResult Users(UserViewModel user)
          {
              UsersList.Add(user);

              return View(user);
          }*/

       /* [HttpGet]
        public ViewResult Users()
        {
            return View(UsersList);
        }*/


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
