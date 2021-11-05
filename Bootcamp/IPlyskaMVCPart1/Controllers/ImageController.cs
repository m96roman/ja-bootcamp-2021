using IPlyskaMVCPart1.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Extensions.Configuration;


namespace IPlyskaMVCPart1.Controllers
{
    public class ImageController : Controller
    {

        public IActionResult Index()
        {

            Image image = new Image()
            {
                Name ="Monitor",
                Description = "Acer - 23.8 IPS LED FHD FreeSync Monitor(HDMI, VGA) - Black",
                Id = 0,
               // Url = @"file:" + Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", "download.jfif")
            };

            return View(image);
        }

        [HttpGet]
        public FileResult DownloadPicture()
        {
            if (!System.IO.File.Exists(Startup.PictureNameForController))
            {
                throw new FileNotFoundException();
            }

            byte[] fileBytes = System.IO.File.ReadAllBytes(@$"{Startup.PictureNameForController}");
            string fileName = @$"{Startup.PictureNameForController}";
            return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Octet, fileName);
        }
    }
}
