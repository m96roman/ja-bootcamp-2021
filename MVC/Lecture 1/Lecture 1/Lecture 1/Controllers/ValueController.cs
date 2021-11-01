using Lecture_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lecture_1.Controllers
{
    public class valueController : Controller
    {
        // GET: value
        public ActionResult Show(int? id)
        {
            var number = new Value() { id = id};
            return View(number);
        }
    }
}