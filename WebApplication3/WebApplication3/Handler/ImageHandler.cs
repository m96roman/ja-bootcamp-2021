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
            if (request.UrlReferrer != null)
            {
                if (String.Compare(request.Url.Host, request.UrlReferrer.Host, true, CultureInfo.InvariantCulture) == 0)
                {
                    // The requesting host is correct.  
                    // Allow the image (if it exists).  
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
                // No valid image was allowed.  
                // Use the warning image instead.  
                // Rather than hard-code this image, you could  
                // retrieve it from the web.config file  
                // (using the <appSettings> section or a custom  
                // section).   
                imageURL = context.Server.MapPath("~/Handler/notallowed.jfif");
            }
            else
            {
                imageURL = context.Server.MapPath("~/Handler/noimage.png");
            }
            // Serve the image  
            // Set the content type to the appropriate image type.  
            response.ContentType = "Handler/" + Path.GetExtension(imageURL).ToLower();
            response.WriteFile(imageURL);
       }

    }
}