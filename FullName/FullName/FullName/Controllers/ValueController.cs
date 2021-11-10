using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FullName.Controllers
{
    public class ValueController : Controller
    {
        [Route("/value")]
        [Route("/value/{num?}")]
        [Route("/value/{show}/{num?}")]
        public IActionResult Show()
        {
            ViewData["Message"] = "No value";

            var num = RouteData.Values["num"];
         
            if (num != null)
            {
                ViewData["Message"] = num;
            }

            return View();
        }
    }
}
