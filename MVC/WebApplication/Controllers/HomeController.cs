using System.Web.Mvc;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Show(int? id)
        {
            if(id.HasValue)
            {
                ViewBag.Message = id;
            }
            else
            {
                ViewBag.Message = "No value provided";
            }

            return View();
        }
    }
}