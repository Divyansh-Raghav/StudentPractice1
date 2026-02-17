using Microsoft.EntityFrameworkCore;
using StudentManagementSys.Models;

namespace StudentManagementSys.Data
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
    }
}
