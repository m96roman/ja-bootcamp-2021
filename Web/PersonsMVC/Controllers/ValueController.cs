using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsMVC.Controllers
{
    [ApiController]
    [Route("value")]
    public class ValueController : ControllerBase
    {
        [Route("{id?}")]
        [Route("show/{id?}")]
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
