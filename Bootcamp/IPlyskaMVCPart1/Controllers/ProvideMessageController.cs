using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IPlyskaMVCPart1.Controllers
{
    public class ProvideMessageController : Controller
    {
        [HttpGet]
        [Route("value/show/{id}")]
        public ActionResult Details(int id)
        {
            ViewBag.Message = id;
            return View();
        }

        [HttpGet]
        [Route("value/{id?}")]
        public ActionResult DetailsWithOtherRoot(int? id)
        {
            ViewBag.Message = id;
            return View();
        }
    }
}
