using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Models
{
    public class UserModelBinder
        : IModelBinder
    {
        private static readonly Regex regex = new Regex("[^a-zA-Z]");
        public  object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            var context = controllerContext.HttpContext;
            string name = context.Request.Form["FirstName"];
            string lastname = context.Request.Form["LastName"];
            var thirdfield = regex.Replace(name, String.Empty)+"."+regex.Replace(lastname,String.Empty);

            return new User
            {
                FirstName =name,
                LastName = lastname,
                ThirdProperty = thirdfield
            };
        }
    }
}