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
        private static string Path { get; } = $@"{Directory.GetCurrentDirectory()}\Images\Img1.png";

        public string Name { get; set; }

        public ViewResult Image()
        {
            return View(new FileUploadModel());
        }

        [HttpPost]
        public IActionResult AddNewImage(FileUploadModel model)
        {
            //Getting file meta data
            var fileName = Path;

            using (FileStream fs = System.IO.File.Create($@"{Directory.GetCurrentDirectory()}\Images\{model.MyImage.FileName}.png"))

            {
                model.MyImage.CopyTo(fs);
            }

            // do something with the above data
            return Redirect("Image");
        }

        public ActionResult GetImage()
        {

            byte[] imageArray = System.IO.File.ReadAllBytes(Path);
            return new FileContentResult(imageArray, "image/png");
        }
        
    }
}
