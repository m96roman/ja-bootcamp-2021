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

            if (request.UrlReferrer != null)
            {
                if(String.Compare(request.Url.Host, request.UrlReferrer.Host, true, CultureInfo.InvariantCulture) == 0)
                {
                    image = request.PhysicalPath;
                    if (File.Exists(image))
                    {
                        response.Status = "Not Found";
                        response.StatusCode = 404;
                    }
                }
            }

            if(image == null)
            {
                image = context.Server.MapPath("~images/danger.jpg");
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