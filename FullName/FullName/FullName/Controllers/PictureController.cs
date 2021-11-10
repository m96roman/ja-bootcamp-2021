using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace FullName.Controllers
{
    public class PictureController : Controller
    {
        string path = @$"{Directory.GetCurrentDirectory()}\Images\dog.jfif";

        [Route("/Picture/ShowPicture/dog.jfif")]
        public IActionResult ShowPicture()
        {
            byte[] imageArray = System.IO.File.ReadAllBytes(path);
            return new FileContentResult(imageArray, "image/png");
        }
    }
}
