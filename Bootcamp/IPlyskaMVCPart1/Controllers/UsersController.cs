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
            return View();
        }

        [HttpPost]
        [Route("user/add")]
        public IActionResult Create(Users userEdited)
        {
            if (userEdited is null)
            {
                return ViewBag.ErrorMessage = "Error";
            }

            var status = _users.AddUser(userEdited);

            return View();
        }

        [HttpGet]
        [Route("user/add")]
        public IActionResult Create()
        {
            return View();
        }

    }
}
