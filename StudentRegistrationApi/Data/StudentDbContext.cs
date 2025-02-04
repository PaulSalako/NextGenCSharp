using Microsoft.EntityFrameworkCore;
using StudentRegistrationApi.Models;

namespace StudentRegistrationApi.Data
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Staff> Staffs { get; set; }
    }
}