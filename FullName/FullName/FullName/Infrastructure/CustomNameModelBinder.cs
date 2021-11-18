using FullName.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FullName.Infrastructure
{
    public class CustomNameModelBinder: IModelBinder
    {
        private readonly IModelBinder fallbackBinder;

        public CustomNameModelBinder(IModelBinder fallbackBinder)
        {
            this.fallbackBinder = fallbackBinder;
        }

        public Task BindModelAsync(ModelBindingContext bindingContext)
        {         
            if (bindingContext == null)
            {
                throw new ArgumentNullException(nameof(bindingContext));
            }

            var firstName = bindingContext.ValueProvider.GetValue("FirstName");
            var lastName = bindingContext.ValueProvider.GetValue("LastName");

            if (firstName == ValueProviderResult.None || lastName == ValueProviderResult.None)
                return fallbackBinder.BindModelAsync(bindingContext);

            Regex reg = new Regex("[^a-zA-Z']");

            string first = reg.Replace(firstName.FirstValue, string.Empty);
            string last = reg.Replace(firstName.FirstValue, string.Empty);

            var result = new BindedName() { BindedFirstName = first, BindedLastName = last };
        
            bindingContext.Result = ModelBindingResult.Success(result);
            return Task.CompletedTask;
        }
    }
}

