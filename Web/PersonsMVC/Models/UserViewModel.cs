﻿using Microsoft.AspNetCore.Mvc;
using PersonsMVC.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsMVC.Models
{
    [ModelBinder(BinderType = typeof(UserThirdPropertyBinder))]
    public class UserViewModel
    {

        public string Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [StringLength(120)]
        public string LastName { get; set; }

        [Display(Name = "Something")]
        public string ThirdPropertyOfUser { get; set; }
    }
}
