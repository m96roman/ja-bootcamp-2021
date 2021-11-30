using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FullName.Models;

namespace FullName.Controllers
{
    public class NamesController : Controller
    {
        readonly static List<Name> names = new List<Name>(){
            new Name { Id = 0, FirstName = "Tom", LastName="Baker" },
             new Name { Id = 1, FirstName = "Tom", LastName="Lawyer" },
              new Name { Id = 2, FirstName = "Sam", LastName="Carpenter" }
        };
        
        private static int generatedId = 2;

        public int GenereteId()
        {
            return generatedId += 1;
        }
     
        public ActionResult ShowName()
        {
            return View(names);
        }

        [HttpPost]
        public ActionResult CreateUser(Name name)
        {
            name.Id = GenereteId();
            names.Add(name);
            return RedirectToAction("ShowName");
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            var res = names.FirstOrDefault(n => n.Id == id);
            names.Remove(res);
            return RedirectToAction("ShowName", "Names");
        }
      
        [HttpGet]
        public ActionResult Edit(int id)
        {
            return View(names.FirstOrDefault(n => n.Id == id));
        }

        [HttpPost]
        public ActionResult Edit(Name editedName)
        {
            var edited =  names.FirstOrDefault(n => n.Id == editedName.Id);
            edited.FirstName = editedName.FirstName;
            edited.LastName = editedName.LastName;

            return RedirectToAction("ShowName");
        }
        public ActionResult AjaxSearch()
        {
            return View();
        }

        [HttpPost]
        public ActionResult FindSearched([FromBody] Input name)
        {
            string searched = name.Searched.ToLower();
            var seachedResult = names.Where(n => n.FirstName.ToLower() == searched || n.LastName.ToLower() == searched).ToList();

            if (seachedResult.Count == 0)
            {
                return null;
            }

            return Json(seachedResult);
        }

    }
}
