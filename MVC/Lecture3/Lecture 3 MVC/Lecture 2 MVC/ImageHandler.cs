using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Web;

namespace SimpleHTTPHanlder
{
    public class ImageHandler : IHttpHandler
    {
        public void ProcessRequest(HttpContext context)
        {
            HttpRequest request = context.Request;
            HttpResponse response = context.Response;

            string imageURL = null;
            if (request.UrlReferrer != null)
            {
                if (String.Compare(request.Url.Host, request.UrlReferrer.Host, true, CultureInfo.InvariantCulture) == 0)
                {
                    imageURL = request.PhysicalPath;
                    if (!File.Exists(imageURL))
                    {
                        response.Status = "Image Not Found";
                        response.StatusCode = 404;
                    }
                    else
                    {
                    }
                }
            }
            if (imageURL == null)
            {
                imageURL = context.Server.MapPath("~/images/notallowed.gif");
            }
            response.ContentType = "image/" + Path.GetExtension(imageURL).ToLower();
            response.WriteFile(imageURL);
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