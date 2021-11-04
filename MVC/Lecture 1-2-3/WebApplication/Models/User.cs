using System.ComponentModel.DataAnnotations;

namespace WebApplication.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "LastName.FirstName")]
        public string LastNameFirstName { get; set; }
    }
}