using System.Text.RegularExpressions;
using System.Web.Mvc;
using WebApplication.Models;

namespace WebApplication.Binders
{
    public class CreateUserBinder : IModelBinder
    {
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            var context = controllerContext.HttpContext;

            string firstName = context.Request.Form.Get("firstName");
            string lastName = context.Request.Form["lastName"];

            Regex rgx = new Regex("[^a-zA-Z0-9 -]");
            string lastNameFirstName = rgx.Replace(lastName+ " " + firstName, "");

            return new User
            {
                FirstName = firstName,
                LastName = lastName,
                LastNameFirstName = lastNameFirstName
            };
        }
    }
}