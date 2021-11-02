using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsMVC.Controllers
{
    
    public class ValueController : Controller
    {
        [Route("value/{id?}")]
        [Route("value/show/{id?}")]
        public string Index(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                return "No value provided";
            }

            return id;
        }
    }
}
