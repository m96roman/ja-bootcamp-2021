using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using ServiceStack.Host;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace FullName.HttpHandler
{
    public class ImageHandlerMiddleWare
    {
        private readonly RequestDelegate _next;

        public ImageHandlerMiddleWare(RequestDelegate next)
        {
            this._next = next;
        }

        public async Task Invoke(HttpContext context)
        {

            var path = context.Request.Path.ToString();
          
            var responce = context.Response.Body;
           
            string[] formats = new string[] { ".img", ".ai", ".bmp", ".gif", ".ico", ".jpeg", ".jpg", ".png", ".ps", ".psd", ".svg", ".tif", ".tiff", ".jfif" };
          
            foreach (var item in formats)
            {
                if (path.Contains(item))
                {
                    var resPath = @$"{Directory.GetCurrentDirectory()}\Images\not_allowed.png";

                    var photo = File.ReadAllBytes(resPath);

                    await responce.WriteAsync(photo.AsMemory(0, photo.Length));
                }
            }

            await this._next.Invoke(context).ConfigureAwait(false);
        }
    }

    public static class MyMiddlewareExtensions
    {
        public static IApplicationBuilder UseImageHandlerMiddleWare(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ImageHandlerMiddleWare>();
        }
    }
}


