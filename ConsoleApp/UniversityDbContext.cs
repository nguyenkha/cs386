using Microsoft.EntityFrameworkCore;

namespace ConsoleApp
{
    public class UniversityDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost;Database=University;User Id=sa;Password=P@ssw0rd;");
        }
    }
}