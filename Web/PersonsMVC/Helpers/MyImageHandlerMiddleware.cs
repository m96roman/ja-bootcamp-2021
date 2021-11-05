using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;

namespace PersonsMVC.Helpers
{
    public class MyImageHandlerMiddleware
    {

        // Must have constructor with this signature, otherwise exception at run time
        public MyImageHandlerMiddleware(RequestDelegate next)
        {
            // This is an HTTP Handler, so no need to store next
        }

        public async Task Invoke(HttpContext context)
        {
            var response = GenerateResponse(context);

            context.Response.ContentType = GetContentType();
            await context.Response.Body.WriteAsync(response, 0, response.Length);
        }

        private byte[] GenerateResponse(HttpContext context)
        {
            var pathToImage = context.Request.Path.ToString();
            pathToImage = Path.GetFullPath("./wwwroot/images/" + pathToImage);

            if (!File.Exists(pathToImage))
            {
                pathToImage = Path.GetFullPath("./wwwroot/images/3.jpg");
            }

            Debug.WriteLine(pathToImage);
            return File.ReadAllBytes(pathToImage);
        }

        private string GetContentType()
        {
            return "image/png";
        }
    }
}
