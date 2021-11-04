using IPlyskaMVCPart1.BLL;
using IPlyskaMVCPart1.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IPlyskaMVCPart1.Controllers
{
    public class ClientController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index([ModelBinder(BinderType = typeof(ClientBinder))] Client client)
        {
            return View("Client", client);
        }
    }
}
