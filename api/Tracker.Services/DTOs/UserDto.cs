using System.ComponentModel.DataAnnotations;

namespace Tracker.Services.DTOs
{
    public class UserDto
    {
        [Required(ErrorMessage = "Username is required.")]
        [MaxLength(ErrorMessage = "Must be a maximum of 15 characters.")]
        public string Username { get; set; }    

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Valid email address is required.")]
        public string Email { get; set; }  

        [Required(ErrorMessage = "Password must be provided.")] 
        public string Password { get; set; }
    }
}