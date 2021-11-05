using Microsoft.AspNetCore.Mvc;

namespace MVCDayOne.Controllers
{
    public class ValueController : Controller
    {
        [Route("/value/{id}")]
        [Route("/value/show/{id}")]
        public ActionResult Show(int id)
        {
            return View();
        }

        [Route("/value")]
        public ActionResult WithoutValue()
        {
            return View();
        }
    }
}