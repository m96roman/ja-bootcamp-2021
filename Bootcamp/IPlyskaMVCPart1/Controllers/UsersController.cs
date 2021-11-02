﻿using IPlyskaMVCPart1.BLL;
using IPlyskaMVCPart1.Interfaces;
using IPlyskaMVCPart1.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
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

        public IActionResult Index()
        {
           
            return View(_users.GetAllUsers());
        }

        [HttpGet]
        public JsonResult GetUsers(string Id)
        {
            Users user;
            if (Id is not null)
            {
                 user = _users.GetAllUsers().FirstOrDefault(x => x.Id == Convert.ToInt32( Id));
            }
            else
            {
               var users = _users.GetAllUsers();
                return Json(users);
            }
            
            return Json(user);
        }

        [HttpGet]
        public IActionResult FindUser()
        {
            return View();
        }

        [HttpPost]
        public JsonResult FindUser([FromBody] Users user)
        {
            var findedUser = _users.GetAllUsers().FirstOrDefault(x => x.FirstName == user.FirstName || x.LastName == user.LastName);
            return Json(user);
        }

        [HttpPost]
        [Route("user/add")]
        public IActionResult Create([FromBody] Users userEdited)
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
            //throw new Exception();
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
        public ActionResult Edit([FromBody] Users Model)
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
