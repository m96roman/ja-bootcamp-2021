using System;
using System.Globalization;
using System.IO;
using System.Web;

namespace WebApplication
{
    public class ImageHandler : IHttpHandler
    {
        public bool IsReusable
        {
            get { return false; }
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
                    imageURL = request.PhysicalPath;
                    if (!File.Exists(imageURL))
                    {
                        response.Status = "Image Not Found";
                        response.StatusCode = 404;
                    }
                }
            }
            if (imageURL == null)
            {
                imageURL = context.Server.MapPath($@"{Directory.GetCurrentDirectory()}\handlr.jpg");
            }

            response.ContentType = "image/" + Path.GetExtension(imageURL).ToLower();
            response.WriteFile(imageURL);
        }
    }
}