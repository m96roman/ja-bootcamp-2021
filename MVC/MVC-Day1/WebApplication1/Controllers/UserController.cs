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

            return View(new User());
        }

        [HttpPost]
        public ActionResult Create(User user)
        {
            try
            {
                RepositoryUser.Create(user);

                return RedirectToAction("Index");
            }
            catch
            {
                return View(user);

            }
        }

        public ActionResult Edit(int id)
        {
            User user = RepositoryUser.GetById(id);
            return View(user);
        }

        [HttpPost]
        public ActionResult Edit(User user)
        {
            try
            {
                RepositoryUser.Edit(user);

                return RedirectToAction("Index");
            }
            catch
            {
                return View(user);
            }
        }

        public ActionResult Delete(int id)
        {
            User user = RepositoryUser.GetById(id);
            return View(user);
        }

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                User user = RepositoryUser.GetById(id);

                RepositoryUser.Delete(user);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
