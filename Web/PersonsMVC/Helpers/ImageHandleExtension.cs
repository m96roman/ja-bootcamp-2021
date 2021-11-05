using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonsMVC.Helpers
{

    public static class ImageHandleExtension
    {
        public static IApplicationBuilder UseMyHandler(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<MyImageHandlerMiddleware>();
        }
    }
}
