﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PersonsMVC.Models;
using PersonsMVC.Models.DPA;
using PersonsMVC.Models.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
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

        public IActionResult Index()
        {
            return View(userRepository.GetUsers());
        }

        private UserViewModel SetViewModel(string id)
        {
            var us = userRepository.GetUser(id);

            if (us == null) { return null; }

            return new UserViewModel { Name = us.Name, LastName = us.LastName, Id = us.Id };
        }

        #region Create

        [HttpGet]
        public IActionResult Create()
        {
            return View(new UserViewModel());
        }

        [HttpPost]
        public IActionResult Create([FromForm] UserViewModel userViewModel)
        {
            if (ModelState.IsValid)
            {
                User user = new User(Guid.NewGuid().ToString(), userViewModel.Name, userViewModel.LastName);
                userRepository.Add(user);

                return Redirect($"/Home/Details/{user.Id}");
            }

            return View(userViewModel);
        }

        #endregion

        #region Edit

        [HttpGet]
        public IActionResult Edit(string id)
        {
            User user = userRepository.GetUser(id);

            if (user != null)
            {
                return View(new UserViewModel { Id = user.Id, LastName = user.LastName, Name = user.Name });
            }

            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public IActionResult Edit(UserViewModel userViewModel)
        {
            if (ModelState.IsValid)
            {
                User user = new User(userViewModel.Id, userViewModel.Name, userViewModel.LastName);

                if (userRepository.Edit(user))
                {
                    return RedirectToAction("Index");
                }

                ModelState.AddModelError("", "Cannot edit this entity!");
            }

            return PartialView(userViewModel);
        }

        #endregion

        #region Delete

        [HttpGet]
        public IActionResult Delete(string id)
        {
            return View(SetViewModel(id));
        }

        public IActionResult Delete(string id, string value)
        {

            userRepository.Delete(id);
            return RedirectToAction(nameof(Index));
        }

        #endregion

        #region Details

        public IActionResult Details(string id)
        {
            return View(SetViewModel(id));
        }

        #endregion

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
