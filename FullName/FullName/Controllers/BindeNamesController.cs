using FullName.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using NUnit.Framework.Internal.Execution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FullName.Controllers
{
    public class BindeNamesController : Controller
    {
        private static List<BindedName> bindedNames = new List<BindedName>();
        
        public IActionResult SetNamesToBind()
        {
            return View();
        }
  
        [HttpPost]
        public IActionResult SetNamesToBind(BindedName name)
        {
            bindedNames.Add(name);
            return RedirectToAction("ShowBindedNames");
        }

        public IActionResult ShowBindedNames()
        {
            return View(bindedNames);
        }
    }
}
