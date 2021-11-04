using IPlyskaMVCPart1.BLL;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IPlyskaMVCPart1.Models
{
    [ModelBinder(BinderType = typeof(ClientBinder))]
    public class Client
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
