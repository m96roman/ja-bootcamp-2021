using IPlyskaMVCPart1.BLL;
using IPlyskaMVCPart1.Interfaces;
using IPlyskaMVCPart1.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IPlyskaMVCPart1.Controllers
{
    public class UsersController : Controller
    {
        private readonly IUsersProvider _users;

        public UsersController(IUsersProvider users)
        {
            _users = users;
        }

        [HttpGet]
        [Route("user/get-all")]
        public IActionResult Index()
        {
            return View(_users.GetAllUsers());
        }

        [HttpPost]
        [Route("user/add")]
        public IActionResult Create(Users userEdited)
        {
            if (userEdited is null)
            {
                return ViewBag.ErrorMessage = "Error";
            }
            userEdited.Id = _users.GetAllUsers().Count;

            var status = _users.AddUser(userEdited);

            return RedirectToAction("index"); 
            //return View();
        }

        [HttpGet]
        [Route("user/add")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpGet]
        [Route("user/edit/{id}")]
        public ActionResult Edit(int id)
        {
            var data = _users.GetAllUsers().Where(x => x.Id == id).FirstOrDefault();
            return View(data);
        }

        [HttpPost]
        [Route("user/edit/{id}")]
        public ActionResult Edit(Users Model)
        {
            var data = _users.GetAllUsers().Where(x => x.Id == Model.Id).FirstOrDefault();
            if (data != null)
            {
                data.FirstName = Model.FirstName;
                data.LastName = Model.LastName;
            }

            return RedirectToAction("index");
        }

        [HttpGet]
        [Route("user/detail/{id}")]
        public ActionResult Detail(int id)
        {
            var data = _users.GetAllUsers().Where(x => x.Id == id).FirstOrDefault();
            return View(data);
        }
 
        public ActionResult Delete(int id)
        {
            var data = _users.GetAllUsers().Where(x => x.Id == id).FirstOrDefault();
            _users.RemoveUser(data);
            ViewBag.Messsage = "Record Delete Successfully";
            return RedirectToAction("index");
        }

    }
}
