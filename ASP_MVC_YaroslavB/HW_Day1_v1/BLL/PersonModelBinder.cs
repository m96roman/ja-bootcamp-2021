using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HW_Day1_v1.BLL
{
    public class PersonModelBinder : DefaultModelBinder
    {
        public override object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            HttpContextBase context = controllerContext.HttpContext;
            string firstName = context.Request.Form.Get("FirstName");
            string lastName = context.Request.Form.Get("LastName");
            string firstNameParsed = new string(firstName.Trim().Where(c => char.IsLetter(c)).ToArray());
            string lastNameParsed = new string(lastName.Trim().Where(c => char.IsLetter(c)).ToArray());
            string personName = firstNameParsed + "." + lastNameParsed;
            var person = new HW_Day1_v1.Models.Person() { Name = personName };

            return person;
        }
    }
}