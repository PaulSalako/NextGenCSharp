// These are the necessary imports for our controller
using Microsoft.AspNetCore.Mvc;              // For API controller functionality
using Microsoft.EntityFrameworkCore;         // For database operations
using StudentRegistrationApi.Data;           // For your DbContext
using StudentRegistrationApi.Models;         // For Staff model

namespace StudentRegistrationApi.Controllers
{
    [Route("api/[controller]")]              // This means URLs will start with "api/staff"
    [ApiController]                          // Marks this as an API controller
    public class StaffController : ControllerBase
    {
        private readonly StudentDbContext _context;    // Database context variable

        // Constructor - gets database context through dependency injection
        public StaffController(StudentDbContext context)
        {
            _context = context;
        }

        // GET: api/Staff - Gets all staff members
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Staff>>> GetStaff()
        {
            return await _context.Staffs.ToListAsync();    // Returns all staff from database
        }

        // GET: api/Staff/5 - Gets a specific staff member by ID
        [HttpGet("{id}")]
        public async Task<ActionResult<Staff>> GetStaff(int id)
        {
            var staff = await _context.Staffs.FindAsync(id);   // Find staff by ID

            if (staff == null)
            {
                return NotFound();   // Return 404 if staff not found
            }

            return staff;    // Return the found staff member
        }

        // POST: api/Staff - Creates a new staff member
        [HttpPost]
        public async Task<ActionResult<Staff>> PostStaff(Staff staff)
        {
            _context.Staffs.Add(staff);              // Add new staff to context
            await _context.SaveChangesAsync();       // Save to database

            // Return created staff with location header
            return CreatedAtAction(nameof(GetStaff), new { id = staff.Id }, staff);
        }

        // PUT: api/Staff/5 - Updates an existing staff member
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStaff(int id, Staff staff)
        {
            if (id != staff.Id)     // Check if ID in URL matches staff object
            {
                return BadRequest();
            }

            _context.Entry(staff).State = EntityState.Modified;    // Mark entity as modified

            try
            {
                await _context.SaveChangesAsync();   // Try to save changes
            }
            catch (DbUpdateConcurrencyException)     // Handle if staff was deleted/modified
            {
                if (!StaffExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();  // Return 204 No Content on success
        }

        // DELETE: api/Staff/5 - Deletes a staff member
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStaff(int id)
        {
            var staff = await _context.Staffs.FindAsync(id);   // Find staff
            if (staff == null)
            {
                return NotFound();   // Return 404 if not found
            }

            _context.Staffs.Remove(staff);      // Remove staff from context
            await _context.SaveChangesAsync();  // Save changes to database

            return NoContent();  // Return 204 No Content
        }

        // Helper method to check if a staff exists
        private bool StaffExists(int id)
        {
            return _context.Staffs.Any(e => e.Id == id);
        }
    }
}