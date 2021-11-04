using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IPlyskaMVCPart1.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding;


namespace IPlyskaMVCPart1.BLL
{
    public class ClientModelBinderProvider : IModelBinderProvider
    {
        public IModelBinder GetBinder(ModelBinderProviderContext context)
        {
            if (context.Metadata.ModelType == typeof(Client))
                return new ClientBinder();

            return null;
        }
    }
}
