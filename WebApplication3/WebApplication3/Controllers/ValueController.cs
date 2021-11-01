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
       public static List<Person> peopleList = new List<Person>() { new Person { Id = 123, Name = "Yevhen", Message = "Expected message: 123" } };


        // GET: Value

      
        public ActionResult ShowPersons()
        {

            return View(peopleList);
        }
        public ActionResult Show()
        {
            return View(123);
        }
        public ActionResult IncorrectValue()
        {
            return View();
        }
        public ActionResult Create()
        {
            return View(new Person());
        }
        [HttpPost]
        public void Addnew(Person person)
        {
            peopleList.Add(person);
          
        }
    }
}