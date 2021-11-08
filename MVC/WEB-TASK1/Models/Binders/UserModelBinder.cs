using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Threading.Tasks;

namespace WEB_TASK1.Models.Binders
{
    public class UserModelBinder : IModelBinder
    {
        private static int iterator = 0;
        private static int Iterator()
        {
            return iterator++;
        }

        public Task BindModelAsync(ModelBindingContext bindingContext)
        {
            if (bindingContext == null)
            {
                throw new ArgumentNullException(nameof(bindingContext));
            }

            var namePartValues = bindingContext.ValueProvider.GetValue("UserName");
            var surnamePartValues = bindingContext.ValueProvider.GetValue("UserSurname");

            string name = namePartValues.FirstValue;
            string surname = surnamePartValues.FirstValue;
            
            var result = new UserModel
            {
                UserId = Iterator(),
                UserName = name,
                UserSurname = surname,
            };

            bindingContext.Result = ModelBindingResult.Success(result);
            
            return Task.CompletedTask;
        }
    }
}
