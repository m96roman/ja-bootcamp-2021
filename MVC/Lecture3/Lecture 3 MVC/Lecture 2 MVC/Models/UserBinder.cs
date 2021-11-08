using Lecture_2.Models;
using System;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;

namespace Lecture_2_MVC.Models
{
    public class UserBinder : DefaultModelBinder
    {
        public override object BindModel(ControllerContext controllerContext, System.Web.Mvc.ModelBindingContext bindingContext)
        {
            if (bindingContext.ModelType == typeof(User))
            {
                HttpRequestBase request = controllerContext.HttpContext.Request;
                int id = Convert.ToInt32(request.Form.Get("Id"));
                string Name = request.Form.Get("Name");
                string LastName = request.Form.Get("LastName");

                return new User()
                {
                    Id = id,
                    Name = Regex.Replace(Name, "[^a-zA-Z]+", "", RegexOptions.Compiled),
                    LastName = Regex.Replace(LastName, "[^a-zA-Z]+", "", RegexOptions.Compiled),
                    NameAndLastName = $"{Regex.Replace(Name, "[^a-zA-Z]+", "", RegexOptions.Compiled)   }.{ Regex.Replace(LastName, "[^a-zA-Z]+", "", RegexOptions.Compiled)}"

                };
            }
            else
            {
                return base.BindModel(controllerContext, bindingContext);
            }
        }
    }
}