using System.ComponentModel.DataAnnotations;
using System.Web.Http.ModelBinding;
using WEB_TASK1.Models.Binders;

namespace WEB_TASK1.Models
{
    
    public class UserModel        
    {
        public int UserId { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        public string UserSurname { get; set; }
    }
}
