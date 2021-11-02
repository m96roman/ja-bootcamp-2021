using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Microsoft.Extensions.Logging;
using PersonsMVC.Models;
using PersonsMVC.Models.DPA;
using PersonsMVC.Models.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace PersonsMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly IUserRepository userRepository;

        public HomeController(ILogger<HomeController> logger, IUserRepository userRepository)
        {
            _logger = logger;
            this.userRepository = userRepository;
        }

        #region UserViewModel helpers

        private UserViewModel SetViewModel(string id)
        {
            var us = userRepository.GetUser(id);

            return GetViewModel(us);
        }

        private static UserViewModel GetViewModel(User us)
        {
            if (us == null) { return null; }

            return new UserViewModel { Name = us.Name, LastName = us.LastName, Id = us.Id };
        }

        private IActionResult GetViewOnUser(string id, string view)
        {
            UserViewModel usModel = SetViewModel(id);

            if (usModel != null)
            {
                return View(view, usModel);
            }

            TempData["Error"] = $"Cannot find user with id {id}!";
            return RedirectToAction(nameof(Index));
        }

        #endregion

        #region Index methods

        public IActionResult Index()
        {
            return View(userRepository.GetUsers().Select(u => GetViewModel(u)));
        }

        [HttpGet]
        public PartialViewResult Filter(FilterUserViewModel filter)
        {
            IEnumerable<User> usersList = userRepository.GetUsers(filter);

            return PartialView("UsersList", usersList.Select(u => GetViewModel(u)));
        }

        #endregion

        #region Create

        [HttpGet]
        public IActionResult Create()
        {
            return PartialView("UserModify", new UserViewModel());
        }

        [HttpPost]
        public IActionResult Create([FromForm] UserViewModel userViewModel)
        {
            if (ModelState.IsValid)
            {
                User user = new User(Guid.NewGuid().ToString(), userViewModel.Name, userViewModel.LastName);
                userRepository.Add(user);
                _logger.LogInformation(user.ToString() + " is created!");

                //201= created
                return Json(new { created = true });
            }

            return PartialView("UserModify", userViewModel);
        }

        #endregion

        #region Edit

        [HttpGet]
        public IActionResult Edit(string id)
        {
            return GetViewOnUser(id, "UserModify");
        }

        [HttpPost]
        public IActionResult Edit(UserViewModel userViewModel)
        {
            if (ModelState.IsValid)
            {
                User user = new User(userViewModel.Id, userViewModel.Name, userViewModel.LastName);

                if (userRepository.Edit(user))
                {
                    _logger.LogInformation(user + " is updated");

                    return RedirectToAction("Index");
                }

                _logger.LogInformation("cannot update following entity " + user);
                ModelState.AddModelError("", "Cannot update this entity!");
            }

            return PartialView("UserModify", userViewModel);
        }

        #endregion

        #region Delete

        [HttpGet]
        public IActionResult Delete(string id)
        {
            return GetViewOnUser(id, "Delete");
        }

        [HttpPost]
        public IActionResult Delete(string id, string value)
        {
            if (!userRepository.Delete(id))
            {
                ViewData["Error"] = "The user was not deleted!";

                return GetViewOnUser(id, "Delete");
            }

            _logger.LogInformation($"Succesfullty deleted user with id {id}");
            return RedirectToAction(nameof(Index));
        }

        #endregion

        #region Details

        public IActionResult Details(string id)
        {
            return GetViewOnUser(id, "Details");
        }

        #endregion
    }
}
