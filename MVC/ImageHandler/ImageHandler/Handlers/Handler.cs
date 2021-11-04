using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Web;

namespace ImageHandler.Handlers
{
    public class Handler : IHttpHandler
    {
        public void ProcessRequest(HttpContext context)
        {
            HttpRequest request = context.Request;
            HttpResponse response = context.Response;

            string image = null;

            string[] fileCollection = Directory.GetFiles(request.PhysicalApplicationPath, $"*{request.CurrentExecutionFilePathExtension}");
            string fileName = request.FilePath.Replace("/", "");

            foreach (var item in fileCollection)
            {
                if (Path.GetFileName(item) == fileName)
                {
                    image = request.FilePath;
                }
                else
                {
                    image = context.Server.MapPath("~/images/danger.jpg");
                }
            }

            response.ContentType = "image/" + Path.GetExtension(image).ToLower();
            response.WriteFile(image);
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}