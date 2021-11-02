using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
   
    public class ValueController : Controller
    {
        [Route("Value/{id}")]
        [Route("Value/Show/{id}")]
        public ActionResult Show()
        {
            if (true)
            {

            }
            return View(123);
        }
        [Route("Value")]
        public ActionResult IncorrectValue()
        {
            return View();
        }
      
    }
}