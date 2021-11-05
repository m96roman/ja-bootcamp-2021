using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//using System.Web.ModelBinding;
using System.Web.Mvc;

namespace WebApplication3.Models
{
    public class PersonModelBinder : DefaultModelBinder
    {
        public override object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            if (bindingContext.ModelType == typeof(Person))
            {
                HttpRequestBase request = controllerContext.HttpContext.Request;
                // int id = Convert.ToInt32(request.Form.Get("Id"));
                string FirsName = request.Form.Get("Name");
                string Mname = request.Form.Get("Mname");
                string Lname = request.Form.Get("Lname");
                string Message = request.Form.Get("Message");
                return new Person
                {
                    // Id = id,
                    Name = FirsName + Mname + Lname,
                    Message = Message
                };
            }
            else
            {
                return base.BindModel(controllerContext, bindingContext);
            }
        }
    }
}