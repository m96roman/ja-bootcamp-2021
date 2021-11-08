using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Web;

namespace ImgHttpHandler.Models
{
    public class ImageHandler : IHttpHandler
    {
        public void ProcessRequest(HttpContext context)
        {
            HttpRequest request = context.Request;
            HttpResponse response = context.Response;

            string imageURL = null;
            var nameOfFile = request.FilePath.Replace("/", "");
            var listOfFile = Directory.GetFiles(request.PhysicalApplicationPath, $"*{request.CurrentExecutionFilePathExtension}").Select(Path.GetFileName).ToArray();
            if (listOfFile.Contains(nameOfFile))
            {
                imageURL = request.PhysicalPath;
            }
            else
            {
                imageURL = context.Server.MapPath("~/images/delete-icon.gif");
            }

            response.ContentType = "image/" + Path.GetExtension(imageURL).ToLower();
            response.BinaryWrite(ImageToByteArray(Image.FromFile(imageURL)));
            response.Flush();
        }
        public byte[] ImageToByteArray(Image img)
        {
            MemoryStream ms = new MemoryStream();
            img.Save(ms, img.RawFormat);

            return ms.ToArray();
        }
        public bool IsReusable
        {
            get
            {
                return true;
            }
        }
    }
}