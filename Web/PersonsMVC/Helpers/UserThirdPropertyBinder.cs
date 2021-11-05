using Microsoft.AspNetCore.Mvc.ModelBinding;
using PersonsMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsMVC.Helpers
{
    public class UserThirdPropertyBinder : IModelBinder
    {

        public Task BindModelAsync(ModelBindingContext bindingContext)
        {
            if (bindingContext == null)
            {
                throw new ArgumentNullException(nameof(bindingContext));
            }

            var idPartValues = bindingContext.ValueProvider.GetValue("Id");
            var namePartValues = bindingContext.ValueProvider.GetValue("Name");
            var lastNamePartValues = bindingContext.ValueProvider.GetValue("LastName");

            if (namePartValues == ValueProviderResult.None || lastNamePartValues == ValueProviderResult.None)
                return Task.CompletedTask;

            string id = idPartValues.FirstValue;
            string name = namePartValues.FirstValue;
            string lastName = lastNamePartValues.FirstValue;

            UserViewModel userViewModel = new UserViewModel
            {
                Id = id,
                Name = name,
                LastName = lastName,
                ThirdPropertyOfUser = new string((name + lastName).Where(c => Char.IsLetter(c)).ToArray())
            };

            bindingContext.Result = ModelBindingResult.Success(userViewModel);
            return Task.CompletedTask;
        }
    }
}

