using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WEB_TASK1.Models;

namespace WEB_TASK1.Controllers
{
    public class ImageController : Controller
    {
        private static string Path { get; } = $@"{Directory.GetCurrentDirectory()}\Images";

        public string Name { get; set; }

        public ViewResult Image()
        {
            return View(new FileUploadModel());
        }

        [HttpPost]
        public IActionResult AddNewImage(FileUploadModel model)
        {
            var fileName = Path;

            using (FileStream fs = System.IO.File.Create($@"{Directory.GetCurrentDirectory()}\Images\{model.MyImage.FileName}"))

            {
                model.MyImage.CopyTo(fs);
            }

            return Redirect("Image");
        }

        [HttpPost]
        public ActionResult GetImage(string name)
        {
            if (System.IO.File.Exists($@"{Path}\{name}.png"))
            {
                byte[] imageArray = System.IO.File.ReadAllBytes($@"{Path}\{name}.png");

                return new FileContentResult(imageArray, "image/png");
            }
            else 
            {
                byte[] imageArray = System.IO.File.ReadAllBytes($@"{Path}\Default.png");

                return new FileContentResult(imageArray, "image/png");
            }                      
        }
        
    }
}
