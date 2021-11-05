using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using IPlyskaMVCPart1.Models;

namespace IPlyskaMVCPart1.BLL
{
    public class ClientBinder : IModelBinder
    {
        public Task BindModelAsync(ModelBindingContext bindingContext)
        {
            if (bindingContext == null)
            {
                throw new ArgumentNullException(nameof(bindingContext));
            }

            string clientName = bindingContext.HttpContext.Request.Form["fname"];
            string clientLastName = bindingContext.HttpContext.Request.Form["lname"];

            var result = new Client()
            {
                FirstName = clientName,
                LastName = clientLastName
            };

            bindingContext.Result = ModelBindingResult.Success(result);

            return Task.CompletedTask;
        }
    }
}
