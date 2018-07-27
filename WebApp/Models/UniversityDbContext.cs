using Microsoft.EntityFrameworkCore;

namespace WebApp.Models
{
    public class UniversityDbContext : DbContext
    {
        public UniversityDbContext(DbContextOptions<UniversityDbContext> options) : base(options)
        {}
        public DbSet<Student> Students { get; set; }
    }
}