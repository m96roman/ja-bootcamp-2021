using Microsoft.AspNetCore.Mvc;

namespace MVCDayOne.Controllers
{
    public class ValueController : Controller
    {
        public ActionResult Show()
        {
            return View();
        }

        [Route("/111")]
        public ActionResult WithoutValue()
        {
            return View();
        }

        [HttpGet]
        [Route("/Value/{id}")]
        public ActionResult ValueId(int id)
        {
            return View(id);
        }
    }
}