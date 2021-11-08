using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ValueController : Controller
    {
        
        [Route("value/show/{id?}")]
        [Route("value/{id?}")]

        public ActionResult Show(int? id)
        {
            Data data = new Data
            {
                Value = id
            };
            return View(data);
        }
    }
}