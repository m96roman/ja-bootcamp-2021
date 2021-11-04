using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class PersonsController : Controller
    {
        public static List<Person> peopleList = new List<Person>() { new Person { Id = 123, Name = "Yevhen", Message = "Expected message: 123" } };

        [Route("Persons")]
        public ActionResult ShowPersonsList()
        {
            return View(peopleList);
        }
        public ActionResult Create()
        {
            return View(new Person());
        }
        [HttpPost]
        public ActionResult AddNewHappy(Person person)
        {
            peopleList.Add(person);
            return RedirectToAction("ShowPersonsList");
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            Person person = peopleList.Where(p => p.Id == id).FirstOrDefault();
            return View(person);
        }

        [HttpPost]
        public ActionResult Edit(Person personEdit)
        {
            Person current = peopleList.Where(p => p.Id == personEdit.Id).FirstOrDefault();
            if (current != null)
            {
                current.Name = personEdit.Name;
                current.Message = personEdit.Message;
            }
            return RedirectToAction("ShowPersonsList");        
        }

        public ActionResult Delete(int id)
        {
            peopleList.Remove(peopleList.Where(p => p.Id == id).FirstOrDefault());
            return RedirectToAction("ShowPersonsList");
        }

        [HttpGet]
        public JsonResult getPerson([Required]string name)
        {          
            return Json(peopleList.Where(t=>t.Name.Contains(name)), JsonRequestBehavior.AllowGet);
        }
        
      
        public ActionResult PersonInfoNew()
        {
            return View(new Person());
        }

        [HttpPost]
        public ActionResult CreateInDB([ModelBinder(typeof(PersonModelBinder))] Person person)
        {
            try
            {
               
                BootcampTrainingEntities bootcampTrainingEntities = new BootcampTrainingEntities();
                bootcampTrainingEntities.InsertPersonInfo(person.Name, person.Message);
                ViewBag.InsertMessage = "Record Inserted";
            }
            catch (Exception ex)
            {
            }

            return RedirectToAction("ShowPersonsList");
        }
    }
}