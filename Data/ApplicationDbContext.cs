using Microsoft.EntityFrameworkCore;
using TaskManagementApplication.Models.Entities;

namespace TaskManagementApplication.Data
{
    public class ApplicationDbContext:DbContext
    {
        //This is a constructor
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Student> Students { get; set; }

    }
}
