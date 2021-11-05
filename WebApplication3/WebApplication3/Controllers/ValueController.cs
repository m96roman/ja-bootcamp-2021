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
        [Route("Value")]
        [Route("Value/{id}")]
        [Route("Value/Show/{id}")]
        public ActionResult Show(int? id)
        {         
            return View(id);
        }
    }
}