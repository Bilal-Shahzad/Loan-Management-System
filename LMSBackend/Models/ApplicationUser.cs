using Microsoft.AspNetCore.Identity;

namespace LMSBackend.Models
{
    public class ApplicationUser : IdentityUser
    {
        // Add additional custom properties if needed
        public ApplicationUser()
        {
            Console.WriteLine("ApplicationUser model created.");
        }
    }
}
