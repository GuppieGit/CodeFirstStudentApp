using Microsoft.EntityFrameworkCore;

namespace StudentApp.Models
{
    public class StudentContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        // Configure the connection string (SQL Server database)
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=StudentDb;Trusted_Connection=True;");
        }
    }
}
