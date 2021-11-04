using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HW_Day1_v1.Models;

namespace HW_Day1_v1.Controllers
{
    public class UserController : Controller
    {
        private BLL.UserHolder _usersHolder = BLL.UserHolder.GetInstance();

        // GET: User
        public ActionResult Index()
        {
            return View(_usersHolder);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(User user)
        {
            _usersHolder.Add(user);
            return View("Index", _usersHolder);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            return View(GetUserByID(id));
        }

        [HttpPost]
        public ActionResult Edit(User user)
        {
            _usersHolder.Edit(user);
            return View("Index", _usersHolder);
        }

        [HttpGet]
        [ActionName("Delete")]
        public ActionResult ConfirmDelete(int id)
        {
            return View(GetUserByID(id));
        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteById(int id)
        {
            _usersHolder.Delete(id);
            return View("Index", _usersHolder);
        }

        private User GetUserByID(int id)
        {
            return _usersHolder.First(u => u.Id == id);
        }
    }
}