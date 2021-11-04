using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HW_Day1_v1.Controllers
{
    public class ValueController : Controller
    {
        // GET: Value
        public ActionResult Show(string id = "No value provided")
        {
            ViewBag.Title = "Value Show";
            ViewBag.Text = id;
            ViewBag.Path = Request.RawUrl;
            return View();
        }
    }
}