using ServiceStack.Host;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Web;

namespace ImgHttpHandler.Models
{
    public class ImgHandler : IHttpHandler
    {
        public void ProcessRequest(HttpContext context)
        {
            HttpRequest request = context.Request;
            HttpResponse response = context.Response;

            string imageURL = null;
            // Perform a case-insensitive comparison.  
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
                imageURL = context.Server.MapPath("~/images/notallowed.gif");
            }
            // Serve the image  
            // Set the content type to the appropriate image type.  
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