using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity; 

namespace LMSBackend.Models
{
    public class Loan
    {
        public int Id { get; set; }

        [Required]
        public string BorrowerId { get; set; } = string.Empty;

        [Required] 
        public string Status { get; set; } = string.Empty; 

        public ApplicationUser Borrower { get; set; } = new ApplicationUser(); 
    }
}
