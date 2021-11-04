using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Web;

namespace WebApplication3.Handler
{
    public class ImageHandler : IHttpHandler
    {
        public bool IsReusable
        {
            get
            {
                return false;
            }
        }

        public void ProcessRequest(HttpContext context)
        {
            HttpRequest request = context.Request;
            HttpResponse response = context.Response;

            string imageURL = null;
            var nameOfFile = request.FilePath.Replace("/", "");
            var listOfFile = Directory.GetFiles(request.PhysicalApplicationPath, $"*{request.CurrentExecutionFilePathExtension}");

            foreach (string file in listOfFile)
            {
                if (Path.GetFileName(file) == nameOfFile)
                {
                    imageURL = request.PhysicalPath;                  
                    break;
                }
                else
                {
                    imageURL = context.Server.MapPath("~/notallowed.jpeg");
                }
            }
            response.ContentType = "image/" + Path.GetExtension(imageURL).ToLower();
            response.WriteFile(imageURL);              
       }
    }
}