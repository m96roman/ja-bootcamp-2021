using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HW_Day1_v1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public void GenerateException()
        {
            string msg = null;
            var a = msg.Length;
        }

        protected override void OnException(ExceptionContext filterContext)
        {
            filterContext.ExceptionHandled = true;

            //log error
            ViewBag.ErrorText = filterContext.Exception.Message;
            filterContext.Result = View("Error");
        }
    }
}