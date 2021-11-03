using System;
using System.Web.Mvc;

namespace WebApplication.Controllers
{
    public class ErrorController : Controller
    {
        // GET: Error
        public ActionResult Index()
        {
            throw new Exception("Here is mistake!");
        }
        public ActionResult About()
        {
            throw new NullReferenceException();
        }
        public ActionResult Contact()
        {
            throw new DivideByZeroException();
        }
    }
}