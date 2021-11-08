using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using WebApplication1.Repository;

namespace WebApplication1.Controllers
{
    public class UserController : Controller
    {
        public ActionResult Index()
        {

            return View(RepositoryUser.GetUsers());
        }

        public ActionResult Create()
        {

            return View("CreateEdit",new User());
        }

        [HttpPost]
        public ActionResult Create(User user)
        {
            if (ModelState.IsValid)
            {
                RepositoryUser.Create(user);

                return RedirectToAction("Index");
            }

            return View("CreateEdit");
        }

        public ActionResult LiveSearch(string search)
        {
            List<User> res = (
                from t in RepositoryUser.GetUsers()
                where t.LastName.ToLower().Contains(search.ToLower())
                select t
            ).ToList();

            return PartialView("UserList",res);
        }

        public ActionResult Edit(int id)
        {
            User user = RepositoryUser.GetById(id);
            return View("CreateEdit",user);
        }

        [HttpPost]
        public ActionResult Edit(User user)
        {
            if (ModelState.IsValid)
            {
                RepositoryUser.Edit(user);

                return RedirectToAction("Index");
            }

            return View("CreateEdit");
        }

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            User user = RepositoryUser.GetById(id);

            RepositoryUser.Delete(user);

            return PartialView("UserList", RepositoryUser.GetUsers());
        }
    }
}
