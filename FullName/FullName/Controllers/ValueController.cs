using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FullName.Controllers
{
    public class ValueController : Controller
    {
        [Route("/value/show")]
        [Route("/value/show/123")]
        public IActionResult ShowNumber()
        {
            return View();
        }

        [Route("/value")]
        public IActionResult NoValue()
        {
            return View();
        }
    }
}
