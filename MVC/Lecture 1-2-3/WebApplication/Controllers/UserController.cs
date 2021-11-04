using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using WebApplication.Models;
using WebApplication.Repositories;
using WebApplication.Binders;

namespace WebApplication.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View(UserRepository.GetUsers());
        }

        public ActionResult Insert()
        {
            return View();
        }
       
        [HttpPost]
        public ActionResult Insert([ModelBinder(typeof(CreateUserBinder))] User user)
        {
            UserRepository.InsertUser(user);
            return RedirectToAction("Index");
        }

        public ActionResult Update(int id)
        {
            return View(UserRepository.GetUserById(id));
        }

        [HttpPost]
        public ActionResult Update(User user)
        {
            UserRepository.UpdateUser(user);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            return View(UserRepository.GetUserById(id));
        }

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            UserRepository.DeleteUser(UserRepository.GetUserById(id));
            return RedirectToAction("Index");
        }

        public ActionResult Search()
        {
            return View(UserRepository.GetUsers());
        }

        public JsonResult SearchText(string str)
        {
            List<User> users = new List<User>();
            users = UserRepository.GetUsersSearch(str).ToList();
            return Json(users, JsonRequestBehavior.AllowGet);
        }
    }
}