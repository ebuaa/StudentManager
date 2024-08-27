using System.ComponentModel.DataAnnotations;

namespace StudentManager.Models.ViewModels
{
    public class EditStudentViewModel
    {
        public Guid Id { get; set; }  
        [Required]
        [StringLength(100, ErrorMessage = "The name must be at most 100 characters long.")]
        public string Name { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [Required]
        [Phone(ErrorMessage = "Invalid Phone Number")]
        public string Phone { get; set; }

        public bool Subscribed { get; set; }
    }
}
