using auth.Models;
using Microsoft.EntityFrameworkCore;

namespace auth.Context
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=Employee_A;Trusted_Connection=True;TrustServerCertificate=True");
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<User> Users { get; set; }
    }


}
