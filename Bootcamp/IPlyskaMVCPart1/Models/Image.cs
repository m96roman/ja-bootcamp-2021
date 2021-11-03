using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IPlyskaMVCPart1.Models
{
    public class Image
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }

        [Required(ErrorMessage = "Name needs for an image")]
        public string Name { get; set; }
    }
}
