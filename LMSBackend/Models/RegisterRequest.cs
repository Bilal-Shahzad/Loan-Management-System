using System.ComponentModel.DataAnnotations;

namespace LMSBackend.Models
{
    public class RegisterRequest
    {
        [Required] 
        [MinLength(15)]  
        public string Username { get; set; } = string.Empty; // Set default value to avoid warnings

        [Required] 
        [EmailAddress] 
        public string Email { get; set; } = string.Empty; // Set default value to avoid warnings

        [Required] 
        [MinLength(6)] 
        public string Password { get; set; } = string.Empty; 
    }
}
