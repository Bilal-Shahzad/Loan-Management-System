using Microsoft.AspNetCore.Mvc;
using LMSBackend.Models;  

namespace LMSBackend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoanController : ControllerBase
    {
        // GET: api/loan
        [HttpGet]
        public IActionResult GetLoans()
        {
            return Ok(new { message = "Loans fetched successfully" });
        }

        // POST: api/loan
        [HttpPost]
        public IActionResult CreateLoan([FromBody] Loan loan)
        {
            return Ok(new { message = "Loan created successfully", loan });
        }
    }
}
