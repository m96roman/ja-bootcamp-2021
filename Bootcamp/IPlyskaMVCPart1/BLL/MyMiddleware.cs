using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;

namespace IPlyskaMVCPart1.BLL
{
    public class MyMiddleware
    {
        private readonly RequestDelegate _next;

        public MyMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {

            HttpRequest request = context.Request;
            HttpResponse response = context.Response;
            var outputStream = context.Response.Body;

            try
            {
                var url = context.Request.GetEncodedUrl();
                if (url == @"https://localhost:44364/Image/DownloadPicture")
                {
                    var photo = File.ReadAllBytes("picture 1.gif");
                    response.ContentType = "image/gif";
                    await outputStream.WriteAsync(photo, 0, photo.Length);
                }
            }
            catch (Exception ex)
            {

            }
            await _next.Invoke(context);

            // Clean up. 
        }
    }

    public static class MyMiddlewareExtensions
    {
        public static IApplicationBuilder UseMyMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<MyMiddleware>();
        }
    }
}

