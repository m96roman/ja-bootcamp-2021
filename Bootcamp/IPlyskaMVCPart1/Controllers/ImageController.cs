﻿using IPlyskaMVCPart1.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

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
    }
}
